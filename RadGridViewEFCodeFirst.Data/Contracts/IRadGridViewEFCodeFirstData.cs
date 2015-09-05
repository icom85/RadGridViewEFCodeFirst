using RadGridViewEFCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadGridViewEFCodeFirst.Data.Contracts
{
    public interface IRadGridViewEFCodeFirstData
    {
        IGenericRepository<Order> Orders { get; }

        IGenericRepository<OrderType> OrderTypes { get; }
    }
}
