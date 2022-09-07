// using System;
 
// class DoLoop
// {
//     public static void Main()
//     {
//     string myChoice;

//     do
//     {
//         Console.WriteLine("My Address Book\n");

//         Console.WriteLine("A - Add New Address");
//         Console.WriteLine("D - Delete Address");
//         Console.WriteLine("M - Modify Address");
//         Console.WriteLine("V - View Address");
//         Console.WriteLine("Q - Quite\n");

//         Console.WriteLine("Choice (A, D, M, V, or Q): ");

//         myChoice = Console.ReadLine();

//         switch(myChoice)
//         {
//             case "A":
//             case "a":
//             Console.WriteLine("You wish to add a new address.");
//             break;
//             case "D":
//             case "d":
//             Console.WriteLine("You wish to delete an address.");
//             break;
//             case "M":
//             case "m":
//             Console.WriteLine("You wish to modify an address.");
//             break;
//             case "V":
//             case "v":
//             Console.WriteLine("You wish to view an address.");
//             break;
//             case "Q":
//             case "q":
//             Console.WriteLine("Bye.");
//             break;
//             default:
//             Console.WriteLine("{0} is not a valid choice", myChoice);
//             break;
//         }
 
//         Console.Write("Press any key to continue...");
//         Console.ReadLine();
//         Console.WriteLine();
//         } while (myChoice != "Q" && myChoice != "q"); 
//     }
// }



// using System;
 
// class WhileLoop
// {
//     public static void Main()
//     {
//         int myInt = 0;
 
//         while (myInt <10)
//         {
//             Console.Write ("{0} ", myInt);
//             myInt++;
//         }
//         Console.WriteLine();
//     }
// }

using System;
 
class ForEachLoop
{
public static void Main()
{
string[] names = {"Cheryl", "Joe", "Matt", "Robert"};
 
foreach (string person in names)
{
  Console.WriteLine("{0}", person);
}
}
}

