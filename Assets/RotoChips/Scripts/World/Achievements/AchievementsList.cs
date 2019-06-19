using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RotoChips.Generic;
using RotoChips.Management;

namespace RotoChips.World.Achievements
{
    public class AchievementsList : GenericMessageHandler
    {

        [SerializeField]
        GameObject achievementsCanvas;
        [SerializeField]
        Text achievementsListText;

        protected override void AwakeInit()
        {
            //registrator.Add(new MessageRegistrationTuple { type = InstantMessageType.GUICupButtonPressed, handler = OnGUICupButtonPressed });
        }

        private void Start()
        {
            achievementsCanvas.SetActive(false);
        }
        /*
        private void OnGUICupButtonPressed(object sender, InstantMessageArgs args)
        {
            if (!achievementsCanvas.activeInHierarchy)
            {
                achievementsCanvas.SetActive(true);
                string resultText = string.Empty;
                GlobalManager.MAchievement.GetSocialData(
                    (socialText) =>
                    {
                        resultText += socialText + "\n";
                        GlobalManager.MAchievement.GetAchievementsText(
                            (achievementsText) =>
                            {
                                resultText += achievementsText + "\n";
                                GlobalManager.MAchievement.GetScoreText(
                                    (scoreText) =>
                                    {
                                        resultText += scoreText;
                                        GlobalManager.MAchievement.GetAchievementDescriptions(
                                            (descriptionText) =>
                                            {
                                                resultText += descriptionText;
                                                achievementsListText.text = resultText;
                                            }
                                        );
                                    }
                                );
                            }
                        );
                    }
                );
            }
        }
        */
        public void TurnOff()
        {
            achievementsCanvas.SetActive(false);
        }
    }
}
