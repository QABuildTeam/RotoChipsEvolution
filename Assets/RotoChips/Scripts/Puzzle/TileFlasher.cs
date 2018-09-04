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
    public enum FlashType
    {
        None,
        Good,
        Bad
    }

    public class TileFlashArgs
    {
        public Vector2Int maxId;
        public FlashType type;
    }

    public class TileFlasher : FlashingObject
    {
        FlashType type = FlashType.None;

        [SerializeField]
        protected Color goodColor;
        [SerializeField]
        protected Color badColor;
        [SerializeField]
        protected int flashCount;

        protected Vector2Int tileId;
        MeshRenderer meshRenderer;

        MessageRegistrator registrator;
        public void Init(Vector2Int id)
        {
            tileId = id;
            meshRenderer = GetComponent<MeshRenderer>();
            type = FlashType.None;
            Visualize(0);
            registrator = new MessageRegistrator(
                InstantMessageType.PuzzleFlashTile, (InstantMessageHandler)OnPuzzleFlashTile
            );
            registrator.RegisterHandlers();
        }

        // message handling
        Coroutine flashCoroutine;
        void OnPuzzleFlashTile(object sender, InstantMessageArgs args)
        {
            TileFlashArgs flashArgs = (TileFlashArgs)args.arg;
            if (flashArgs.maxId.y > tileId.y || (flashArgs.maxId.y == tileId.y && flashArgs.maxId.x >= tileId.x))
            {
                if (type == FlashType.None)
                {
                    type = flashArgs.type;
                    if (type == FlashType.None)
                    {
                        if (flashCoroutine != null)
                        {
                            StopCoroutine(flashCoroutine);
                            flashCoroutine = null;
                        }
                        Visualize(0);
                    }
                    else
                    {
                        flashCoroutine = StartCoroutine(Flash());
                    }
                }
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
                Material[] materials = meshRenderer.materials;
                materials[0].SetColor("_EmissionColor", Color.Lerp(Color.black, type == FlashType.Good ? goodColor : badColor, factor));
                meshRenderer.materials = materials;
            }
        }

    }
}
