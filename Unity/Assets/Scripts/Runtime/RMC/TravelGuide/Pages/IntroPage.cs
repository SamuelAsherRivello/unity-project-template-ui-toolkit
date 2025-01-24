using RMC.TravelGuide.PageUIs;
using UnityEngine;
using UnityEngine.UIElements;

namespace RMC.TravelGuide.Pages
{
    /// <summary>
    /// Main entry point for the Scene
    ///
    /// See view at <see cref="IntroPageUI"/>
    /// 
    /// </summary>
    public class IntroPage : Page
    {
        //  Properties ------------------------------------
        private IntroPageUI IntroPageUI { get { return _pageUI as IntroPageUI; } }

            
        //  Fields ----------------------------------------

        
        //  Unity Methods ---------------------------------
        protected override void Start()
        {
            base.Start();
            Debug.Log($"{GetType().Name}.Start()");
            
            IntroPageUI.NextPageButton.RegisterCallback<ClickEvent>(NextPageButton_OnClickEvent);
            IntroPageUI.NextSectionButton.RegisterCallback<ClickEvent>(NextSectionButton_OnClickEvent);
        }
        
        
        protected override void OnDestroy()
        {
            IntroPageUI?.NextPageButton?.UnregisterCallback<ClickEvent>(NextPageButton_OnClickEvent);
            IntroPageUI?.NextSectionButton?.UnregisterCallback<ClickEvent>(NextSectionButton_OnClickEvent);
            base.OnDestroy();
        }

        
        //  Methods ---------------------------------------

        
        //  Event Handlers --------------------------------
        private void NextSectionButton_OnClickEvent(ClickEvent evt)
        {
            int nextSelectedTabIndex = IntroPageUI.TabView.selectedTabIndex + 1;
            if (nextSelectedTabIndex >= IntroPageUI.TabView.childCount)
            {
                nextSelectedTabIndex = 0;
            }

            IntroPageUI.TabView.selectedTabIndex = nextSelectedTabIndex;
        }
        
        private void NextPageButton_OnClickEvent(ClickEvent evt)
        {
            LoadNextScene();
        }
    }
}