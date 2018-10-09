/*
 * File:        LocalizedText.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class LocalizedText implements a component which updates a Text component's text with its localized value
 *              It also updates the text upon the GameEventManager.GameEventType.LanguageChanged event
 * Created:     29.06.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RotoChips.Management;
using RotoChips.Generic;

namespace RotoChips.UI
{
    public class LocalizedText : GenericMessageHandler
    {

        // a referenced Text component is calculated automatically
        protected Text textControl;
        // this is an id string of the text to be localized
        [SerializeField]
        protected string textId;
        // changing textId will also change its localized value
        public string TextId
        {
            get
            {
                return textId;
            }
            set
            {
                textId = value;
                Value = argValue;
            }
        }
        // a type of the event handled by the control
        const InstantMessageType languageChangedEvent = InstantMessageType.LanguageChanged;

        // optional parameter for the localized string
        // if the localized value contains "{0}" then argValue will be iserted in its place
        [SerializeField]
        protected string argValue;
        // a public property which helps setting the localized text
        public virtual string Value
        {
            get
            {
                return argValue;
            }
            set
            {
                argValue = value;
                if (textControl != null)
                {
                    textControl.text = string.Format(GlobalManager.MLanguage.Entry(textId), value);
                }
            }
        }

        // an event handler. It just redraws the text in the new system language
        void OnLanguageChange(object sender, InstantMessageArgs args)
        {
            Value = argValue;
        }

        protected override void AwakeInit()
        {
            Init();
            registrator.Add(new MessageRegistrationTuple { type = InstantMessageType.LanguageChanged, handler = OnLanguageChange });
        }

        void Init()
        {
            if (textControl == null)
            {
                textControl = GetComponent<Text>();
                Value = argValue;  // default text value
            }
        }

        private void Start()
        {
            Init();
        }

        private void OnEnable()
        {
            Init();
        }

    }
}
