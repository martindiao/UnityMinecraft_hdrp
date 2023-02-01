using System.Collections.Generic;

public class Leaves: Block
{
    public Leaves(): base()
	{
		this.blockName 			= "leaves";
		this.textureName 		= "oak_leaves";
		this.hardness 			= 1 * 15;
		this.dropsItself		= false;
		this.soundType			= BlockSoundType.DIRT;
		
		this.drops = new List<Drop>();
		this.drops.Add(new Drop("apple", 1, .1f));
		this.drops.Add(new Drop("stick", 1, .1f));
	}
}
