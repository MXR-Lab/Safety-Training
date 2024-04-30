using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class SceneSwitch : MonoBehaviour
{
    //GameObject Scene
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void LoadElevated() {
        //sceneManager.UnloadSceneAsync(sceneManager.GetActiveScene());
        SceneManager.LoadScene("SampleSceneElevated", LoadSceneMode.Single);
    }
    public void LoadGround() {
       // sceneManager.UnloadSceneAsync(sceneManager.GetActiveScene());
        SceneManager.LoadScene("SampleSceneGround", LoadSceneMode.Single);
    }
}
