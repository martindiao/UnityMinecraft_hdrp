using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple: Item
{
    public Apple()
    {
        this.itemName 				= "apple";
		this.itemTextureName 		= "apple";
		this.placeable				= false;
		this.placeableOnlyOnTop 	= false;
		this.placeableOnOtherItems 	= false;
		this.hasGenericMesh			= true;
		this.burnable				= true;
		this.burnTime			 	= 70;
		this.LoadPrefab();
    }
}
