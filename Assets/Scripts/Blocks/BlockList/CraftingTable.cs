using System.Collections.Generic;

public class CraftingTable: Block
{
    public CraftingTable(): base()
	{
		this.blockName 			= "craftingTable";
		this.textureName 		= "crafting_table";
		this.hasSidedTextures 	= true;
		this.interactable 		= true;
		this.hardness 			= 3 * 20;
		this.soundType 			= BlockSoundType.WOOD;
		this.toolTypeRequired	= ToolType.AXE;
	}

	public override void Interact()
	{
		base.Interact();

		MineCraftGUI.ShowCraftingTableUI();
	}
}
