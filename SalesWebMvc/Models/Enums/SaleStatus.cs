using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models.Enums
{
    public enum SaleStatus : int
    {
        PEDDING = 0,
        BILLED = 1,
        CANCELED = 2
    }
}
