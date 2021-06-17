using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Udemy.Entities.Enums
{
    //Colocando o : int, define que a estrutura do orderstatus é inteiro
    enum OrderStatus : int
    {
        //Pode-se colocar valor para eles. Se não colocar, o compilador começa do zero
        PendingPayment,
        Processing,
        Shipped,
        Delivered
    }
}
