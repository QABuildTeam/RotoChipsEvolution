/*
 * File:        HintType.cs
 * Author:      Igor Spiridonov
 * Descrpition: Enum HintType enumerates all the hints used in the game
 * Created:     22.09.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RotoChips.UI
{
    public enum HintType
    {
        None,
        FirstTimeWelcome,
        FirstTimeWelcome2,
        BackLevelButton,
        AskForRestartButton,
        ShowSourceButton,
        AutoStepButton,
        ZoomWorldOut,
        ZoomWorldIn,
        TapLevel,
        TapPuzzleButton,
        FirstTileCongratulation,
        FirstRowCongratulation,
        SecondRowCongratulation,
        HintForAutoStep,
        FirstPuzzleCongratulation,
        GalleryOpened,
        GameFinishedCongratulation,
        GameRestartButton,
        GameRollsButton,
        PuzzleFirstShuffled,
        FirstPuzzleQuartetRotated,
        LevelNotYetPlayable,
        PuzzlePointScoreTapped,
        PuzzleCoinsScoreTapped,
        WorldPointScoreTapped,
        WorldCoinsScoreTapped,
        NoMoreBonuses,
        FirstTileInPlace,
        SecondTileInPlace,
        ThirdTileInPlace,
        TwoRowsInPlace,
        FirstLevelChallenge,
        FirstTileButtonsHint,
        SecondTileButtonsHint,
        SecondLevelChallenge,
        TwoRowsInPlace2,
        TwoRowsInPlace1,
        ShowAdHint,
        RestorePurchases,
        BackToPuzzle
    }
}
