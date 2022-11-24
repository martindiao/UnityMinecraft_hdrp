using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronShovel: Item
{
    public IronShovel()
    {
        this.itemName 				= "ironShovel";
		this.itemTextureName 		= "iron_shovel";
		this.placeable				= false;
		this.miningLevel			= MiningLevel.IRON;
		this.toolType				= ToolType.SHOVEL;
		this.breakingSpeedModifier	= 6.0f;
		this.maxStack				= 1;
		this.hasGenericMesh			= true;
		this.LoadPrefab();
    }
}
