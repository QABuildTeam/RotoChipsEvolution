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
        First1000PointsScored,
        SecondPuzzleAssembled,
        Second1000PointsScored,
        ThirdPuzzleAssembled,
        Third1000PointsScored,
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
    }

    public class AchievementManager : GenericManager
    {
        protected AchievementManagerData data;
        protected Dictionary<AchievementType, string> achievementDictionary;
        public override void MakeInitial()
        {
            data = GetComponentInChildren<AchievementManagerData>();
            if (data != null)
            {
                achievementDictionary = new Dictionary<AchievementType, string>();
                foreach (Achievement achievement in data.achievements)
                {
                    achievementDictionary.Add(achievement.type, achievement.achievementId);
                }
            }
            //Social.localUser.Authenticate(ProcessAuthentication);
            base.MakeInitial();
        }

        [SerializeField]
        protected string leaderboardName = "RotoChipsScore";
        void ProcessAuthentication(bool success)
        {
            if (success)
            {
                Social.LoadAchievements(ProcessLoadedAchievements);
                Social.LoadScores(leaderboardName, ProcessScores);
            }
        }

        void ProcessLoadedAchievements(IAchievement[] achievements)
        {
            if (achievements.Length == 0)
            {
                Debug.Log("No achievements loaded");
            }
        }

        void ProcessScores(IScore[] scores)
        {
        }

        public void ReportNewScore(long score)
        {
            Social.ReportScore(score, leaderboardName, success =>
            {
                Debug.Log("Score " + score.ToString() + " has been " + (success ? "successfully" : "unsuccessfully") + " reported of");
            });
        }

        public void ReportNewAchievement(AchievementType achievement)
        {
            string achievementId;
            if (achievementDictionary.TryGetValue(achievement, out achievementId))
            {
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

    }
}
