public class Sand: Block
{
    public Sand(): base()
	{
		this.blockName 			= "sand";
		this.textureName 		= "sand";
		this.hardness 			= 1 * 10;
		this.maxStack 			= 64;
		this.dropsItself 		= true;
		this.smeltable 			= true;
		this.smeltedResult 		= new CraftingResult("glass", 1);
		this.toolTypeRequired 	= ToolType.ANY;
		this.soundType 			= BlockSoundType.DIRT;
	}
}
