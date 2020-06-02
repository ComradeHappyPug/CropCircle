using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string NextScene;
    public string OtherNextScene;

    public void OnClick(string StartButton)
    {
        SceneManager.LoadScene(NextScene, LoadSceneMode.Single);
    }
}
