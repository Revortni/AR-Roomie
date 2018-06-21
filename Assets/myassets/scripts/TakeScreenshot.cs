using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakeScreenshot : MonoBehaviour {

	[SerializeField]
	public GameObject info;

	void Start(){
		info.SetActive(false);
	}
	public void TakeAShot()
	{
		StartCoroutine ("CaptureIt");
	}

	IEnumerator CaptureIt()
	{

		string timeStamp = System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
		string fileName = "Screenshot" + timeStamp + ".png";
		string pathToSave = fileName;
		ScreenCapture.CaptureScreenshot(pathToSave);
		info.SetActive(true);
		yield return new WaitForSeconds(2);
		info.SetActive(false);
	}

}
