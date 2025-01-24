using RMC.TravelGuide.PageUIs;
using UnityEngine;
using UnityEngine.UIElements;

namespace RMC.TravelGuide.Pages
{
    /// <summary>
    /// Main entry point for the Scene
    ///
    /// See view at <see cref="ListingPage"/>
    /// 
    /// </summary>
    public class ListingPage : Page
    {
        //  Properties ------------------------------------
        private ListingPageUI ListingPageUI { get { return _pageUI as ListingPageUI; } }

            
        //  Fields ----------------------------------------

        
        //  Unity Methods ---------------------------------
        protected override void Start()
        {
            base.Start();
            Debug.Log($"{GetType().Name}.Start()");
            
            Debug.LogWarning("1 Note that clicks are broken for " + ListingPageUI.NextPageButton);
            ListingPageUI.NextPageButton.RegisterCallback<ClickEvent>(NextPageButton_OnClickEvent);
        }

        protected override void Update()
        {
            base.Update();
            
            Debug.Log(ListingPageUI.NextPageButton);
            
        }
        
        
        protected override void OnDestroy()
        {
            Debug.LogWarning("2 Note that clicks are broken for " + " ListingPageUI.NextPageButton");
            ListingPageUI?.NextPageButton?.UnregisterCallback<ClickEvent>(NextPageButton_OnClickEvent);
            base.OnDestroy();
        }

        
        //  Methods ---------------------------------------

        
        //  Event Handlers --------------------------------
        private void NextPageButton_OnClickEvent(ClickEvent evt)
        {
            Debug.Log("NextPageButton_OnClickEvent");
            LoadNextScene();
        }
    }
}