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
                                        //      Arguments: None
        GUIBackButtonPressed,           // Notification: Back button has just been pressed
                                        //      Arguments: None
        GUIRestartButtonPressed,        // Notification: Restart button has just been pressed
                                        //      Arguments: None
        GUIViewButtonPressed,           // Notification: View button has just been pressed
                                        //      Arguments: None
        GUIMagicButtonPressed,          // Notification: Magic button has just been pressed
                                        //      Arguments: None
        GUIFadeOutWhiteCurtain,         // Command: Fade the entire screen out to white
                                        //      Arguments: None
        GUIWhiteCurtainFaded,           // Notification: The entire screen has just faded to white
                                        //      Arguments: None
        GUIOKButtonPressed,             // Notification: OK button pressed in a DialogOKCancel
                                        //      Arguments: None
        GUICancelButtonPressed,         // Notification: Cancel button pressed in a DialogOKCancel
                                        //      Arguments: None
        GUIRotoChipsPressed,            // Notification: RotoChips indicator on the scene World has just been pressed (either by mouse or by finger)
                                        //      Arguments: None
        GUIRotoCoinsPressed,            // Notification: RotoCoins indicator on the scene World has just been pressed (either by mouse or by finger)
                                        //      Arguments: None
        GUIFullScreenButtonPressed,     // Notification: A sole fullscreen button in a scene has been pressed
                                        //      Arguments: None

        // World scene messages
        WorldStarted,                   // Notification: Method Start() of the scene World has just finished its execution
        WorldRotateToSelected,          // Command: rotate the world globe to the currently active level selector
        WorldSelectorPressed,           // Notification: Some cube-like selector above the world globe has just been pressed (either by mouse or by finger)
        WorldSatellitePressed,          // Notification: Satellite object above the world globe has just been pressed (either by mouse or by finger)
        WorldGlobePressed,              // Notification: world globe has just been pressed
        WorldRotationEnable,            // Command: Enable or disable the rotation of the world globe and the satellite
                                        //      Arguments:
                                        //          bool on - rotation status: enable (true) or disable (false) rotation
        WorldRotateToObject,            // Command: Rotate the world globe so that the particular object is set just before the player's view
        WorldRotatedToObject,           // Notification: The world globe has just rotated to the particular object
        WorldZoomCameraAtMin,           // Command: Move the camera above the world globe down (decrease distance)
        WorldZoomCameraAtMax,           // Command: Move the camera above the world globe up (increase distance)
        WorldAutoZoomCamera,            // Command: zoom the camera in or out
        WorldCameraZoomedAtMin,         // Notification: The camera above the world globe has just moved to the nearest position above the latter
        WorldCameraZoomedAtMax,         // Notification: The camera above the world globe has just moved to the farthest position above the latter
        WorldShowLevelDescription,      // Command: Show a dialog with the description of a completed level
                                        //      Arguments:
                                        //          LevelDataManager.Descriptor descriptor - an descriptor of the level to show
        WorldLevelDescriptionClosed,    // Notification: A dialog with the level description has been closed
                                        //      Arguments: none

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

        // Finale
        VictoryStartFireworks,          // Command: Special command to reposition fireworks on the Finale scene adjusting them to selector objects
                                        //      Arguments:
                                        //          List<GameObject> selectors - a list of selectors on the Finale scene (if aaplicable)
        FinaleRollText,                 // Command: Roll the text chunk by its index
                                        //      Arguments:
                                        //          int textIndex - an index of a text chunk to roll
        FinaleTextRolled,               // Notification: A text chunk has rolled into the end position on the Finale scene
                                        //      Arguments:
                                        //          int textIndex - an index of a text chunk
        FinaleTextPostDelayed,          // Notification: Post delay expired after the text chunk movement
                                        //      Arguments:
                                        //          int textIndex - an index of a text chunk

        // General
        LanguageChanged,                // Notification: System language has changed
        SteadyMouseUpAsButton,          // Notification: A pointer (mouse/touch) has been pressed and released on an object without moving
        RotoChipsChanged,               // Notification: Per puzzle/total amount of RotoChips has changed
        RotoCoinsChanged                // Notification: Amout of RotoCoins has changed
    }

}
