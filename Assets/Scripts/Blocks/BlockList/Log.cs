using System.Collections;
using System.Linq;
using UnityEngine;

public class Log: Block
{
    public Log(): base()
	{
		this.blockName 			= "log";
		this.textureName 		= "oak_log";
		this.hardness 			= 3 * 20;
		this.hasSidedTextures 	= true;
		this.burnable 			= true;
		this.burnTime 			= 300;
		this.smeltable 			= true;
		this.smeltedResult 		= new CraftingResult("charcoal", 1);
		this.soundType			= BlockSoundType.WOOD;
		this.toolTypeRequired	= ToolType.AXE;
	}
	public override Vector3? Place()
	{
		Vector3? placementCoords = base.Place();

		if (placementCoords == null)
			return null;

		ChunkPosition position 		= Player.instance.GetVoxelChunk();
		Chunk chunk 				= PCTerrain.GetInstance().chunks[position];

		//Do stuff

		return placementCoords;
	}
}
