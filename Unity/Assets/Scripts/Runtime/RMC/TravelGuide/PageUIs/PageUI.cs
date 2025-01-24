using RMC.TravelGuide.Pages;
using UnityEngine;
using UnityEngine.UIElements;

namespace RMC.TravelGuide.PageUIs
{
    /// <summary>
    /// Renders the UI for the <see cref="Page"/>
    /// </summary>
    public class PageUI : MonoBehaviour
    {
        //  Properties ------------------------------------
        protected UIDocument UIDocument { get { return _uiDocument; }}
        
        //  Fields ----------------------------------------
        [Header("Layout")]
        [SerializeField]
        private UIDocument _uiDocument;

        //  Unity Methods ---------------------------------
        protected virtual void Start()
        {
            
        }
        
        
        protected virtual void OnDestroy()
        {
            //
        }

        
        //  Methods ---------------------------------------

        
        //  Event Handlers --------------------------------
    }
}