public class BrickBlock: Block
{
    public BrickBlock(): base()
	{
		this.blockName 			= "brickBlock";
		this.textureName	 	= "brickBlock";
		this.hardness 			= 2 * 10;
		this.maxStack 			= 64;
		this.toolTypeRequired 	= ToolType.PICKAXE;
		this.miningLevel 		= MiningLevel.WOOD;
	}
}
