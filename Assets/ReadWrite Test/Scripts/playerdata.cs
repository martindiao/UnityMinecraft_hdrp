using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class playerdata : MonoBehaviour
{
    [Serializable]
    public class statsData
    {
        public int level;
        public float timeElapsed;
        public string playerName;
    }
    statsData myObject = new statsData();
    string json;
    void Start()
    {
        myObject.level = 1;
        myObject.timeElapsed = 47.5f;
        myObject.playerName = "Dr Charles Francis";
    }
    public void toJSON()
    {
        json = JsonUtility.ToJson(myObject);
        Debug.Log(json);
    }
}
