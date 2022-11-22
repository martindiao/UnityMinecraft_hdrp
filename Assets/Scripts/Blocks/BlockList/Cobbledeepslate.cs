using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cobbledeepslate: Block
{
    public Cobbledeepslate(): base()
	{
		this.blockName 			= "cobbledeepslate";
		this.hardness 			= 7 * 70;
		this.smeltable 			= true;
		this.smeltedResult		= new CraftingResult("deepslate", 1);
		this.toolTypeRequired 	= ToolType.PICKAXE;
		this.dropsItself = true;
	}
}
