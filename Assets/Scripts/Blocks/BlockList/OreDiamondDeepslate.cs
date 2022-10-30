using System.Collections.Generic;

public class OreDiamondDeepslate: Block
{
    public OreDiamondDeepslate(): base()
	{
		this.blockName 			= "deepslateDiamondOre";
		this.textureName 		= "deepslate_ore_diamond";
		this.hardness 			= 2 * 20;
		this.maxStack 			= 64;
		this.dropsItself 		= false;
		this.toolTypeRequired 	= ToolType.PICKAXE;
		this.miningLevel		= MiningLevel.IRON;
		
		this.drops = new List<Drop>();
		this.drops.Add(new Drop("diamond", 1, 1.0f));
	}
}
