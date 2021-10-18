public class OreSulfur: Block
{
    public OreSulfur(): base()
	{
		this.blockName 			= "oreSulfur";
		this.textureName 		= "sulfur_ore";
		this.hardness 			= 2 * 20;
		this.maxStack 			= 64;
		this.dropsItself 		= true;
		this.smeltable 			= true;
		this.smeltedResult 		= new CraftingResult("sulfur", 1);
		this.toolTypeRequired 	= ToolType.PICKAXE;
		this.miningLevel		= MiningLevel.IRON;
	}
}
