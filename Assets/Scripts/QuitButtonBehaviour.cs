using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitButtonBehaviour: MonoBehaviour
{
    public void OnClickQuitGame()
    {
        Application.Quit();
    }

    public void OnClickLoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
