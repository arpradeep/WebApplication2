using Microsoft.AspNetCore.DataProtection.KeyManagement;
using System.Security.Cryptography.Xml;
using System.Security.Principal;

namespace WebApplication2.Model
{
    public class OrderItemsModel
    {
     public int   ORDERITEMID { get; set; }

        public int ORDERID { get; set; }
        public int PRODUCTID { get; set; }
        public int QUANTITY { get; set; }
        public  decimal PRICE { get; set; }

    }
}
