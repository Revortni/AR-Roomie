using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Profile : MonoBehaviour
{
    public Text data;
    //public string items;
    public Login DataofUsers;

    void Start()
    {
        string info = PlayerPrefs.GetString("userinfo");
        string username = PlayerPrefs.GetString("Username");
        data.text = username;

    }

}