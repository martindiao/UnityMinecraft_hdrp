using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondShovel: Item
{
    public DiamondShovel()
    {
        this.itemName 				= "diamondShovel";
		this.itemTextureName 		= "diamond_shovel";
		this.placeable				= false;
		this.miningLevel			= MiningLevel.DIAMOND;
		this.toolType				= ToolType.SHOVEL;
		this.breakingSpeedModifier	= 8.0f;
		this.maxStack				= 1;
		this.hasGenericMesh			= true;
		this.LoadPrefab();
    }
}
