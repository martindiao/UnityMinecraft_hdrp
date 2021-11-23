using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

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
    string path;
    string content;
    void Start()
    {
        path = Application.dataPath + "/ReadWrite Test/data.txt";
        myObject.level = 1;
        myObject.timeElapsed = 47.5f;
        myObject.playerName = "Dr Charles Francis";
        json = JsonUtility.ToJson(myObject);
        content = json;
    }
    public void CreateJSONCode()
    {
        File.Delete(path);
        File.AppendAllText(path, content + "\n");
    }
}
