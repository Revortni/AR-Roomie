using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ProfileLoader : MonoBehaviour {

	public Text name;
	public Text id;
	private string[] data;
	void Start(){
        string username = PlayerPrefs.GetString("username");
        string userid= PlayerPrefs.GetString("userid");
		
		id.text = userid;
		name.text = "Welcome "+username;
	}
	
}