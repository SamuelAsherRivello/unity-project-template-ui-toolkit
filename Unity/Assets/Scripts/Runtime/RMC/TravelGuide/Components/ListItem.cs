using UnityEngine;
using UnityEngine.UIElements;

namespace RMC.TravelGuide.Components
{
    /// <summary>
    /// UI Toolkit custom component
    /// </summary>
    [UxmlElement("ListItem")]
    public partial class ListItem : VisualElement
    {
        // Properties
        private VisualElement SomeChildOfInterest { get{ return this.Q<VisualElement>("SomeChildOfInterest");}}
        
        
        // Members
        private bool _isInitialized = false;

        
        // Layout file auto-includes styles
        private string LayoutPath { get { return $"{GetType().Name}Layout"; }}
        
        
        // Methods
        public ListItem()
        {
            //if (!Application.isPlaying)
            {
                //At EDIT-TIME: Initialize here via Constructor
                Initialize();
            }
        }
        
        
        private void Initialize()
        {
            if (_isInitialized)
            {
                return;
            }

            _isInitialized = true;
            
            // Properly activates the root "#ListItem" style
            name = GetType().Name;
            
            CreateLayout();
            
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
        }
        
        
        private void RefreshUI()
        {
            //
        }
    }
}