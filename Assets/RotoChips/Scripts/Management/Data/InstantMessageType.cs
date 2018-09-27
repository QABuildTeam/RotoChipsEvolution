﻿/*
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
                                        //      Arguments:
                                        //          string messageId - a localization key of the dialog message
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
        GUIWhiteCurtainFaded,           // Notification: The entire screen has just faded
                                        //      Arguments:
                                        //          bool up - the white screen has faded transparent (false) or opaque (true)
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
        GUIConfigureAppearance,         // Command: Configure visibility and interactiveness of the GUIDialog elements
                                        //      Arguments:
                                        //          RotoChips.UI.GUIConfiguration configuration - a structure of configuration flags
        GUIShowHint,                    // Command: Show a hint message with or without a hint arrow
                                        //      Arguments:
        GUIHintClosed,                  // Notification: A hint message (with or without a hint arrow) has been closed
                                        //      Arguments:

        // World scene messages
        WorldStarted,                   // Notification: Method Start() of the scene World has just finished its execution
                                        //      Arguments: None
        WorldRotateToSelected,          // Command: rotate the world globe to the currently active level selector
                                        //      Arguments: None
        WorldSelectorPressed,           // Notification: Some cube-like selector above the world globe has just been pressed (either by mouse or by finger)
                                        //      Arguments:
                                        //          RotoChips.Management.LevelDataManager.Descriptor descriptor - a descriptor of the selected level
        WorldSatellitePressed,          // Notification: Satellite object above the world globe has just been pressed (either by mouse or by finger)
                                        //      Arguments: None
        WorldGlobePressed,              // Notification: world globe has just been pressed
                                        //      Arguments: None
        WorldRotationEnable,            // Command: Enable or disable the rotation of the world globe and the satellite
                                        //      Arguments:
                                        //          bool on - rotation status: enable (true) or disable (false) rotation
        WorldRotateToObject,            // Command: Rotate the world globe so that the particular object is set just before the player's view
                                        //      Arguments:
                                        //          GameObject target - a target object to rotate the world to
        WorldRotatedToObject,           // Notification: The world globe has just rotated to the particular object
                                        //      Arguments:
                                        //          GameObject target - a target object the world has rotated to
        WorldZoomCameraAtMin,           // Command: Move the camera above the world globe down (decrease distance)
                                        //      Arguments: None
        WorldZoomCameraAtMax,           // Command: Move the camera above the world globe up (increase distance)
                                        //      Arguments: None
        WorldAutoZoomCamera,            // Command: zoom the camera in or out
                                        //      Arguments: None
        WorldCameraZoomedAtMin,         // Notification: The camera above the world globe has just moved to the nearest position above the latter
                                        //      Arguments: None
        WorldCameraZoomedAtMax,         // Notification: The camera above the world globe has just moved to the farthest position above the latter
                                        //      Arguments: None
        WorldShowLevelDescription,      // Command: Show a dialog with the description of a completed level
                                        //      Arguments:
                                        //          RotoChips.Management.LevelDataManager.Descriptor descriptor - an descriptor of the level to show
        WorldLevelDescriptionClosed,    // Notification: A dialog with the level description has been closed
                                        //      Arguments: none

        // Puzzle scene messages
        PuzzleStarted,                  // Notification: Method Start() of the scene Puzzle has just finished its execution
                                        //      Arguments: None
        PuzzleButtonPressed,            // Notification: Some puzzle button has just been pressed (either by mouse or by finger)
                                        //      Arguments:
                                        //          Vector2Int buttonId - a 2d id of a pressed button (x,y)
        PuzzlePressButton,              // Command: Press a puzzle button
                                        //      Arguments:
                                        //          RotoChips.Puzzle.PuzzleButtonArgs - parameters of a button to press
        PuzzleButtonRotated,            // Notification: A puzzle button and a quad of its neighbour square tiles have just rotated a quarter clockwise
                                        //      Arguments:
                                        //          Vector2Int buttonId - a 2d id of a rotated button (x,y)
        PuzzleRotoChipsPressed,         // Notification: RotoChips indicator on the scene Puzzle has just been pressed (either by mouse or by finger)
                                        //      Arguments: None
        PuzzleRotoCoinsPressed,         // Notification: RotoCoins indicator on the scene Puzzle has just been pressed (either by mouse or by finger)
                                        //      Arguments: None
        PuzzleFlashTile,                // Command: Flash the tiles which are in their places
                                        //      Arguments:
                                        //          List<RotoChips.Puzzle.TileFlashArgs> flashArgsList - a list of tiles ids (and flashing colors) to flash
        PuzzleTileFlashed,              // Notification: Tiles flashed
                                        //      Arguments: None
        PuzzleViewSourceImage,          // Command: Show a source image of the current puzzle
                                        //      Arguments: None
        PuzzleSourceImageClosed,        // Notification: The source image has been closed
                                        //      Arguments: None
        PuzzleReset,                    // Command: Reset the puzzle to the initial state
                                        //      Arguments: None
        PuzzleShuffle,                  // Command: shuffle the puzzle possibly using a precomputed string of rotations
                                        //      Arguments: None (?)
        PuzzleHasShuffled,              // Notification: The puzzle has been shuffled after reset
                                        //      Arguments: None
        PuzzleBusy,                     // Command: Set or reset the puzzle busy status
                                        //      Arguments:
                                        //          bool busy - a busy flag: the puzzle does (false) or does not (true) respond the player's input
        PuzzleComplete,                 // Notification: The puzzle is assembled
                                        //      Arguments:
                                        //          RotoChips.Puzzle.PuzzleCompleteStatus completeStatus - a status of completeness
        PuzzlePrepareAutostep,          // Command: Flash two tiles behind the autostep choice dialog
                                        //      Arguments: None
        PuzzleAutostep,                 // Command: Use an autostep feature
                                        //      Arguments: None
        PuzzleAutostepUsed,             // Notification: An autostep feature is used
                                        //      Arguments: None
        PuzzleAutocomplete,             // Command: Automagically complete the current puzzle
                                        //      Arguments: None
        PuzzleAutocompleteUsed,         // Notification: The puzzle is automagically complete
                                        //      Arguments: None
        PuzzleShowWinimage,             // Command: Show a final image of the completed puzzle
                                        //      Arguments:
                                        //          string messageTextId - a localization identifier of a message
        PuzzleWinImageFinished,         // Notification: Final image fully exhibited
                                        //      Arguments: None
        PuzzleWinImageStopped,          // Notification: The final image has stopped exhibition (a button has been pressed)
                                        //      Arguments: None
        PuzzleSetVictoryTitle,          // Command: Set the title of a fullscreen button at the Victory scene
                                        //      Arguments:
                                        //          string messageTextId - a localization identifier of a title

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
                                        //      Arguments: None
        SteadyMouseUpAsButton,          // Notification: A pointer (mouse/touch) has been pressed and released on an object without moving
                                        //      Arguments:
                                        //          GameObject originator - a GameObjects which issued the message
        RotoChipsChanged,               // Notification: Per puzzle/total amount of RotoChips has changed
                                        //      Arguments: None
        RotoCoinsChanged,               // Notification: Amount of RotoCoins has changed
                                        //      Arguments: None
        PlayMusicTrack,                 // Command: MusicPlayer must stop playing background playlist and play a specified track
                                        //      Arguments:
                                        //          RotoChips.Management.AudioTrackEnum trackId - an id of a track to play
        MusicTrackPlayed,               // Notification: Specified music track has been played
                                        //      Arguments:
                                        //          RotoChips.Management.AudioTrackEnum trackId - and id of a played track
        BackgroundMusic,                // Command: Set or reset background music playing
                                        //      Arguments:
                                        //          bool on - a flag which starts (true) or stops (false) background music playing

        // Special
        RedirectFirstTimeWelcome2,      // Command: Active level selector on the world globe should create a hint request for FirstTimeWelcome2
                                        //      Arguments: None
        RedirectGalleryOpened,          // Command: The satellite above the world globe should create a hint request for GalleryOpened
                                        //      Arguments: None
        RedirectFirstTileButtons        // Command: The puzzle button (0,0) should create a hint request for FirstTileButtonsHint
                                        //      Arguments: None
    }

}