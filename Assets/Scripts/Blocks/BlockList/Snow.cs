using System.Collections.Generic;

public class Snow: Block
{
    public Snow(): base()
	{
		this.blockName 			= "snow";
		this.textureName 		= "snow";
		this.hardness 			= 1 * 10;
		this.maxStack 			= 64;
		this.dropsItself 		= false;
		this.toolTypeRequired	= ToolType.SHOVEL;
		
		this.drops = new List<Drop>();
		this.drops.Add(new Drop("snowball", (int)(new System.Random().NextDouble() * 1), 1.0f));
	}
}
