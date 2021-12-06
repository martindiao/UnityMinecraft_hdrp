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
    statsData myObject;
    string json;
    string path;
    string content;
    void Start()
    {
        //Creates a new instance of the class...
        myObject = new statsData();

        //Initializes the data...
        path = Application.dataPath + "/ReadWrite Test/data.txt";
        myObject.level = 1;
        myObject.timeElapsed = 47.5f;
        myObject.playerName = "Dr Charles Francis";

        //Converts the data to Json...
        json = JsonUtility.ToJson(myObject, true);

        //Uncomment these if you want to rewrite the data to data.txt
        //File.Delete(path);
        //File.WriteAllText(path, content);

        //Assigns the contents of data.txt to json...
        json = File.ReadAllText(path);

        //Overwrites the data in the myObject class with new data...
        JsonUtility.FromJsonOverwrite(json, myObject);

        //And finally prints the data values.
        Debug.Log(json);
    }
}
