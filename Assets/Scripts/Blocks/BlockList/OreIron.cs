using System.Collections.Generic;

public class OreIron: Block
{
    public OreIron(): base()
	{
		this.blockName 			= "oreIron";
		this.textureName 		= "iron_ore";
		this.hardness 			= 2 * 20;
		this.maxStack 			= 64;
		this.dropsItself 		= false;
		//this.smeltable 			= true;
		//this.smeltedResult 		= new CraftingResult("ironIngot", 1);
		this.toolTypeRequired 	= ToolType.PICKAXE;
		this.miningLevel		= MiningLevel.STONE;

		this.drops = new List<Drop>();
		this.drops.Add(new Drop("rawIron", 1, 1.0f));
	}
}
