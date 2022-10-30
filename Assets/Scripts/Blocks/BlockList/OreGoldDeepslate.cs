using System.Collections.Generic;

public class OreGoldDeepslate: Block
{
    public OreGoldDeepslate(): base()
	{
		this.blockName 			= "deepslateGoldOre";
		this.textureName 		= "deepslate_gold_ore";
		this.hardness 			= 2 * 20;
		this.maxStack 			= 64;
		this.dropsItself 		= false;
		//this.smeltable 			= true;
		//this.smeltedResult 		= new CraftingResult("goldIngot", 1);
		this.toolTypeRequired 	= ToolType.PICKAXE;
		this.miningLevel		= MiningLevel.IRON;

		this.drops = new List<Drop>();
		this.drops.Add(new Drop("rawGold", 1, 1.0f));
	}
}
