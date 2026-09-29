using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void LoadMainMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
    public void LoadActivity1()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void LoadActivity2()
    {
        SceneManager.LoadSceneAsync(2);
    }

}
