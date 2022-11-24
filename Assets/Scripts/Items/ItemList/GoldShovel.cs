using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldShovel: Item
{
    public GoldShovel()
    {
        this.itemName 				= "goldShovel";
		this.itemTextureName 		= "gold_shovel";
		this.placeable				= false;
		this.miningLevel			= MiningLevel.IRON;
		this.toolType				= ToolType.SHOVEL;
		this.breakingSpeedModifier	= 7.0f;
		this.maxStack				= 1;
		this.hasGenericMesh			= true;
		this.LoadPrefab();
    }
}
