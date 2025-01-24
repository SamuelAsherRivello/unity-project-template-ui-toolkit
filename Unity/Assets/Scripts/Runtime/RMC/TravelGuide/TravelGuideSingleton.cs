
using RMC.TravelGuide.Components;
using UnityEngine;
using UnityEngine.UIElements;

namespace RMC.TravelGuide
{
    /// <summary>
    /// For the <see cref="ThemeButton"/>, I would like to
    /// discuss some type of "Smart Component" with "Injection" (loose term)
    /// so for that I'm creating a singleton to simulate some external
    /// scope of interest.
    ///
    /// This is not necessarily an advocacy for the general use of
    /// the Singleton pattern. THis is a purposefully light implementation
    /// of Singleton.
    /// </summary>
    public class TravelGuideSingleton : MonoBehaviour
    {
        //  Singleton ------------------------------------
        public static TravelGuideSingleton Instance { get { return _instance; } }
        private static TravelGuideSingleton _instance;

        //  Properties ------------------------------------
        public ThemeManager ThemeManager { get { return _themeManager; } }

        //  Fields ----------------------------------------
        [Header("Styles")] 
        [SerializeField] 
        private StyleSheet _lightStyleSheet;

        [SerializeField] 
        private StyleSheet _darkStyleSheet;
        private ThemeManager _themeManager;

        
        //  Unity Methods ---------------------------------
        protected void Start()
        {
            _instance = this;
            _themeManager = new ThemeManager(_lightStyleSheet, _darkStyleSheet);
        }

        
        protected void OnDestroy()
        {
            //
        }


        //  Methods ---------------------------------------


        //  Event Handlers --------------------------------
    }
}
