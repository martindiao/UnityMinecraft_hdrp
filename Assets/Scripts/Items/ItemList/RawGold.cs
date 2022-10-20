using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RawGold: Item
{
    public RawGold()
    {
        this.itemName 				= "rawGold";
		this.itemTextureName 		= "raw_gold";
		this.placeable				= false;
		this.placeableOnlyOnTop 	= false;
		this.placeableOnOtherItems 	= false;
		this.hasGenericMesh			= true;
		this.smeltable 			= true;
		this.smeltedResult 		= new CraftingResult("goldIngot", 1);
		this.LoadPrefab();
    }
}
