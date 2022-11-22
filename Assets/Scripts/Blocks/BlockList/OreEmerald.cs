using System.Collections.Generic;

public class OreEmerald: Block
{
    public OreEmerald(): base()
	{
		this.blockName 			= "oreEmerald";
		this.textureName 		= "emerald_ore";
		this.hardness 			= 6 * 20;
		this.maxStack 			= 64;
		this.dropsItself 		= false;
		this.toolTypeRequired 	= ToolType.PICKAXE;
		this.miningLevel		= MiningLevel.IRON;
		
		this.drops = new List<Drop>();
		this.drops.Add(new Drop("emerald", 1, 1.0f));
	}
}
