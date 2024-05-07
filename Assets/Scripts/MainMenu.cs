using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private int levelSelectionSceneIndex = 1;

    public void SwitchToLevelSelection() => SceneManager.LoadScene(levelSelectionSceneIndex);

    public void QuitGame() => Application.Quit();
}
