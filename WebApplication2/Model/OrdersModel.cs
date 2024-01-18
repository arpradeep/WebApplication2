using System.Security.Principal;

namespace WebApplication2.Model
{
    public class OrdersModel
    {
     public int   ORDERID { get; set; }
     public string   CUSTOMERID { get; set; }
     public DateTime ORDERDATE { get; set; }
     public DateTime DELIVERYEXPECTED { get; set; }
     public string CONTAINSGIFT { get; set; }

    }
}
