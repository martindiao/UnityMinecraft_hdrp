using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick: Item
{
    public Brick()
    {
        this.itemName 				= "brick";
		this.itemTextureName 		= "brick";
		this.placeable				= false;
		this.placeableOnlyOnTop 	= false;
		this.placeableOnOtherItems 	= false;
		this.hasGenericMesh			= true;
		this.LoadPrefab();
    }
}
