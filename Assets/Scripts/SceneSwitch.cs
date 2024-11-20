using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class SceneSwitch : MonoBehaviour
{
    public void LoadElevated() {
        //sceneManager.UnloadSceneAsync(sceneManager.GetActiveScene());
        SceneManager.LoadScene("SampleSceneElevated", LoadSceneMode.Single);
    }
    public void LoadGround() {
       // sceneManager.UnloadSceneAsync(sceneManager.GetActiveScene());
        SceneManager.LoadScene("SampleSceneGround", LoadSceneMode.Single);
    }
    public void LoadGroundAfter()
    {
        // sceneManager.UnloadSceneAsync(sceneManager.GetActiveScene());
        SceneManager.LoadScene("SampleSceneGroundAfter", LoadSceneMode.Single);
    }
}
