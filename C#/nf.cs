using System;
 
class WhileLoop
{
    public static void Main()
    {
        bool strFlag = true;
 
        Console.Write ("Entering the loop...Press Y to Continue, N to exit \n");
        // while (strFlag)
        do
        {
            switch ( Console.ReadLine().ToUpper()  )
            {
              case ("Y"):
                Console.Write ("Continuing in the loop \n");
              break;
 
              case "N":
                Console.Write ("Exitting the loop. Good bye.");
              strFlag = false;
              break;

              default:
                Console.Write ("Invalid entry...Please enter Y/n or N/n. \n");
              break;
 
            }            
        } while (strFlag);
    }
}





using System;
 
class ForLoop
{
    public static void Main()
    {
        for (int i=0; i < 20; i++)
        {
            if (i == 10)
                break;
            if (i % 2 ==0)
                continue;

            Console.Write("{0} ",i);
        }
        Console.WriteLine();
    }
}
