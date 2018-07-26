
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Usersdata : MonoBehaviour
{
    public Text Username;
    //public string items;
    public Login DataofUsers;

  IEnumerator Start()
    {
        string info = PlayerPrefs.GetString("userinfo");
        string username = PlayerPrefs.GetString("Username");
        Username.text = username;


       /* WWW itemsdata = new WWW("http://localhost/AR/Login.php");
        yield return itemsdata;
        string itemsdataString = ;
        // print(itemsdataString);
        // Username.text = GetDataValue(items[0], "Name:")
        items = itemsdataString.Split(';');
        // print(GetDataValue(items[0], "Name:"));
        //print(GetDataValue(items[0], "Cost:"));
        Username.text = GetDataValue(items[0], "Name:");*/

       
        WWWForm form = new WWWForm();
        form.AddField("name", username);
        WWW itemsdata = new WWW("http://localhost/AR/savedata.php",form);
        yield return itemsdata;
        Debug.Log(itemsdata.text);
       



    }





   /* string GetDataValue(string username, string index)

    {
        string value = data.Substring(data.IndexOf(index) + index.Length);
        if (value.Contains("|")) value = value.Remove(value.IndexOf("|"));
        return value;

    }
    void update()


    {
        if (Input.GetKeyDown(KeyCode.Tab))

        {


        }


    }*/
}
