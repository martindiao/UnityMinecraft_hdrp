public class SulfurBlock: Block
{
    public SulfurBlock(): base()
	{
		this.blockName 			= "sulfurBlock";
		this.textureName	 	= "sulfur_block";
		this.hardness 			= 2 * 20;
		this.maxStack 			= 64;
		this.toolTypeRequired 	= ToolType.PICKAXE;
		this.miningLevel 		= MiningLevel.IRON;
	}
}
