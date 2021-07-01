using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Login_out_Register : MonoBehaviour
{
    //public string url = "http://localhost/Chetana_Programs/ch_log.php";
    void Start()
    {
        // A correct website page.
        StartCoroutine(GetRequest("http://localhost/Chetana_Programs/ch_log.php"));

        // A non-existing page.
        StartCoroutine(GetRequest("https://error.html"));
    }
    public void login()
    {
      
    }

    IEnumerator GetRequest(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            if (webRequest.isNetworkError)
            {
                Debug.Log(pages[page] + ": Error: " + webRequest.error);
            }
            else
            {
                Debug.Log(pages[page] + ":\nReceived: " + webRequest.downloadHandler.text);
            }
        }
    }
}
