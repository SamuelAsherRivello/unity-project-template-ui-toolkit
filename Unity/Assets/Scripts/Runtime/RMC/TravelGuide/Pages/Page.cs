using RMC.Audio;
using RMC.TravelGuide.PageUIs;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace RMC.TravelGuide.Pages
{
    /// <summary>
    /// Main entry point for the Scene
    /// </summary>
    public class Page : MonoBehaviour
    {
        //  Properties ------------------------------------

            
        //  Fields ----------------------------------------
        [Header("UI")]
        [SerializeField]
        protected PageUI _pageUI;

        //  Unity Methods ---------------------------------
        
        /// <summary>
        /// Runs once per Scene. Use for initialization
        /// </summary>
        protected virtual void Start()
        {
            //
        }

        
        protected virtual void Update()
        {
            // Click [2] to toggle the theme
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                ToggleTheme();
            }
            
            // Click [3] to reload scene
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                LoadCurrentScene();
            }
            
            // Click [4] to reload game
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                ReloadGame();
            }
        }
        
        
        protected virtual void OnDestroy()
        {
            //
        }
        
        
        //  Methods ---------------------------------------
        /// <summary>
        /// Reload the current Scene
        /// </summary>
        private void LoadCurrentScene()
        {
            int nextBuildIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(nextBuildIndex);
        }
        
        /// <summary>
        /// Toggle Theme
        /// </summary>
        public void ToggleTheme()
        {
            TravelGuideSingleton.Instance.ThemeManager.IsDark = !TravelGuideSingleton.Instance.ThemeManager.IsDark;
            //Debug.Log($"ThemeManager.IsDark = {TravelGuideSingleton.Instance.ThemeManager.IsDark}");
        }
        
        /// <summary>
        /// Reload the current Scene
        /// </summary>
        protected void LoadNextScene()
        {
            int nextBuildIndex = 0;
            if (SceneManager.GetActiveScene().buildIndex == nextBuildIndex)
            {
                nextBuildIndex++;
            }
            SceneManager.LoadScene(nextBuildIndex);
        }
        
        
        /// <summary>
        /// Load the first Scene as a #hack to restart the game
        /// </summary>
        private void ReloadGame()
        {
            int nextBuildIndex = 0;
            SceneManager.LoadScene(nextBuildIndex);
        }
        

        /// <summary>
        /// Play audio using the AudioManager imported via
        /// https://github.com/SamuelAsherRivello/rmc-core/
        /// </summary>
        /// <param name="audioClipName">Must match AudioClip name within
        /// Assets/Settings/Audio/AudioManagerConfiguration.asset</param>
        private void PlayAudioClip(string audioClipName)
        {
            AudioManager.Instance.PlayAudioClip(audioClipName);
        }

        
        //  Event Handlers --------------------------------
    }
}