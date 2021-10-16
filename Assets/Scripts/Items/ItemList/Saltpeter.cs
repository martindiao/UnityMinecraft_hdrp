public class Saltpeter: Item
{
    public Saltpeter()
    {
        this.itemName 				= "saltpeter";
		this.itemTextureName 		= "saltpeter";
		this.placeable				= false;
		this.placeableOnlyOnTop 	= false;
		this.placeableOnOtherItems 	= false;
		this.hasGenericMesh			= true;
		this.burnable				= true;
		this.burnTime			 	= 50;
		this.LoadPrefab();
    }
}
