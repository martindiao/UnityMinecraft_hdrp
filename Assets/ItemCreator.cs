using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class ItemCreator : EditorWindow
{
    public string itemName;
    public string itemTexture = null;
    public string className;
    public string drop;
    public float breakingSpeedModifier;
    public bool hasGenericMesh = true;
    public bool burnable;
    public float burnTime;
    public bool smeltable;
    public string smeltedResult;
    public int smeltedResultAmt;
    public int maxStack = 64;
    public int dropAmt = 1;
    public bool placeable = true;
    public bool dropsItself = true;
    public MiningLevel miningLevel;
    public ToolType toolType;
    public Texture texture;

    [MenuItem("Minecraft/Item Creator")]
    public static void ShowWindow()
    {
        GetWindow<ItemCreator>("Item Creator");
    }
    void OnGUI() {
        itemName = EditorGUILayout.TextField("Block name:", itemName);
        hasGenericMesh = EditorGUILayout.Toggle("Has generic mesh:", hasGenericMesh);
        placeable = EditorGUILayout.Toggle("Placeable:", placeable);
        dropsItself = EditorGUILayout.Toggle("Drops itself:", dropsItself);
        if (dropsItself != true)
        {
            EditorGUI.indentLevel++;
            drop = EditorGUILayout.TextField("Item to drop:", drop);
            dropAmt = EditorGUILayout.IntField("Dropped item amount:", dropAmt);
            EditorGUI.indentLevel--;
        }
        burnable = EditorGUILayout.Toggle("Burnable:", burnable);
        if (burnable)
        {
            EditorGUI.indentLevel++;
            burnTime = EditorGUILayout.FloatField("Burn time:", burnTime);
            EditorGUI.indentLevel--;
        }
        smeltable = EditorGUILayout.Toggle("Smeltable:", smeltable);
        if (smeltable)
        {
            EditorGUI.indentLevel++;
            smeltedResult = EditorGUILayout.TextField("Smelted result:", smeltedResult);
            smeltedResultAmt = EditorGUILayout.IntField("Smelted result amount:", smeltedResultAmt);
            EditorGUI.indentLevel--;
        }
        maxStack = EditorGUILayout.IntField("Max stack:", maxStack);
        breakingSpeedModifier = EditorGUILayout.FloatField("Breaking speed modifier:", breakingSpeedModifier);
        miningLevel = (MiningLevel)EditorGUILayout.EnumPopup("Mining level:", miningLevel);
        texture = (Texture2D)EditorGUILayout.ObjectField("Item texture:", texture, typeof(Texture2D), false);
        if (itemName != null)
        {
            className = itemName.Substring(0, 1).ToUpper() + itemName.Substring(1).ToLower();
        }
        if (texture != null)
        {
            itemTexture = texture.name;
        }
        if (GUILayout.Button("Create item"))
        {
            CreateItem();
        }
    }
    void CreateItem()
    {
        TextAsset templateTextFile = AssetDatabase.LoadAssetAtPath("Assets/Scripts/Items/ItemList/itemTemplate.txt", typeof(TextAsset)) as TextAsset;
        string contents = "";
        if(templateTextFile != null) {
            contents = templateTextFile.text;
            contents = contents.Replace("itemTemplate", className);
            contents = contents.Replace("constructor", className);
            contents = contents.Replace("ITEM_NAME", itemName);
            contents = contents.Replace("TEXTURE_NAME", itemTexture);
            contents = contents.Replace("BREAKINGSPEEDMODIFIER", breakingSpeedModifier.ToString());
            contents = contents.Replace("HASGENERICMESH", hasGenericMesh.ToString().Substring(0, 1).ToLower() + hasGenericMesh.ToString().Substring(1).ToLower());
            contents = contents.Replace("BURNABLE", burnable.ToString().Substring(0, 1).ToLower() + burnable.ToString().Substring(1).ToLower());
            contents = contents.Replace("MININGLEVEL", miningLevel.ToString());
            contents = contents.Replace("BURN_TIME", burnTime.ToString());
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
