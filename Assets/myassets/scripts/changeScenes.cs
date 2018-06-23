using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class changeScenes : MonoBehaviour {
	public int sceneNumber;
	void Start()
	{
		this.GetComponent<Button>().onClick.AddListener(delegate{changeScene();});
	}

	public void changeScene()
	{	
		if(SceneManager.GetActiveScene().name == "homeScreen" && sceneNumber==0)
			Application.Quit();
		else
			SceneManager.LoadScene(sceneNumber);
	}
}
