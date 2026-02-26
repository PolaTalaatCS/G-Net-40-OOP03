using static G_Net_40_OOP03.Ticket;
using static G_Net_40_OOP03.Ticket.standardticket;

namespace G_Net_40_OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1 
            // a) compsotion
            // b) association
            // c) inheritance
            // d) aggregation
            // e) dependency
            #endregion
            #region Question 2
            // a)) yes Can a child class in a different assembly access it , No, you can’t access it using an object from outside.

            // b))protected internal is same assembly or derived class in another assembly,private protected is only derived classes inside the same assembly

            //c))sealed class is cannot be inherited,sealed method is cannot be overridden again

            //d)))yes you can create an object from a sealed class using new sealed only prevents inheritance not creation
            #endregion
            #region part 2 question 4
            Console.WriteLine("==============================cinema opened========================");
            Ticket ticket1 = new standardticket("Inception", 120, "A-5");
            Ticket ticket2 = new Vipticket("Avengers", 200, true );
            Ticket ticket3 = new Iamxticket("Dune", 180, false);
            Ticket[] tickets = { ticket1, ticket2, ticket3 };
            Projector projector1 = new Projector();
            projector1.Start();
            Console.WriteLine("===============All Tickets======================");
            for(int i = 0; i < tickets.Length; i++)
            {
                Console.WriteLine($"Ticket {i + 1} | {tickets[i].ToString()}");
            }
            Console.WriteLine("============================Statistics=================");
           Console.WriteLine($"Total Tickets: {Ticket.GetTotalTickets()}");

        }
        #endregion
    }
}
