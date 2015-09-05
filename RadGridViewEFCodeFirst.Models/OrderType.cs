using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadGridViewEFCodeFirst.Models
{
    public class OrderType
    {
        private ICollection<Order> orders;

        public OrderType()
        {
            this.orders = new HashSet<Order>();
        }

        public int OrderTypeId { get; set; }

        public virtual ICollection<Order> Orders
        {
            get
            {
                return this.orders;
            }
            set
            {
                this.orders = value;
            }
        }

        public string  Description { get; set; }
    }
}
