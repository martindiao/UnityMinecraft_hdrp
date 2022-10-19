using System.Collections.Generic;

public class Granite: Block
{
    public Granite(): base()
	{
		this.blockName 			= "granite";
		this.textureName 		= "granite";
		this.hardness 			= 2 * 20;
		this.maxStack 			= 64;
		this.dropsItself 		= true;
		this.toolTypeRequired 	= ToolType.PICKAXE;
	}
}
