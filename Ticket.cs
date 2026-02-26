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

    }

}
