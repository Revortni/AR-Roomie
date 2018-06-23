using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakeScreenshot : MonoBehaviour {

	[SerializeField]
	public GameObject info;
	private bool enter = false;
	private int x;
	void Start(){
		x=0;
		info.SetActive(false);
		this.GetComponent<Button>().onClick.AddListener(delegate{
			TakeAShot();
			});
	}

	public void TakeAShot()
	{	
		x=0;
		StartCoroutine ("CaptureIt");		
	}

	IEnumerator CaptureIt()
	{
		string timeStamp = System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
		string fileName = "Screenshot" + timeStamp + ".png";
		string path= fileName;
		ScreenCapture.CaptureScreenshot(path);
		info.SetActive(true);
		yield return new WaitForSeconds(2);
		info.SetActive(false);
		x=1;
	}

	void Update(){
		if(x==1){
			StopAllCoroutines();
		}
	}

}
