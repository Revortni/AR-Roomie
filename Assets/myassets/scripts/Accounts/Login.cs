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
        StartCoroutine(Loginin());
    }

    

    // Update is called once per frame



    IEnumerator Loginin()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", Username.text);
        form.AddField("password", Password.text);

        WWW www = new WWW("http://localhost/AR/Login.php", form);

        yield return www;
        //Debug.Log(" successfull");
       string Playersdata = www.text;
        PlayerPrefs.SetString("usersinfo", Playersdata);
        PlayerPrefs.SetString("Username", Username.text);
       
        
        UnityEngine.SceneManagement.SceneManager.LoadScene(3);

    }

   
}

