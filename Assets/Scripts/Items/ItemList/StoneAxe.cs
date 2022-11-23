using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneAxe: Item
{
    public StoneAxe()
    {
        this.itemName 				= "stoneAxe";
		this.itemTextureName 		= "stone_axe";
		this.placeable				= false;
		this.miningLevel			= MiningLevel.STONE;
		this.toolType				= ToolType.AXE;
		this.breakingSpeedModifier	= 5.0f;
		this.maxStack				= 1;
		this.hasGenericMesh			= true;
		this.LoadPrefab();
    }
}
