using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class BlockCreator : EditorWindow
{
    string blockName;
    string blockTexture = null;
    string className;
    Texture texture;

    [MenuItem("Minecraft/Block Creator")]
    public static void ShowWindow()
    {
        GetWindow<BlockCreator>("Block Creator");
    }
    void OnGUI() {
        GUILayout.Label("Block name:");
        blockName = EditorGUILayout.TextField("", blockName);
        GUILayout.Label("Script name:");
        className = EditorGUILayout.TextField("", className);
        texture = (Texture2D)EditorGUILayout.ObjectField("Block texture:", texture, typeof(Texture2D), false);
        if (texture != null)
        {
            blockTexture = texture.name;
        }
        if (GUILayout.Button("Create block"))
        {
            CreateBlock();
        }
    }
    void CreateBlock()
    {
        TextAsset templateTextFile = AssetDatabase.LoadAssetAtPath("Assets/Scripts/Blocks/BlockList/blockTemplate.txt", typeof(TextAsset)) as TextAsset;
        string contents = "";
        if(templateTextFile != null) {
            contents = templateTextFile.text;
            contents = contents.Replace("blockTemplate", className);
            contents = contents.Replace("constructor", className);
            contents = contents.Replace("BLOCK_NAME", blockName);
            contents = contents.Replace("TEXTURE_NAME", blockTexture);
            Debug.Log(contents);
        }
        using(StreamWriter sw = new StreamWriter(string.Format(Application.dataPath + "/Scripts/Blocks/BlockList/{0}.cs", new object[] { className.Replace(" ", "") }))) {
            sw.Write(contents);
        }
    }
}
