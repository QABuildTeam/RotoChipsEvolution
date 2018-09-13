/*
 * File:        InstantMessageType.cs
 * Author:      Igor Spiridonov
 * Descrpition: Enumeration InstantMessageType contains code definitions for all global messages in the game
 * Created:     13.09.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RotoChips.Management
{

    // basic yet important game event types
    public enum InstantMessageType
    {
        Unknown,

        // GUI messages
        GUIStartDialogOKCancel,         // Command: Start a DialogOKCancel if present
        GUIBackButtonPressed,           // Notification: Back button has just been pressed
        GUIRestartButtonPressed,        // Notification: Restart button has just been pressed
        GUIViewButtonPressed,           // Notification: View button has just been pressed
        GUIMagicButtonPressed,          // Notification: Magic button has just been pressed
        GUIFadeOutWhiteCurtain,         // Command: Fade the entire screen out to white
        GUIWhiteCurtainFaded,           // Notification: The entire screen has just faded to white
        GUIOKButtonPressed,             // Notification: OK button pressed in a DialogOKCancel
        GUICancelButtonPressed,         // Notification: Cancel button pressed in a DialogOKCancel
        GUIRotoChipsPressed,            // Notification: RotoChips indicator on the scene World has just been pressed (either by mouse or by finger)
        GUIRotoCoinsPressed,            // Notification: RotoCoins indicator on the scene World has just been pressed (either by mouse or by finger)
        GUIFullScreenButtonPressed,     // Notification: A sole fullscreen button in a scene has been pressed

        // World scene messages
        WorldStarted,                   // Notification: Method Start() of the scene World has just finished its execution
        WorldRotateToSelected,          // Command: rotate the world globe to the currently active level selector
        WorldSelectorPressed,           // Notification: Some cube-like selector above the world globe has just been pressed (either by mouse or by finger)
        WorldSatellitePressed,          // Notification: Satellite object above the world globe has just been pressed (either by mouse or by finger)
        WorldGlobePressed,              // Notification: world globe has just been pressed
        WorldRotationEnable,            // Command: Enable (argument = true) or disable (argument = false) the rotation of the world globe and the satellite
        WorldRotateToObject,            // Command: Rotate the world globe so that the particular object is set just before the player's view
        WorldRotatedToObject,           // Notification: The world globe has just rotated to the particular object
        WorldZoomCameraAtMin,           // Command: Move the camera above the world globe down (decrease distance)
        WorldZoomCameraAtMax,           // Command: Move the camera above the world globe up (increase distance)
        WorldAutoZoomCamera,            // Command: zoom the camera in or out
        WorldCameraZoomedAtMin,         // Notification: The camera above the world globe has just moved to the nearest position above the latter
        WorldCameraZoomedAtMax,         // Notification: The camera above the world globe has just moved to the farthest position above the latter

        // Puzzle scene messages
        PuzzleStarted,                  // Notification: Method Start() of the scene Puzzle has just finished its execution
        PuzzleButtonPressed,            // Notification: Some puzzle button has just been pressed (either by mouse or by finger)
        PuzzlePressButton,              // Command: Press a puzzle button
        PuzzleButtonRotated,            // Notification: A puzzle button and a quad of its neighbour square tiles have just rotated a quarter clockwise
        PuzzleRotoChipsPressed,         // Notification: RotoChips indicator on the scene Puzzle has just been pressed (either by mouse or by finger)
        PuzzleRotoCoinsPressed,         // Notification: RotoCoins indicator on the scene Puzzle has just been pressed (either by mouse or by finger)
        PuzzleFlashTile,                // Command: Flash the tiles which are in their places
        PuzzleTileFlashed,              // Notification: Tiles flashed
        PuzzleViewSourceImage,          // Command: Show a source image of the current puzzle
        PuzzleSourceImageClosed,        // Notification: The source image has been closed
        PuzzleReset,                    // Command: Reset the puzzle to the initial state
        PuzzleShuffle,                  // Command: shuffle the puzzle possibly using a precomputed string of rotations
        PuzzleHasShuffled,              // Notification: The puzzle has been shuffled after reset
        PuzzleBusy,                     // Command: Set or reset the puzzle busy status
        PuzzleComplete,                 // Notification: The puzzle is assembled
        PuzzlePrepareAutostep,          // Command: Flash two tiles behind the autostep choice dialog
        PuzzleAutostep,                 // Command: Use an autostep feature
        PuzzleAutostepUsed,             // Notification: An autostep feature is used
        PuzzleAutocomplete,             // Command: Automagically complete the current puzzle
        PuzzleAutocompleteUsed,         // Notification: The puzzle is automagically complete
        PuzzleShowWinimage,             // Command: Show a final image of the completed puzzle
        PuzzleWinImageFinished,         // Notification: Final image fully exhibited
        PuzzleWinImageStopped,          // Notification: The final image has stopped exhibition (a button has been pressed)
        PuzzleSetVictoryTitle,          // Command: Set the title of a fullscreen button at the Victory scene

        // General
        LanguageChanged,                // Notification: System language has changed
        SteadyMouseUpAsButton,          // Notification: A pointer (mouse/touch) has been pressed and released on an object without moving
        RotoChipsChanged,               // Notification: Per puzzle/total amount of RotoChips has changed
        RotoCoinsChanged                // Notification: Amout of RotoCoins has changed
    }

}
