using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sulfur: Item
{
    public Sulfur()
    {
        this.itemName 				= "sulfur";
		this.itemTextureName 		= "sulfur";
		this.placeable				= false;
		this.placeableOnlyOnTop 	= false;
		this.placeableOnOtherItems 	= false;
		this.hasGenericMesh			= true;
		this.burnable				= false;
		this.burnTime			 	= 60;
		this.LoadPrefab();
    }
}
