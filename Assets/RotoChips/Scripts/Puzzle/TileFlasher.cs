﻿/*
 * File:        TileFlasher.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class TileFlasher flashes a tile with a good or bad color
 * Created:     02.09.2018
 */
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
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
        public Vector2Int id;
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
        public Vector2Int TileId
        {
            get
            {
                return tileId;
            }
        }
        MeshRenderer meshRenderer;

        public void Init(Vector2Int id)
        {
            tileId = id;
            meshRenderer = GetComponent<MeshRenderer>();
            type = FlashType.None;
            Visualize(flashRange.min);
        }

        protected override void AwakeInit()
        {
            registrator.Add(new MessageRegistrationTuple { type = InstantMessageType.PuzzleFlashTile, handler = OnPuzzleFlashTile });
        }

        // message handling
        Coroutine flashCoroutine;
        void OnPuzzleFlashTile(object sender, InstantMessageArgs args)
        {
            List<TileFlashArgs> flashArgsList = (List<TileFlashArgs>)args.arg;
            if (flashArgsList != null)
            {
                foreach (TileFlashArgs flashArgs in flashArgsList)
                {
                    if (flashArgs.id.y == tileId.y && flashArgs.id.x == tileId.x)
                    {
                        if (type != FlashType.None)
                        {
                            if (flashCoroutine != null)
                            {
                                StopCoroutine(flashCoroutine);
                                flashCoroutine = null;
                            }
                            Visualize(flashRange.min);
                        }
                        type = flashArgs.type;
                        if (type != FlashType.None)
                        {
                            flashCoroutine = StartCoroutine(Flash());
                        }
                        break;
                    }
                }
            }
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
