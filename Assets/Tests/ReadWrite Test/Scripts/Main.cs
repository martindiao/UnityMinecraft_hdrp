using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Main : MonoBehaviour
{
    public InputField inputField;
    public void CreateText()
    {
        string path = Application.dataPath + "/ReadWrite Test/log.txt";
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "Log \n\n");
        }
        string content = inputField.text + " \n";
        File.AppendAllText(path, content);
    }
}
