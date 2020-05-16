using System;
using System.Collections;
public class SamplesArrayList
{

    public static void Main()
    {

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
        RewardPerPerc.Enqueue("+4");
        RewardPerPerc.Enqueue("lazy");
        RewardPerPerc.Enqueue("dog");

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

Selected Eco-Products:
    The    quick    brown    fox
Reward amounts per plastic percentage:
    jumps    over    the    lazy    dog
The ArrayList now contains the following:
    The    quick    brown    fox    jumps    over    the    lazy    dog
*/
