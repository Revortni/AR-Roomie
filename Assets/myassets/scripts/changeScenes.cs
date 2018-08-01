using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class changeScenes : MonoBehaviour {
	private int scene;
	public void changeScene(int sceneNumber)
	{	
		scene = sceneNumber;
		if(SceneManager.GetActiveScene().name == "home" && sceneNumber==0)
			Application.Quit();
		else
			SceneManager.LoadScene(sceneNumber);
	}

	void Update(){
		if (Input.GetKeyDown(KeyCode.Escape)){
			SceneManager.LoadScene(scene);
		}

		if(Input.GetKeyDown(KeyCode.Escape) && scene==0){
			Application.Quit();
		}
	}
}
