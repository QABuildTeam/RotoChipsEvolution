/*
 * File:        AudioTrackEnum.cs
 * Author:      Igor Spiridonov
 * Descrpition: Enumerations AudioTrackEnum and SFXEnum enumerate music tracks and sound effects in the game, accordingly
 * Created:     18.09.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RotoChips.Management
{
    public enum AudioTrackEnum
    {
        Unknown,

        // music tracks
        GalleryAmbience,
        FinaleTheme,
        VictoryTheme,
        LevelTrack01,
        LevelTrack02,
        LevelTrack03,
        LevelTrack04,
        LevelTrack05,
        WorldTheme
    }

    public enum SFXEnum
    {
        Unknown,

        // sfx tracks
        GreenFirework,
        OrangeFirework,
        RedFirework,
        LogoStart,
        LogoWind,
        LogoCoin,
        LogoPad,
        LogoCubeLL,
        LogoCubeLR,
        LogoCubeUL,
        LogoCubeUR,
        PuzzleButtonFastRotate,
        PuzzleButtonSlowRotate,
        PuzzleVibeHi,
        PuzzleVibeLo,
        WorldSelectorPressed,
        WorldDescriptionOpen,
        WorldDescriptionClose,
        UIButtonClick,
        UIPanelClick,
        UIHintShow,
        UIHintClose
    }
}
