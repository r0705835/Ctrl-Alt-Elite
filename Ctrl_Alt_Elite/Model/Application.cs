using System;
using System.Collections;
public class SamplesArrayList
{

    public static void Main()
    {
        // Creates and initializes a new ArrayList.
        ArrayList ProductScoring = new ArrayList();
        ProductScoring.Add("100%-80%  +1  ");
        ProductScoring.Add("79%-60%  +2  ");
        ProductScoring.Add("59%-40%  +3   ");
        ProductScoring.Add("39%-20%  +4  ");
        ProductScoring.Add("19%-0%  +5  ");

        // Creates and initializes a new ArrayList.
        ArrayList ProductNames = new ArrayList();
        ProductNames.Add("Plantains");
        ProductNames.Add("Apples");
        ProductNames.Add("Milk Cartons");
        ProductNames.Add("Sweets(Paper/Cardboard Package)");

        // Creates and initializes a new Queue.
        Queue RewardPerPerc = new Queue();
        RewardPerPerc.Enqueue("+3 ");
        RewardPerPerc.Enqueue("+2 ");
        RewardPerPerc.Enqueue("+4 ");
        RewardPerPerc.Enqueue("+4 ");

        // Displays the ArrayList and the Queue.
        Console.WriteLine("Eco-Coin Rating pre Percentage:");
        PrintValues(ProductNames, '\t');

        // Displays the ArrayList and the Queue.
        Console.WriteLine("Selected Eco-Products:");
        PrintValues(ProductNames, '\t');
        Console.WriteLine("Reward amounts per plastic percentage:");
        PrintValues(RewardPerPerc, '\t');



        // Copies the Queue elements to the end of the ArrayList.
        ProductNames.AddRange(RewardPerPerc);

        // Displays the ArrayList.
        Console.WriteLine("The Total accumilation is as:");
        PrintValues(ProductNames, '\t');
    }

    public static void PrintValues(IEnumerable myList, char mySeparator)
    {
        foreach (Object obj in myList)
            Console.Write("{0}{1}", mySeparator, obj);
        Console.WriteLine();
    }
}


/*
This code produces the following output.

Eco-Coin Rating pre Percentage:
100%-80%  +1      79%-60%  +2      59%-40%  +3      39%-20%  +4      19%-0%  +5

Selected Eco-Products:
    Plantains    Apples    Milk Cartons    Sweets(Paper/Cardboard Package)
Reward amounts per plastic percentage:
    +3            +2           +4                         +4    
The ArrayList now contains the following:
    Plantains Apples Milk Cartons Sweets(Paper/Cardboard Package) +3 +2 +4 +4
*/
