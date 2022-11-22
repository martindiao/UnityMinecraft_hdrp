using System.Collections.Generic;

public class Andesite: Block
{
    public Andesite(): base()
	{
		this.blockName 			= "andesite";
		this.textureName 		= "andesite";
		this.hardness 			= 6 * 20;
		this.maxStack 			= 64;
		this.dropsItself 		= true;
		this.toolTypeRequired 	= ToolType.PICKAXE;
	}
}
