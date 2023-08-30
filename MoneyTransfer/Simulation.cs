using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTransfer
{
    internal class Simulation
    {
        public Simulation()
        {
            
        }

        public void RunSimulation()
        {
            Console.WriteLine("Starting simulation");
            Console.WriteLine();
            //TODO 5: Instantiate two Person objects, with unique names and money amounts. Two lines.

            Person userOne = new Person("Pablo", 9000);
            Person userTwo = new Person("Maria", 5000);

            
            //TODO 6: Call the .DisplayInfo() method on each person object, one at a time. This will show their initial money amount. Two lines.

            userOne.DisplayInfo();
            userTwo.DisplayInfo();
            Console.WriteLine();
            //TEST THE APPLICATION AFTER TODOS 5 AND 6!!

            //TODO 9: Call the .TransferMoney() method on one person object (giver), making sure to pass in the second person object (receiver), and the amount being transfered. One line.

            userOne.TransferMoney(userTwo, 1000);

            //TODO 10: Call the .DisplayInfo() method on each person object again, showing that each person's balance has changed. Two lines.

            userOne.DisplayInfo();
            userTwo.DisplayInfo();
            Console.WriteLine();
            Console.WriteLine("Simulation complete.");
        }
    }
}
