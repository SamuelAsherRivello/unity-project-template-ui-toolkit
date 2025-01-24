using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UIElements;

#pragma warning disable CS4014 // Because this call is not awaited...
namespace RMC.TravelGuide.Components
{
    /// <summary>
    /// UI Toolkit custom component
    /// </summary>
    [UxmlElement("ThemeButton")]
    public partial class ThemeButton : VisualElement
    {
        // Properties
        private Button Button { get{ return this.Q<Button>("Button");}}
        
        
        // Members
        private bool _isInitialized = false;
        private ThemeManager _themeManager;

        
        // Layout file auto-includes styles
        private string LayoutPath { get { return $"{GetType().Name}Layout"; }}
        
        
        // Methods
        public ThemeButton()
        {
            InitializeAsync();
        }
        
        
        private async Task InitializeAsync()
        {
            if (_isInitialized)
            {
                return;
            }

            _isInitialized = true;
            
            // Properly activates the root "#ThemeButton" style
            name = GetType().Name;
            
            CreateLayout();
            
            if (Application.isPlaying)
            {
                // These specific dependencies are runtime only
                await SetupDependenciesAsync();
            }
            
            RefreshUI();
        }
        
        
        private void CreateLayout()
        {
            var loadedLayout = Resources.Load<VisualTreeAsset>(LayoutPath);
            if (loadedLayout == null)
            {
                Debug.LogError($"{GetType().Name}.Initialize() failed. LayoutPath '{LayoutPath}' not found in any Resources folder.");
                return;
            }
            loadedLayout.CloneTree(this);
            
            Button.RegisterCallback<ClickEvent>(OnClickEvent);
        }

        /// <summary>
        ///  NOTE: Regarding dependencies and bounds of scope...
        ///     1. This is a "Smart Component" where it "knows about" external context and "manages" its own dependencies
        ///     2. An alternative "Smart Component" could have the page pass in this reference ( e.g. "_themeButton.SetThemeManager(_themeManager);" )
        ///     3. An alternative "Standard Component" could have the page do more and the ThemeButton do less, etc...
        /// </summary>
        private async Task SetupDependenciesAsync()
        {
            //Hack: Wait a frame due to the purposefully limited Singleton implementation
            await Awaitable.NextFrameAsync();
            
            _themeManager = TravelGuideSingleton.Instance.ThemeManager;
        }
        
        
        private void RefreshUI()
        {
            //
        }

        
        private void OnClickEvent(ClickEvent evt)
        {
            _themeManager.IsDark = !_themeManager.IsDark;
            RefreshUI();
        }
    }
}