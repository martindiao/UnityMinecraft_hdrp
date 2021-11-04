public class Glass: Block
{
    public Glass(): base()
	{
		this.blockName 			= "glass";
		this.textureName 		= "glass";
		this.hardness 			= 5;
		this.maxStack 			= 64;
		this.dropsItself 		= true;
		this.toolTypeRequired 	= ToolType.ANY;
	}
}
