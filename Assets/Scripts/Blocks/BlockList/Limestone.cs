public class Limestone: Block
{
    public Limestone(): base()
	{
		this.blockName 			= "rockLimestone";
		this.textureName 		= "limestone";
		this.hardness 			= 2 * 20;
		this.maxStack 			= 64;
		this.dropsItself 		= true;
		this.smeltable 			= false;
		this.smeltedResult 		= new CraftingResult("petroleum", 1);
		this.toolTypeRequired 	= ToolType.PICKAXE;
		this.miningLevel		= MiningLevel.WOOD;
	}
}
