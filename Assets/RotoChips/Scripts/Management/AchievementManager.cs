/*
 * File:        AchievementManager.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class AchievementManager manages in-game achievements of a player
 * Created:     16.10.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
        public string achievementId;
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
            Social.localUser.Authenticate(ProcessAuthentication);
            base.MakeInitial();
        }

        protected string LeaderboardName
        {
            get
            {
                if (data != null)
                {
                    return data.leaderboardName;
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

        void ProcessLoadedAchievements(IAchievement[] achievements)
        {
            if (achievements.Length == 0)
            {
                //Debug.Log("No achievements loaded");
            }
        }

        void ProcessScores(bool result, ILeaderboard leaderboard)
        {
            if (result)
            {
                //Debug.Log("Scores in " + leaderboard.id + " successfully loaded");
                foreach (IScore score in leaderboard.scores)
                {
                    Debug.Log(score);
                }
            }
            else
            {
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
                Social.ReportProgress(achievement.achievementId, 100, success =>
                {
                    Debug.Log("Achievement " + achievement + " has been " + (success ? "successfully" : "unsuccessfully") + " reported of");
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

    }
}
