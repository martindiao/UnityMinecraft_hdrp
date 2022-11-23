public class Dirt: Block
{
    public Dirt(): base()
	{
		this.blockName = "dirt";
		this.hardness = 1 * 20;
		this.maxStack = 64;
		this.soundType = BlockSoundType.DIRT;
	}
}
