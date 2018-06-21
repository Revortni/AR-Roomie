using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour {
	public GameObject inputUserName;
	public GameObject inputPassword;
	private string username;
	private string password;
	public Button btn;

	string LoginURL = "localhost/ARRoomie/login.php";

	void Start(){
		btn.onClick.AddListener(clickHandler);
	}

	void Update(){
		username=inputUserName.GetComponent<InputField>().text;
		password=inputPassword.GetComponent<InputField>().text;
		if (Input.GetKeyDown(KeyCode.Tab)) {
			if (inputUserName.GetComponent<InputField>().isFocused) {
				inputPassword.GetComponent<InputField>().Select();
			}
			if (inputPassword.GetComponent<InputField>().isFocused) {
				btn.Select();
			}
		}
	}

	void clickHandler(){
		LoginToDB();
	}

	IEnumerator LoginToDB(){
		WWWForm form = new WWWForm ();
		form.AddField("usernamePost", username);
		form.AddField("passwordPost", password);

		WWW www = new WWW(LoginURL, form);
		yield return www;
		
	}
}
