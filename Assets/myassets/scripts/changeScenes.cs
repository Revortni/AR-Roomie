using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class changeScenes : MonoBehaviour {

	public void changeScene(int sceneNumber)
	{	
		if(SceneManager.GetActiveScene().name == "homeScreen" && sceneNumber==0)
			Application.Quit();
		else
			SceneManager.LoadScene(sceneNumber);
	}
}
