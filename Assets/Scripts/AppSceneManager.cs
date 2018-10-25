using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AppSceneManager : MonoBehaviour {

    void Awake()
    {
        DontDestroyOnLoad(this);
    }

	public void LoadManual(){
		SceneManager.LoadScene("OTPScene");
	}

	public void LoadAuto(){
		SceneManager.LoadScene("OTPAutoScene");
	}


	void Update(){
            if (Application.platform == RuntimePlatform.Android)
            {
                if(Input.GetKeyUp(KeyCode.Escape)){
                    SceneManager.LoadScene("MainMenu");
                }
            }
        }

}
