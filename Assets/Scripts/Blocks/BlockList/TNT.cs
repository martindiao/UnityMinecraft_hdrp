using System.Collections.Generic;

public class TNT: Block
{
    public TNT(): base()
	{
		this.blockName 			= "tnt";
		this.textureName 		= "tnt";
		this.hasSidedTextures 	= true;
		this.interactable 		= true;
		this.hardness 			= 3 * 20;
		this.soundType 			= BlockSoundType.WOOD;
	}
}
