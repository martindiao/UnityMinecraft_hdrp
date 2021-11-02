using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClayBall: Item
{
    public ClayBall()
    {
        this.itemName 				= "clayBall";
		this.itemTextureName 		= "clayBall";
		this.placeable				= false;
		this.placeableOnlyOnTop 	= false;
		this.placeableOnOtherItems 	= false;
		this.hasGenericMesh			= true;
		this.smeltable 			= true;
		this.smeltedResult 		= new CraftingResult("brick", 1);
		this.LoadPrefab();
    }
}
