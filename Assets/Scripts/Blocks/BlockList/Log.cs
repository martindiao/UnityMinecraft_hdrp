public class Log: Block
{
    public Log(): base()
	{
		this.blockName 			= "log";
		this.textureName 		= "oak_log";
		this.hardness 			= 1 * 20;
		this.hasSidedTextures 	= true;
		this.burnable 			= true;
		this.burnTime 			= 300;
		this.smeltable 			= true;
		this.smeltedResult 		= new CraftingResult("charcoal", 1);
		this.soundType			= BlockSoundType.WOOD;
	}
}
