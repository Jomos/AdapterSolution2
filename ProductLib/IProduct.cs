using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLib
{
    interface IProduct
    {
        string Title { get; }
        string BarCode { get; }
        decimal UnitPrice { get; }
    }
}
