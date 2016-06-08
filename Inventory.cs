

static public class Inventory
{
	static private ArrayList<Soda> inventory;


	static public void init()
	{
		inventory = new ArrayList<Soda>{};
		Soda filler = new Soda("Coke", 175);
		inventory.put(filler);
	}

	static public int checkInventory()
	{
		
	}
}
