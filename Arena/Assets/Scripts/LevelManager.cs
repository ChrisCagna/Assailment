using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public void Loadlevel(string name)
    {
        Debug.Log("Trying to load: " + name);
        Application.LoadLevel(name);
        //SceneManager.LoadScene(name);
    }

    public void QuitRequest()
    {
        Debug.Log("Trying to Quit");
    }


}
