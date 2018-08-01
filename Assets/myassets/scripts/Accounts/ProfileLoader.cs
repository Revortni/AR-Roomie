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
        string info = PlayerPrefs.GetString("userinfo");
		data = info.Split(',');
		id.text = data[0];
		name.text = "Welcome "+data[1].Split(':')[1];
	}
	
	void getDataVal(string data, string index){
		string value = data.Substring(data.IndexOf(index)+index.Length);
	}
}