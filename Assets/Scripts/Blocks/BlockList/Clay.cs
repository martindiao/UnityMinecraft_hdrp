using System.Collections.Generic;

public class Clay: Block
{
    public Clay(): base()
	{
		this.blockName 			= "clay";
		this.textureName 		= "clay";
		this.hardness 			= 5 * 20;
		this.maxStack 			= 64;
		this.dropsItself 		= false;
		this.toolTypeRequired 	= ToolType.SHOVEL;
		
		this.drops = new List<Drop>();
		this.drops.Add(new Drop("clayBall", (int)(new System.Random().NextDouble() * 8 + 1), 1.0f));
	}
}
