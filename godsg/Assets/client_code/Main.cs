﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Google.Protobuf;

public class Main : MonoBehaviour
{


    void Awake()
    {
        //要开始的逻辑是什么呢
    }

    // Use this for initialization
    void Start()
    {
        //HttpUtil.Instance.sendGetRequest("http://localhost:10024/fast_login?machine_id=111111&channel=123&device=android", onLoginComplete, 3000);
        GameObject obj = GameObject.Find("Canvas");

        GameObject loginObj = Resources.Load("Perfab/Gui/UiLogin") as GameObject;

        GameObject newObj = GameObject.Instantiate(loginObj);
        newObj.transform.parent = obj.transform;
        newObj.transform.localPosition = Vector2.zero;
        newObj.AddComponent<UiLogin>();
        
    }

    void onLoginComplete(string haha)
    {
        UnityEngine.Debug.LogError(" the result is " + haha);
        
    }

    // Update is called once per frame
    void Update()
    {
        HttpUtil.Instance.OnUpdate();
        P3Net.NetClient.Instance.Update(Time.deltaTime);
    }

  
}