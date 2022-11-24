using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneShovel: Item
{
    public StoneShovel()
    {
        this.itemName 				= "stoneShovel";
		this.itemTextureName 		= "stone_shovel";
		this.placeable				= false;
		this.miningLevel			= MiningLevel.STONE;
		this.toolType				= ToolType.SHOVEL;
		this.breakingSpeedModifier	= 5.0f;
		this.maxStack				= 1;
		this.hasGenericMesh			= true;
		this.LoadPrefab();
    }
}
