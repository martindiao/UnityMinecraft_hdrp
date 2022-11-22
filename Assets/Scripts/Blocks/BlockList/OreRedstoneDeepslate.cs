using System.Collections.Generic;

public class OreRedstoneDeepslate: Block
{
    public OreRedstoneDeepslate(): base()
	{
		this.blockName 			= "deepslateRedstoneOre";
		this.textureName 		= "deepslate_redstone_ore";
		this.hardness 			= 7 * 40;
		this.maxStack 			= 64;
		this.dropsItself 		= false;
		this.toolTypeRequired 	= ToolType.PICKAXE;
		this.miningLevel		= MiningLevel.IRON;
		
		this.drops = new List<Drop>();
		this.drops.Add(new Drop("redstone", 1, 1.0f));
	}
}
