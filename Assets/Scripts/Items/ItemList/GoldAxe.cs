using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldAxe: Item
{
    public GoldAxe()
    {
        this.itemName 				= "goldAxe";
		this.itemTextureName 		= "gold_axe";
		this.placeable				= false;
		this.miningLevel			= MiningLevel.IRON;
		this.toolType				= ToolType.AXE;
		this.breakingSpeedModifier	= 7.0f;
		this.maxStack				= 1;
		this.hasGenericMesh			= true;
		this.LoadPrefab();
    }
}
