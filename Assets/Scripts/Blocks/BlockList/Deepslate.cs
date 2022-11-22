using System.Collections.Generic;

public class Deepslate: Block
{
    public Deepslate(): base()
	{
		this.blockName 			= "deepslate";
		this.textureName 		= "deepslate";
		this.hasSidedTextures 	= true;
		this.hardness 			= 7 * 40;
		this.soundType 			= BlockSoundType.STONE;
		this.toolTypeRequired = ToolType.PICKAXE;
	}
}
