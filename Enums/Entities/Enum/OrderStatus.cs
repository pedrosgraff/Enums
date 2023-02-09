using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums.Entities.Enum
{
    enum OrderStatus : int
    {
        Pending_Payment = 0,
        Processing = 1,
        Shipping = 2,
        Delivered = 3
    }
}
