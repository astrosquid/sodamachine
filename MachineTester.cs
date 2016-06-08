using System;

public class MachineTester
{
	static public void Main()
	{
		Coin quarter = new Coin( 25 );
		System.Console.WriteLine( quarter.getValue() );
	}
}
