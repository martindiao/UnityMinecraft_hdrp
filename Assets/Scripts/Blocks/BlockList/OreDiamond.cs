using System.Collections.Generic;

public class OreDiamond: Block
{
    public OreDiamond(): base()
	{
		this.blockName 			= "oreDiamond";
		this.textureName 		= "diamond_ore";
		this.hardness 			= 6 * 20;
		this.maxStack 			= 64;
		this.dropsItself 		= false;
		this.toolTypeRequired 	= ToolType.PICKAXE;
		this.miningLevel		= MiningLevel.IRON;
		
		this.drops = new List<Drop>();
		this.drops.Add(new Drop("diamond", 1, 1.0f));
	}
}
