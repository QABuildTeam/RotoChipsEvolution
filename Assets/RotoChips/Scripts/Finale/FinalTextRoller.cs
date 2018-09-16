/*
 * File:        FinalTextRoller.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class FinalTextRoller controls the final text rolls in the Finale scene
 * Created:     15.09.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RotoChips.Management;

namespace RotoChips.Finale
{
    public class FinalTextRoller : MonoBehaviour
    {

        [SerializeField]
        protected int finaleTextIndex;  // this is needed to identify the object by the FinaleSceneController

        [System.Serializable]
        protected enum ParentAlign
        {
            BottomToTop,    // an object's top is positioned near the bottom of its parent, and the object's position is relative to its parent top
            TopToBottom,    // an object's bottom is positioned near the top of its parent, and the object's position is relative to its parent bottom
            LeftToRight,    // an object's left side is positioned near the right side of its parent, and the object's position is relative to its parent left side
            RightToLeft,    // an object's right side is positioned near the left side of its parent, and the object's position is relative to its parent right side
            InPlace         // an object's position is equal to the center of its parent
        }
        [System.Serializable]
        protected class MovementKey
        {
            public Vector2 offset;      // an offset from one of the parent's sides
            public ParentAlign align;   // a relative align of the text object to the parent's side
            public float delay;         // delay in seconds before or after the move
        }

        [SerializeField]
        protected MovementKey[] movementKeys;

        [SerializeField]
        protected float movingTime;
        Vector2 originalPosition;
        [SerializeField]
        protected string textId;

        MessageRegistrator registrator;
        private void Awake()
        {
            registrator = new MessageRegistrator(InstantMessageType.FinaleRollText, (InstantMessageHandler)OnFinaleRollText);
            registrator.RegisterHandlers();
        }

        Vector2 OffsetToPosition(MovementKey movementKey)
        {
            Rect r = transform.parent.GetComponent<RectTransform>().rect;
            Vector2 p = originalPosition;
            switch (movementKey.align)
            {
                case ParentAlign.BottomToTop:
                    p.y += r.height;
                    break;
                case ParentAlign.TopToBottom:
                    p.y -= r.height;
                    break;
                case ParentAlign.LeftToRight:
                    p.x += r.width;
                    break;
                case ParentAlign.RightToLeft:
                    p.x -= r.width;
                    break;
            }
            return p + movementKey.offset;
        }

        // Use this for initialization
        void Start()
        {
            GetComponent<Text>().text = GlobalManager.MLanguage.Entry(textId);
            originalPosition = transform.localPosition;
            ResetToOriginal();
        }

        void ResetToOriginal()
        {
            transform.localPosition = OffsetToPosition(movementKeys[0]);
        }

        IEnumerator RollText()
        {
            // delay before the movement (pre-delay)
            if (movementKeys[0].delay > 0)
            {
                yield return new WaitForSeconds(movementKeys[0].delay);
            }
            // prepare start and end positions for the text chunk
            Vector2 startLocalPosition = OffsetToPosition(movementKeys[0]);
            Vector2 endLocalPosition = OffsetToPosition(movementKeys[1]);
            transform.localPosition = startLocalPosition;
            float currentTime = 0;
            // actually roll the text
            while (currentTime < movingTime)
            {
                yield return null;
                currentTime += Time.deltaTime;
                transform.localPosition = Vector2.Lerp(startLocalPosition, endLocalPosition, currentTime / movingTime);
            }
            transform.localPosition = endLocalPosition;
            // notify of movement end
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.FinaleTextRolled, this, finaleTextIndex);
            // delay after movement (post-delay)
            if (movementKeys[1].delay > 0)
            {
                yield return new WaitForSeconds(movementKeys[1].delay);
            }
            // notify of post-delay end
            GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.FinaleTextPostDelayed, this, finaleTextIndex);
        }

        // message handling
        void OnFinaleRollText(object sender, InstantMessageArgs args)
        {
            int textToRoll = (int)args.arg;
            if (textToRoll == 0)
            {
                // zero is a special value; it means to reset the text to its original position
                ResetToOriginal();
            }
            else
            {
                if (textToRoll == finaleTextIndex)
                {
                    StartCoroutine(RollText());
                }
            }
        }

        private void OnDestroy()
        {
            registrator.UnregisterHandlers();
        }
    }
}
