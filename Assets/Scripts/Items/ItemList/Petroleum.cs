public class Petroleum: Item
{
    public Petroleum()
    {
        this.itemName 				= "petroleum";
		this.itemTextureName 		= "petroleum";
		this.placeable				= false;
		this.placeableOnlyOnTop 	= false;
		this.placeableOnOtherItems 	= false;
		this.hasGenericMesh			= true;
		this.burnable				= true;
		this.burnTime			 	= 50;
		this.LoadPrefab();
    }
}
