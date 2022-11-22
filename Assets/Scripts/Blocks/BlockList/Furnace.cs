public class Furnace: Block
{
    public Furnace(): base()
	{
		this.blockName 			= "furnace";
		this.hasSidedTextures 	= true;
		this.interactable 		= true;
		this.hardness 			= 6 * 20;
		this.stateful 			= true;
		this.anyToolRequired 	= true;
		this.toolTypeRequired	= ToolType.PICKAXE;
	}

	public override void Interact()
	{
		base.Interact();

		MineCraftGUI.ShowFurnaceUI();
	}
}
