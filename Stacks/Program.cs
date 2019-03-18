using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{

    public static void Main()
    {

        // Creates and initializes a new Stack.
        Stack s1 = new Stack();
        s1.Push("Hello");
        s1.Push("World");
        s1.Push("!");


        //Task 2
        while (s1.Peek().ToString() == "World")
        {
            s1.Pop();

        }

        /*Using the Count property to veiw the number of elements in the stack*/
        Console.WriteLine("\n... Count ...");
        Console.WriteLine("Count: " + s1.Count);

        /*Using Peek to view the stacks contents*/
        Console.WriteLine("\n ... Peek ...");
        Console.WriteLine("Top item: " + s1.Peek() + "\nCount: " + s1.Count);

        /*Using Pop to use and remove the top object*/
        Console.WriteLine("\n ... Pop ...");
        Console.WriteLine("Top item: " + s1.Pop() + "\nCount: " + s1.Count);
        Console.WriteLine("Top item: " + s1.Pop() + "\nCount: " + s1.Count);
        Console.WriteLine("Top item: " + s1.Pop() + "\nCount: " + s1.Count);


        //Task 3
        Console.WriteLine();

        Stack s2 = new Stack();
        Console.Write("Please enter a string: ");
        string input = Console.ReadLine();
        //s1.Push(Console.ReadLine());

        foreach (char x in input)
            s2.Push(x);
        int size = s2.Count;
        for (int i = 0; i < size; i++)
            Console.WriteLine(s2.Pop());
        Console.WriteLine();
    }

}