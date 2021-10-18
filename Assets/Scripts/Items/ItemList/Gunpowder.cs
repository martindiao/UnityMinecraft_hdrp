using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunpowder: Item
{
    public Gunpowder()
    {
        this.itemName 				= "gunpowder";
		this.itemTextureName 		= "gunpowder";
		this.placeable				= false;
		this.placeableOnlyOnTop 	= false;
		this.placeableOnOtherItems 	= false;
		this.hasGenericMesh			= true;
		this.burnable				= true;
		this.burnTime			 	= 40;
		this.LoadPrefab();
    }
}
