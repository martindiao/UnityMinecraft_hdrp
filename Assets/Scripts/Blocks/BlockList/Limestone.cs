public class Limestone: Block
{
    public Limestone(): base()
	{
		this.blockName 			= "rockLimestone";
		this.textureName 		= "limestone";
		this.hardness 			= 5 * 20;
		this.maxStack 			= 64;
		this.dropsItself 		= true;
		this.smeltable 			= false;
		this.toolTypeRequired 	= ToolType.PICKAXE;
		this.miningLevel		= MiningLevel.WOOD;
	}
}
