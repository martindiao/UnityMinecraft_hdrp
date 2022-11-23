using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondAxe: Item
{
    public DiamondAxe()
    {
        this.itemName 				= "diamondAxe";
		this.itemTextureName 		= "diamond_axe";
		this.placeable				= false;
		this.miningLevel			= MiningLevel.DIAMOND;
		this.toolType				= ToolType.AXE;
		this.breakingSpeedModifier	= 8.0f;
		this.maxStack				= 1;
		this.hasGenericMesh			= true;
		this.LoadPrefab();
    }
}
