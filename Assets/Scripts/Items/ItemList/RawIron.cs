using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RawIron: Item
{
    public RawIron()
    {
        this.itemName 				= "rawIron";
		this.itemTextureName 		= "raw_iron";
		this.placeable				= false;
		this.placeableOnlyOnTop 	= false;
		this.placeableOnOtherItems 	= false;
		this.hasGenericMesh			= true;
		this.smeltable 			= true;
		this.smeltedResult 		= new CraftingResult("ironIngot", 1);
		this.LoadPrefab();
    }
}
