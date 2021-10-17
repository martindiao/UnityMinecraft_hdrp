using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charcoal: Item
{
    public Charcoal()
    {
        this.itemName 				= "charcoal";
		this.itemTextureName 		= "charcoal";
		this.placeable				= false;
		this.placeableOnlyOnTop 	= false;
		this.placeableOnOtherItems 	= false;
		this.hasGenericMesh			= true;
		this.burnable				= true;
		this.burnTime				= 75 * 20;
		this.LoadPrefab();
    }
}
