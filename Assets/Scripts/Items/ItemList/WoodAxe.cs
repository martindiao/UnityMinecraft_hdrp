using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodAxe: Item
{
    public WoodAxe()
    {
        this.itemName 				= "woodAxe";
		this.itemTextureName 		= "wooden_axe";
		this.placeable				= false;
		this.miningLevel			= MiningLevel.WOOD;
		this.toolType				= ToolType.AXE;
		this.breakingSpeedModifier	= 3.5f;
		this.maxStack				= 1;
		this.hasGenericMesh			= true;
		this.LoadPrefab();
    }
}
