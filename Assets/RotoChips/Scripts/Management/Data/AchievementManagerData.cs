/*
 * File:        AchievementManager.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class AchievementManager manages in-game achievements of a player
 * Created:     16.10.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotoChips.Management;
using RotoChips.Generic;

namespace RotoChips.Data
{
    public class AchievementManagerData : MonoBehaviour
    {
        [SerializeField]
        public PlatformString platformLeaderboardName;  // "RotoChipsScore"
        [SerializeField]
        public List<Achievement> achievements;
    }
}
