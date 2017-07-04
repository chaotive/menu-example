using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoScene : MonoBehaviour {
    public string sceneName = "anScene";
    
    public void goScene() {
        SceneManager.LoadScene(sceneName);
    }
}
