using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class HTTP_v2018 : MonoBehaviour
{

    // Use this for initialization
    IEnumerator Start()
    {
        var req = UnityWebRequest.Post("https://httpbin.org/post", "data");
        var response = req.SendWebRequest();
        yield return response;

        if (req.isHttpError)
        {
            Debug.LogError("http error:" + req.error + " code:" + req.responseCode + " " + req.downloadHandler.text);
        }

    }

}
