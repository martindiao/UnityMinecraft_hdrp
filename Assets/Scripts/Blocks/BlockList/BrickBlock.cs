public class BrickBlock: Block
{
    public BrickBlock(): base()
	{
		this.blockName 			= "brickBlock";
		this.textureName	 	= "brickBlock";
		this.hardness 			= 5 * 60;
		this.maxStack 			= 64;
		this.toolTypeRequired 	= ToolType.PICKAXE;
		this.miningLevel 		= MiningLevel.WOOD;
		this.dropsItself 		= false;
	}
}
