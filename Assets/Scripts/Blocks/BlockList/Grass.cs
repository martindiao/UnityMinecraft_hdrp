using System.Collections.Generic;
public class Grass: Block
{
    public Grass(): base()
	{
		this.blockName 			= "grass";
		this.textureName 		= "grass_block";
		this.hardness 			= 1 * 20;
		this.hasSidedTextures 	= true;
		this.soundType 			= BlockSoundType.DIRT;
		this.dropsItself		= false;
		this.toolTypeRequired	= ToolType.SHOVEL;

		this.drops = new List<Drop>();
		this.drops.Add(new Drop("dirt", 1, 1.0f));
	}
}
