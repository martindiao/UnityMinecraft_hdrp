using System.Collections.Generic;

public class OreIronDeepslate: Block
{
    public OreIronDeepslate(): base()
	{
		this.blockName 			= "deepslateIronOre";
		this.textureName 		= "deepslate_ore_iron";
		this.hardness 			= 7 * 40;
		this.maxStack 			= 64;
		this.dropsItself 		= false;
		this.toolTypeRequired 	= ToolType.PICKAXE;
		this.miningLevel		= MiningLevel.STONE;
		
		this.drops = new List<Drop>();
		this.drops.Add(new Drop("rawIron", 1, 1.0f));
	}
}
