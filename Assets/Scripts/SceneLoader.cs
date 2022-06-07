using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{
    public void LoadNewScene(string sceneTitle)
    {
        SceneManager.LoadScene(sceneTitle);
    }
}
