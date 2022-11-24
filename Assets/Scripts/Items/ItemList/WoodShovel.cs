using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodShovel: Item
{
    public WoodShovel()
    {
        this.itemName 				= "woodShovel";
		this.itemTextureName 		= "wooden_shovel";
		this.placeable				= false;
		this.miningLevel			= MiningLevel.WOOD;
		this.toolType				= ToolType.SHOVEL;
		this.breakingSpeedModifier	= 3.5f;
		this.maxStack				= 1;
		this.hasGenericMesh			= true;
		this.LoadPrefab();
    }
}
