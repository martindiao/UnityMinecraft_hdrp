using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Redstone: Item
{
    public Redstone()
    {
        this.itemName 				= "redstone";
		this.itemTextureName 		= "redstone";
		this.placeable				= false;
		this.placeableOnlyOnTop 	= false;
		this.placeableOnOtherItems 	= false;
		this.hasGenericMesh			= true;
		this.burnable				= false;
		this.burnTime			 	= 100;
		this.LoadPrefab();
    }
}
