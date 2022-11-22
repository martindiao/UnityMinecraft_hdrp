using System.Collections.Generic;
public class LimestoneSaltpeter: Block
{
    public LimestoneSaltpeter(): base()
	{
		this.blockName 			= "saltpeterOre";
		this.textureName 		= "limestone_saltpeter";
		this.hardness 			= 5 * 20;
		this.maxStack 			= 64;
		this.dropsItself 		= true;
		this.smeltable 			= true;
		this.smeltedResult 		= new CraftingResult("saltpeter", 1);
		this.toolTypeRequired 	= ToolType.PICKAXE;
		this.miningLevel		= MiningLevel.WOOD;
	}
}
