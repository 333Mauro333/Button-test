using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNames : MonoBehaviour
{
    [SerializeField] List<string> sceneNamesList;

    void Start()
    {
        for (int i = 0; i < SceneManager.GetAllScenes().Length; i++)
        {
            sceneNamesList.Add(SceneManager.GetAllScenes()[i].name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
