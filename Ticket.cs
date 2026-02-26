using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_OOP03
{
    public class Ticket
    {
        #region part 2 question 1
        private string moviename;
        private decimal price;
        private int ticketid;
        static int idcounter = 0;
        public string Movieame { get; set; }
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                {
                    price = value;
                }
            }
        }
        public int Ticketid
        {
            get
            {
                idcounter++;
                return idcounter;
            }
        }
        public Ticket(string _moviename, decimal _price)
        {
            moviename = _moviename;
            price = _price;
        }
        public decimal Priceaftertax()
        {
            return price + (price * 0.14m);
        }
        public override string ToString()
        {
            return $"Movie name: {moviename}, Price: {price}, Ticket id: {Ticketid}";
        }
       public static int GetTotalTickets()
        {
            return idcounter;
        }
        #endregion
        #region part 2 question 2
        public class standardticket : Ticket
        {
            private string seatnumber;
            public string Seatnumber { get; set; }
            public standardticket(string _moviename, decimal _price, string _seatnumber) : base(_moviename, _price)
            {
                seatnumber = _seatnumber;
            }
            public override string ToString()
            {
                return base.ToString() + $", Seat number: {seatnumber}";
            }

            public class Vipticket : Ticket
            {
                private bool laungeaccess;
                static decimal servicefee = 50;
                public bool Laungeaccess { get; set; }
                public Vipticket(string _moviename, decimal _price, bool _laungeaccess) : base(_moviename, _price)
                {
                    laungeaccess = _laungeaccess;
                }
                public override string ToString()
                {
                    return base.ToString() + $", Launge access: {laungeaccess}, Service fee: {servicefee}";
                }
            }
 
            public class Iamxticket : Ticket
            {
                private bool is3d;
                public bool iS3D { get; set; }
                public Iamxticket(string _moviename, decimal _price, bool _is3d) : base(_moviename, _price)
                {
                    is3d = _is3d;
                }
                public override string ToString()
                {
                    return base.ToString() + $" Is 3D: {is3d}";
                }
            }
            #endregion
        }
        #region Part 2 question 3
        public class Projector
        {
            public void Start()
            {
                Console.WriteLine("Projector started.");
            }

            public void Stop()
            {
                Console.WriteLine("Projector stopped.");
            }
        }
        public class Cinema
        {
            private Ticket[] tickets = new Ticket[20];

            public string CinemaName { get; set; }

            public Projector Projector { get; }

            public Cinema(string name)
            {
                CinemaName = name;
                Projector = new Projector();
            }
            public bool AddTicket(Ticket t)
            {
                for (int i = 0; i < tickets.Length; i++)
                {
                    if (tickets[i] == null)
                    {
                        tickets[i] = t;
                        return true;
                    }
                }
                return false;
            }
            public void PrintAllTickets()
            {
                foreach (var ticket in tickets)
                {
                    if (ticket != null)
                    {
                        Console.WriteLine(ticket);
                    }
                }
            }
            public void OpenCinema()
            {
                Console.WriteLine($"Cinema {CinemaName} is now open.");
                Projector.Start();
            }
            public void CloseCinema()
            {
                Console.WriteLine($"Cinema {CinemaName} is now closed.");
                Projector.Stop();
            }
        }
        #endregion

    }

}
