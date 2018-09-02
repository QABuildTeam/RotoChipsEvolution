/*
 * File:        PuzzleBuilder.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class PuzzleBuilder creates the puzzle field
 * Created:     02.09.2018
 */
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using RotoChips.Management;
using RotoChips.Generic;

namespace RotoChips.Puzzle
{
    public class TileFlasher : FlashingObject
    {
        public enum FlashType
        {
            None,
            Good,
            Bad
        }
        FlashType type = FlashType.None;

        [SerializeField]
        protected Color goodColor;
        [SerializeField]
        protected Color badColor;
        [SerializeField]
        protected int flashCount;

        SpriteRenderer spriteRenderer;

        GameObject flashListener;

        MessageRegistrator registrator;
        private void Awake()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
            registrator = new MessageRegistrator(
                InstantMessageType.PuzzleFlashTile, (InstantMessageHandler)OnPuzzleFlashTile
            );
            registrator.RegisterHandlers();
        }

        // message handling
        void OnPuzzleFlashTile(object sender, InstantMessageArgs args)
        {
            if (type == FlashType.None)
            {
                type = (FlashType)args.arg;
                StartCoroutine(Flash());
            }
        }

        private void OnDestroy()
        {
            registrator.UnregisterHandlers();
        }

        protected override bool IsValidPeriod(int periodCounter)
        {
            if (periodCounter < flashCount * 2)
            {
                return true;
            }
            else
            {
                type = FlashType.None;
                GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.PuzzleTileFlashed, this);
                return false;
            }
        }

        protected override void Visualize(float factor)
        {
            if (type != FlashType.None)
            {
                spriteRenderer.color = Color.Lerp(Color.white, type == FlashType.Good ? goodColor : badColor, factor);
            }
        }

    }
}
