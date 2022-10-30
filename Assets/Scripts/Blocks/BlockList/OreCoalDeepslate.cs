using System.Collections.Generic;

public class OreCoalDeepslate: Block
{
    public OreCoalDeepslate(): base()
	{
		this.blockName 			= "deepslateCoalOre";
		this.textureName 		= "deepslate_ore_coal";
		this.hardness 			= 2 * 20;
		this.maxStack 			= 64;
		this.dropsItself 		= false;
		this.toolTypeRequired 	= ToolType.PICKAXE;
		
		this.drops = new List<Drop>();
		this.drops.Add(new Drop("coal", 1, 1.0f));
	}
}
