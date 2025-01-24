using RMC.TravelGuide.Pages;
using UnityEngine;
using UnityEngine.UIElements;

namespace RMC.TravelGuide.PageUIs
{
    /// <summary>
    /// This is the view for the <see cref="IntroPage"/>
    /// </summary>
    public class IntroPageUI : PageUI
    {
        //  Properties ------------------------------------
        public Button NextSectionButton { get { return UIDocument?.rootVisualElement?.Q<Button>("NextSectionButton"); }}
        public Button NextPageButton { get { return UIDocument?.rootVisualElement?.Q<Button>("NextPageButton"); }}
        public TabView TabView { get { return UIDocument?.rootVisualElement?.Q<TabView>("TabView"); }}
        
        //  Fields ----------------------------------------


        //  Unity Methods ---------------------------------
        protected override void Start()
        {
            base.Start();
            //Debug.Log($"{GetType().Name}.Start()");
        }
    
        
        //  Methods ---------------------------------------

        
        //  Event Handlers --------------------------------

    }
}