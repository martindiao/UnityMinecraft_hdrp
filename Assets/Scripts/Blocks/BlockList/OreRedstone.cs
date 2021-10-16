using System.Collections.Generic;

public class OreRedstone: Block
{
    public OreRedstone(): base()
	{
		this.blockName 			= "oreRedstone";
		this.textureName 		= "redstone_ore";
		this.hardness 			= 1 * 20;
		this.maxStack 			= 64;
		this.dropsItself 		= false;
		this.toolTypeRequired 	= ToolType.PICKAXE;
		this.miningLevel		= MiningLevel.IRON;
		
		this.drops = new List<Drop>();
		this.drops.Add(new Drop("redstone", (int)((new System.Random().NextDouble() * 4) + 1), 1.0f));
	}
}
