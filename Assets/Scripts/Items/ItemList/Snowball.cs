using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowball: Item
{
    public Snowball()
    {
        this.itemName 				= "snowball";
		this.itemTextureName 		= "snowball";
		this.placeable				= false;
		this.placeableOnlyOnTop 	= false;
		this.placeableOnOtherItems 	= false;
		this.hasGenericMesh			= true;
		this.LoadPrefab();
    }
}
