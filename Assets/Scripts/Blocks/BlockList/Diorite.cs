using System.Collections.Generic;

public class Diorite: Block
{
    public Diorite(): base()
	{
		this.blockName 			= "diorite";
		this.textureName 		= "diorite";
		this.hardness 			= 2 * 20;
		this.maxStack 			= 64;
		this.dropsItself 		= true;
		this.toolTypeRequired 	= ToolType.PICKAXE;
	}
}
