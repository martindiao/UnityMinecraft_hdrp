using System.Collections.Generic;

public class OreEmeraldDeepslate: Block
{
    public OreEmeraldDeepslate(): base()
	{
		this.blockName 			= "deepslateEmeraldOre";
		this.textureName 		= "deepslate_emerald_ore";
		this.hardness 			= 7 * 40;
		this.maxStack 			= 64;
		this.dropsItself 		= false;
		this.toolTypeRequired 	= ToolType.PICKAXE;
		this.miningLevel		= MiningLevel.IRON;
		
		this.drops = new List<Drop>();
		this.drops.Add(new Drop("emerald", 1, 1.0f));
	}
}
