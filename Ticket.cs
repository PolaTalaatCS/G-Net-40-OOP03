using System;
using System.Collections.Generic;
using System.Linq;
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
            get { return price; } set
            {
                if (value > 0)
                {
                    price = value;
                }
            }
        }
        public int Ticketid { 
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
        static int GetTotalTickets()
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
                private  bool laungeaccess;
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
            public class imaxticket : Ticket
            {
                private string screen;
                static decimal imaxfee = 30;
                public string Screen { get; set; }
                public imaxticket(string _moviename, decimal _price, string _screen) : base(_moviename, _price)
                {
                    screen = _screen;
                }
                public override string ToString()
                {
                    return base.ToString() + $", Screen: {screen}, IMAX fee: {imaxfee}";
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

    }

}
