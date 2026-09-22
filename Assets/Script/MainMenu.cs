using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadActivity()
    {
        SceneManager.LoadSceneAsync(1);
    }

}
