/*
 * File:        AchievementManager.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class AchievementManager manages in-game achievements of a player
 * Created:     16.10.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if PLATFORM_ANDROID
using GooglePlayGames;
using GooglePlayGames.BasicApi;
#endif
using UnityEngine.SocialPlatforms;
using RotoChips.Generic;
using System;
using RotoChips.Data;

namespace RotoChips.Management
{

    public enum AchievementType
    {
        None,
        FirstPuzzleAssembled,
        SecondPuzzleAssembled,
        ThirdPuzzleAssembled,
        Realm1Assembled,
        Realm2Assembled,
        Realm3Assembled,
        Realm4Assembled,
        Realm5Assembled,
        Realm6Assembled,
        Realm7Assembled,
        FirstRunFinished
    }

    [Serializable]
    public class Achievement
    {
        public AchievementType type;
        [SerializeField]
        public PlatformString platformAchievementId;
        public float points;
    }

    public class AchievementManager : GenericManager
    {
        protected AchievementManagerData data;
        protected Dictionary<AchievementType, Achievement> achievementDictionary;
        public override void MakeInitial()
        {
            achievementDictionary = new Dictionary<AchievementType, Achievement>();
            data = GetComponentInChildren<AchievementManagerData>();
            if (data != null)
            {
                foreach (Achievement achievement in data.achievements)
                {
                    achievementDictionary.Add(achievement.type, achievement);
                }
            }
#if PLATFORM_ANDROID
            PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();
            PlayGamesPlatform.InitializeInstance(config);
            PlayGamesPlatform.DebugLogEnabled = true;
            PlayGamesPlatform.Activate();
#endif
            Social.localUser.Authenticate(ProcessAuthentication);
            base.MakeInitial();
        }

        protected string LeaderboardName
        {
            get
            {
                if (data != null)
                {
                    return data.platformLeaderboardName.Value(Application.platform);
                }
                return null;
            }
        }

        protected ILeaderboard leaderboard;

        void ProcessAuthentication(bool success)
        {
            if (success)
            {
                Social.LoadAchievements(ProcessLoadedAchievements);
                //Debug.Log("Creating leaderboard " + LeaderboardName);
                leaderboard = Social.CreateLeaderboard();
                leaderboard.id = LeaderboardName;
                //Debug.Log("Loading scores for leaderboard " + LeaderboardName);
                leaderboard.LoadScores(result => ProcessScores(result, leaderboard));
            }
        }

        string achievementsText;
        void ProcessLoadedAchievements(IAchievement[] achievements)
        {
            achievementsText = string.Empty;
            if (achievements.Length == 0)
            {
                Debug.Log("No achievements loaded");
                achievementsText = "No achievements loaded";
            }
            else
            {
                foreach (IAchievement achievement in achievements)
                {
                    achievementsText += achievement.id + " is " + (achievement.hidden ? "hidden" : "revealed") + " and " + (achievement.completed ? "" : "not ") + "completed" + "\n";
                }
            }
        }

        string scoreText;
        void ProcessScores(bool result, ILeaderboard leaderboard)
        {
            scoreText = string.Empty;
            if (result)
            {
                Debug.Log("Scores in " + leaderboard.id + " successfully loaded");
                scoreText = "Leaderboard " + leaderboard.id + "\n";
                foreach (IScore score in leaderboard.scores)
                {
                    scoreText += score.userID + " " + score.value.ToString() + "\n";
                    Debug.Log(score);
                }
            }
            else
            {
                scoreText = "No scores loaded";
                Debug.Log("No scores loaded");
            }
        }

        public void ReportNewScore(long score)
        {
            if (leaderboard != null)
            {
                Social.ReportScore(score, leaderboard.id, (success) =>
                {
                    Debug.Log("Score " + score.ToString() + " has been " + (success ? "successfully" : "unsuccessfully") + " reported of");
                });
            }
        }

        public void ReportNewAchievement(AchievementType achievementType)
        {
            Achievement achievement;
            if (achievementDictionary.TryGetValue(achievementType, out achievement))
            {
                string achievementId = achievement.platformAchievementId.Value(Application.platform);
                Social.ReportProgress(achievementId, 100, success =>
                {
                    Debug.Log("Achievement " + achievementId + " has been " + (success ? "successfully" : "unsuccessfully") + " reported of");
                });
            }
        }

        public void ShowAchievements()
        {
            Social.ShowAchievementsUI();
        }

        public void ShowScores()
        {
            Social.ShowLeaderboardUI();
        }

        // Testing
        /*
        public void GetSocialData(Action<string> callback)
        {
            string socialData = Social.Active.ToString() + "\nUser " + Social.localUser.id + " is " + (Social.localUser.authenticated ? "" : "not ") + "authenticated";
            callback(socialData);
        }

        public void GetAchievementDescriptions(Action<string> callback)
        {
            Social.LoadAchievementDescriptions(descriptions =>
            {
                if (descriptions.Length > 0)
                {
                    Debug.Log("Got " + descriptions.Length + " achievement descriptions");
                    string achievementDescriptions = "Achievement Descriptions:\n";
                    foreach (IAchievementDescription ad in descriptions)
                    {
                        achievementDescriptions += "\t'" +
                            ad.id + "' '" +
                            ad.title + "' '" +
                            ad.unachievedDescription + "'\n";
                    }
                    Debug.Log(achievementDescriptions);
                    callback(achievementDescriptions);
                }
                else
                {
                    string achievementDescriptions = "Achievement Descriptions:\nNone";
                    Debug.Log("Failed to load achievement descriptions");
                    callback(achievementDescriptions);
                }
            });
        }

        public void GetAchievementsText(Action<string> callback)
        {
            Social.LoadAchievements(
                (achievements) =>
                {
                    ProcessLoadedAchievements(achievements);
                    if (callback != null)
                    {
                        callback(achievementsText);
                    }
                }
            );
        }

        public void GetScoreText(Action<string> callback)
        {
            if (leaderboard != null)
            {
                leaderboard.LoadScores(
                    (result) =>
                    {
                        ProcessScores(result, leaderboard);
                        if (callback != null)
                        {
                            callback(scoreText);
                        }
                    }
                );
            }
        }
        */
    }
}
