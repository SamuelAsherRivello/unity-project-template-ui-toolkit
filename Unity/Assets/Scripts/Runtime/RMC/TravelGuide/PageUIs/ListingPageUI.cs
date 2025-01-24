using RMC.TravelGuide.Pages;
using UnityEngine;
using UnityEngine.UIElements;

namespace RMC.TravelGuide.PageUIs
{
    /// <summary>
    /// This is the view for the <see cref="ListingPage"/>
    /// </summary>
    public class ListingPageUI : PageUI
    {
        //  Properties ------------------------------------
        public Button NextPageButton { get { return UIDocument?.rootVisualElement?.Q<Button>("NextPageButton"); }}
        
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