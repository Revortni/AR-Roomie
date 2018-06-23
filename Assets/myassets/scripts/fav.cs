using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fav : MonoBehaviour {

	private bool save;
	public Sprite off;
	public Sprite on;
	// Use this for initialization
	void Start () {
		save=false;
		this.GetComponent<Button>().onClick.AddListener(delegate{
			toggle();
			});
	}

	void toggle(){
		save=!save;
		if(save){
			this.GetComponent<Image>().sprite = on;
		}else{
			this.GetComponent<Image>().sprite = off;
		}
		Debug.Log(save);
		return;
	}
}
