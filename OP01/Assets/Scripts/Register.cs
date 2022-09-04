using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class Register : MonoBehaviour
{
    public string baseUrl = "http://localhost/ThirteeNov/Register/";
	

    public InputField accountUserName;
	public InputField accountPassword;
    public Text info;  

    private string currentUsername;
    private string ukey = "accountusername";
    
   
    // Start is called before the first frame update
    void Start()
    {
        currentUsername = "";
		
		if(PlayerPrefs.HasKey(ukey)){
           if(PlayerPrefs.GetString(ukey) != ""){
				currentUsername = PlayerPrefs.GetString(ukey);
                //info.text = "You are loged in = " + currentUsername;
			}//else{
				//info.text = "You are not logged in.";
			//}
        //}else{
			//info.text = "You are not loged in.";
		}
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void AccountRegister()
    {
        string uName = accountUserName.text;
        string pWord = accountPassword.text;
        StartCoroutine(RegisterNewAccount(uName, pWord));
    }

    public void AccountLogin()
    {
        string uName = accountUserName.text;
        string pWord = accountPassword.text;
        StartCoroutine(LogInAccount(uName, pWord));
    }



    IEnumerator RegisterNewAccount(string uName, string pWord)
    {
        WWWForm form = new WWWForm();
        form.AddField("newAccountUsername", uName);
        form.AddField("newAccountPassword", pWord);
        using (UnityWebRequest www = UnityWebRequest.Post(baseUrl, form))
        {
            www.downloadHandler = new DownloadHandlerBuffer();
            yield return www.SendWebRequest();
 
            if (www.isNetworkError)
            {
                Debug.Log(www.error);
            }
            else
            {
                string responseText = www.downloadHandler.text;
				Debug.Log("Response = " + responseText);
                info.text = "Response = " + responseText;
                SceneManager.LoadScene("hesapGiris");
        
            }
        }

    }


    IEnumerator LogInAccount(string uName, string pWord)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUsername", uName);
        form.AddField("loginPassword", pWord);
        using (UnityWebRequest www = UnityWebRequest.Post(baseUrl, form))
        {
            www.downloadHandler = new DownloadHandlerBuffer();
            yield return www.SendWebRequest();
 
            if (www.isNetworkError)
            {
                Debug.Log(www.error);
            }
            else
            {
                string responseText = www.downloadHandler.text;
				if(responseText == "1"){
					PlayerPrefs.SetString(ukey, uName);
                    //info.text = "Login Success with username " + uName;
                    SceneManager.LoadScene("S1TanitimSahnesi");
                }else
                    info.text = "Başarısız Giriş.";
                
            }
        }
    }
}

