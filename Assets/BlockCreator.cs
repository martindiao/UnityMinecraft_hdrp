using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class BlockCreator : EditorWindow
{
    public string blockName;
    public string blockTexture = null;
    public string className;
    public string drop;
    public float hardness;
    public bool hasSidedTextures;
    public bool burnable;
    public float burnTime;
    public bool breakable = true;
    public bool smeltable;
    public string smeltedResult;
    public int smeltedResultAmt;
    public int maxStack = 64;
    public int dropAmt = 1;
    public bool placeable = true;
    public bool dropsItself = true;
    public BlockSoundType blockSoundType;
    public MiningLevel miningLevel;
    public ToolType toolType;
    public Texture texture;

    [MenuItem("Minecraft/Block Creator")]
    public static void ShowWindow()
    {
        GetWindow<BlockCreator>("Block Creator");
    }
    void OnGUI() {
        GUILayout.Label("Block name:");
        blockName = GUILayout.TextField(blockName);
        hasSidedTextures = EditorGUILayout.Toggle("Has sided textures:", hasSidedTextures);
        breakable = EditorGUILayout.Toggle("Breakable:", breakable);
        placeable = EditorGUILayout.Toggle("Placeable:", placeable);
        dropsItself = EditorGUILayout.Toggle("Drops itself:", dropsItself);
        if (dropsItself != true)
        {
            GUILayout.Label("Item to drop:");
            drop = GUILayout.TextField(drop);
            dropAmt = EditorGUILayout.IntField("Dropped item amount:", dropAmt);
        }
        burnable = EditorGUILayout.Toggle("Burnable:", burnable);
        if (burnable)
        {
            burnTime = EditorGUILayout.FloatField("Burn time:", burnTime);
        }
        smeltable = EditorGUILayout.Toggle("Smeltable:", smeltable);
        if (smeltable)
        {
            GUILayout.Label("Smelted result:");
            smeltedResult = GUILayout.TextField(smeltedResult);
            smeltedResultAmt = EditorGUILayout.IntField("Smelted result amount:", smeltedResultAmt);
        }
        maxStack = EditorGUILayout.IntField("Max stack:", maxStack);
        hardness = EditorGUILayout.FloatField("Hardness:", hardness);
        miningLevel = (MiningLevel)EditorGUILayout.EnumPopup("Mining level:", miningLevel);
        toolType = (ToolType)EditorGUILayout.EnumPopup("Tool required:", toolType);
        blockSoundType = (BlockSoundType)EditorGUILayout.EnumPopup("Block sound type:", blockSoundType);
        texture = (Texture2D)EditorGUILayout.ObjectField("Block texture:", texture, typeof(Texture2D), false);
        if (blockName != null)
        {
            className = blockName.Substring(0, 1).ToUpper() + blockName.Substring(1).ToLower();
        }
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
            contents = contents.Replace("HARDNESS", hardness.ToString());
            contents = contents.Replace("HASSIDEDTEXTURES", hasSidedTextures.ToString().Substring(0, 1).ToLower() + hasSidedTextures.ToString().Substring(1).ToLower());
            contents = contents.Replace("BURNABLE", burnable.ToString().Substring(0, 1).ToLower() + burnable.ToString().Substring(1).ToLower());
            contents = contents.Replace("SOUND_TYPE", blockSoundType.ToString());
            contents = contents.Replace("MININGLEVEL", miningLevel.ToString());
            contents = contents.Replace("BURN_TIME", burnTime.ToString());
            contents = contents.Replace("BREAKABLE", breakable.ToString().Substring(0, 1).ToLower() + breakable.ToString().Substring(1).ToLower());
            contents = contents.Replace("PLACEABLE", placeable.ToString().Substring(0, 1).ToLower() + placeable.ToString().Substring(1).ToLower());
            contents = contents.Replace("SMELTABLE", smeltable.ToString().Substring(0, 1).ToLower() + smeltable.ToString().Substring(1).ToLower());
            contents = contents.Replace("DROPS_ITSELF", dropsItself.ToString().Substring(0, 1).ToLower() + dropsItself.ToString().Substring(1).ToLower());
            contents = contents.Replace("TOOLTYPE", toolType.ToString());
            contents = contents.Replace("SMELTED_RESULT", smeltedResult);
            contents = contents.Replace("RESULTAMT", smeltedResultAmt.ToString());
            contents = contents.Replace("MAX_STACK", maxStack.ToString());
            contents = contents.Replace("DROP", drop);
            contents = contents.Replace("DROPAMT", dropAmt.ToString());
            Debug.Log(contents);
        }
        using(StreamWriter sw = new StreamWriter(string.Format(Application.dataPath + "/Scripts/Blocks/BlockList/{0}.cs", new object[] { className.Replace(" ", "") }))) {
            sw.Write(contents);
        }
    }
}
