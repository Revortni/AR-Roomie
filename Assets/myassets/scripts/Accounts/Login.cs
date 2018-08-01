using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Login : MonoBehaviour
{
    public InputField Username;
    public InputField Password;
    public Button Submit;
    public string[] items;
    public Text info;

    void Start(){
       
    }

    // Use this for initialization
    void Awake()
    {
        DontDestroyOnLoad(this);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (Username.isFocused)
            {
                Password.Select();
            }
        }
    }

    public void CallLoginin()
    {
        if(Username.text=="" || Password.text=="")
        {
            info.color = Color.red;
            info.text="Please fill up all the fields";
            return;
        }
        StartCoroutine(Loginin());
    }

    

    // Update is called once per frame



    IEnumerator Loginin()
    {   
        WWWForm form = new WWWForm();
        form.AddField("name", Username.text);
        form.AddField("password", Password.text);

        WWW www = new WWW("http://192.168.1.5/AR/Login.php", form);

        yield return www;
        //Debug.Log(" successfull");
        string Playerdata = www.text;
        PlayerPrefs.SetString("userinfo", Playerdata);
        PlayerPrefs.SetString("username", Username.text);
        if(Playerdata == "1")
        {
            info.color = Color.red;
            info.text="Incorrect username or password. Please try again.";
        }
        else
        {
            info.color = Color.green;
            info.text = "Login Successful";
            UnityEngine.SceneManagement.SceneManager.LoadScene(3);
        }
    }

   
}

