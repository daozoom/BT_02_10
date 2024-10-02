using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_02_10
{
    // Interface ISellable
    public interface ISellable
    {
        void Sell(int quantity);
        bool IsInStock();
    }
}
