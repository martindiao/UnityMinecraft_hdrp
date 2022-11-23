using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronAxe: Item
{
    public IronAxe()
    {
        this.itemName 				= "ironAxe";
		this.itemTextureName 		= "iron_axe";
		this.placeable				= false;
		this.miningLevel			= MiningLevel.IRON;
		this.toolType				= ToolType.AXE;
		this.breakingSpeedModifier	= 6.0f;
		this.maxStack				= 1;
		this.hasGenericMesh			= true;
		this.LoadPrefab();
    }
}
