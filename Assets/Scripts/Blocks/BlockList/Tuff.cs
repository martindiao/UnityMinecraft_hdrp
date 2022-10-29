using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuff: Block
{
    public Tuff(): base()
	{
		this.blockName 			= "tuff";
		this.hardness 			= 3 * 40;
		this.smeltable 			= false;
		this.toolTypeRequired 	= ToolType.PICKAXE;
		this.dropsItself = true;
	}
}
