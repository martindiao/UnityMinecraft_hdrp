using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StonePickaxe: Item
{
    public StonePickaxe()
    {
        this.itemName 				= "stonePickaxe";
		this.itemTextureName 		= "stone_pickaxe";
		this.placeable				= false;
		this.miningLevel			= MiningLevel.STONE;
		this.toolType				= ToolType.PICKAXE;
		this.breakingSpeedModifier	= 5.0f;
		this.maxStack				= 1;
		this.LoadPrefab();
    }
}
