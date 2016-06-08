

public class Soda
{
	private String name;
	private int cost;

	public Soda(String newName, int newCost)
	{
		name = newName;
		cost = newCost;
	}

	public String getName()
	{
		return name;
	}

	public int getCost()
	{
		return cost;
	}

	public int setCost(int newCost)
	{
		cost = newCost;
	}

}
