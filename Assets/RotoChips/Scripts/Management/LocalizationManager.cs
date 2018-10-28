/*
 * File:        LocalizationManager.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class LocalizationManager defines localization techniques for the in-game text based on the default system language
 * Created:     05.07.2018
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using RotoChips.Generic;

namespace RotoChips.Management
{

    public class LocalizationManager : GenericManager
    {
        [SerializeField]
        protected SystemLanguage currentLanguage;

        // --------------------------------------------------
        // localizatiion data format
        public class LocalizationEntry
        {
            public string id;
            public string language;
            public string value;
        }
        Dictionary<string, string> vocabulary;
        [SerializeField]
        protected string localizationFileTemplate = "localizationStrings-{0}.json";
        string LocalizationFileName(SystemLanguage language)
        {
            return Path.Combine(Application.streamingAssetsPath, string.Format(localizationFileTemplate, language.ToString()));
        }

        // --------------------------------------------------
        // some GenericManager stuff
        // MakeInitial starts here...
        public override void MakeInitial()
        {
            Initialized = Status.None;
            StartCoroutine(GetLocalizations());
        }

        IEnumerator GetLocalizations()
        {
            processFlag = false;
            StartCoroutine(InitAvailableLocalizations());
            while (!processFlag)
            {
                yield return null;
            }
            // ...and ends here, after getting the list of available localizations
            base.MakeInitial();
        }

        // these are overloaded load/save methods
        const string signature = ".LocalizationManager.";
        [System.Serializable]
        protected class LanguageWrapper
        {
            public SystemLanguage language;
        }
        public override bool CheckSignature(string initLine)
        {
            return initLine == signature;
        }
        public override void Load(object prototype)
        {
            currentLanguage = ConformSystemLanguage(((LanguageWrapper)prototype).language);
        }
        public override string SaveSignature()
        {
            return signature;
        }
        public override object Save()
        {
            return new LanguageWrapper
            {
                language = currentLanguage
            };
        }

        // MakeReady starts here...
        public override void MakeReady()
        {
            StartCoroutine(LoadLocalizations());
        }

        IEnumerator LoadLocalizations()
        {
            processFlag = false;
            StartCoroutine(InitLocalizationData(currentLanguage));
            while (!processFlag)
            {
                yield return null;
            }
            // ...and ends here, after loading localization data for the currently selected language
            base.MakeReady();
        }

        // --------------------------------------------------
        // now for actual data processing
        bool processFlag;
        List<SystemLanguage> availableLocalizations;
        IEnumerator InitAvailableLocalizations()
        {
            if (availableLocalizations == null)
            {
                availableLocalizations = new List<SystemLanguage>();
                foreach (SystemLanguage language in Enum.GetValues(typeof(SystemLanguage)))
                {
                    string localizationFileName = LocalizationFileName(language);
                    //Debug.Log("LocalizationManager.InitAvailableLocalizations(): checking " + language.ToString());
                    StartCoroutine(CheckStreamableAsset(localizationFileName, (assetName, exists) => { if (exists) { availableLocalizations.Add(language); } }));
                    while (!IsLoaded)
                    {
                        yield return null;
                    }
                }
                processFlag = true;
            }
        }

        public SystemLanguage[] AvailableLocalizations
        {
            get
            {
                if (Initialized == Status.Ready)
                {
                    return availableLocalizations.ToArray();
                }
                return null;
            }
        }

        // users may insert "\n" into their localization data one-liners
        // this method converts such character escapes into real newline characters
        string NormalizeString(string s)
        {
            return s.Replace("\\n", "\n");
        }

        SystemLanguage ConformSystemLanguage(SystemLanguage newLanguage)
        {
            if (newLanguage == SystemLanguage.Unknown)
            {
                newLanguage = Application.systemLanguage;
                if (!availableLocalizations.Contains(newLanguage))
                {
                    newLanguage = SystemLanguage.English;   // English localization is required to exist
                }
            }
            return newLanguage;
        }

        IEnumerator InitLocalizationData(SystemLanguage newLanguage = SystemLanguage.Unknown, bool notify = false)
        {
            // clear the vocabulary
            vocabulary = new Dictionary<string, string>();
            currentLanguage = ConformSystemLanguage(newLanguage);
            string languageName = currentLanguage.ToString();
            //Debug.Log("Application language is " + languageName);
            if (availableLocalizations.Contains(currentLanguage))
            {
                int entriesRead = 0;
                string localizationFileName = LocalizationFileName(currentLanguage);
                StartCoroutine(LoadStreamableAsset(localizationFileName, (stream, exists) =>
                {
                    if (!exists)
                    {
                        //Debug.Log("No localization files for " + languageName + " found");
                    }
                    else
                    {
                        stream.BaseStream.Seek(0, SeekOrigin.Begin);
                        while (!stream.EndOfStream)
                        {
                            string srcline = stream.ReadLine();
                            if (srcline != null)
                            {
                                // explicit JSON parsing
                                LocalizationEntry entry = JsonUtility.FromJson<LocalizationEntry>(srcline);
                                if (entry.language == languageName)
                                {
                                    if (!vocabulary.ContainsKey(entry.id))
                                    {
                                        vocabulary.Add(entry.id, NormalizeString(entry.value));
                                        entriesRead++;
                                    }
                                    else
                                    {
                                        //Debug.Log("Entry " + entry.id + " is already in vocabulary!");
                                    }
                                }
                            }
                        }
                    }
                }));
                while (!IsLoaded)
                {
                    yield return null;
                }
                //Debug.Log(entriesRead.ToString() + " entries read for " + languageName + " language");
                if (notify)
                {
                    GlobalManager.MInstantMessage.DeliverMessage(InstantMessageType.LanguageChanged, this, currentLanguage);
                }
            }
            else
            {
                //Debug.Log("No localization files for " + languageName + " found");
            }
            processFlag = true;
        }

        // this method performs the real localization for a string id
        // it only should be called after the LocalizationManager itself has been initialized!!!
        public string Entry(string id)
        {
            string value;
            if (vocabulary.TryGetValue(id, out value))
            {
                return value;
            }
            //Debug.Log("No localization entry for id \"" + id + "\" found");
            return id;
        }

        // this method performs a system language switch
        // it only should be called after the LocalizationManager itself has been initialized!!!
        public void ChangeLanguageTo(SystemLanguage newLanguage)
        {
            if (Initialized == Status.Ready && newLanguage != SystemLanguage.Unknown && newLanguage != currentLanguage)
            {
                StartCoroutine(InitLocalizationData(newLanguage, true));
            }
        }

    }
}
