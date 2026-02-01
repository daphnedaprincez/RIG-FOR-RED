using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    /// <summary>
    /// Starts the game by loading the first game level
    /// </summary>
    public void StartGame()
    {
        // TODO: Replace "GameLevel" with your actual game scene name
        SceneManager.LoadScene("GameLevel");
    }

    /// <summary>
    /// Shows the instruction screen
    /// </summary>
    public void ShowInstructions()
    {
        // TODO: Replace "Instructions" with your actual instructions scene name
        SceneManager.LoadScene("Instructions");
    }

    /// <summary>
    /// Exits the application
    /// </summary>
    public void ExitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
