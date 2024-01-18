using System.IO;
using System.Security.Principal;

namespace WebApplication2.Model
{
    public class CustomersModel
    {
        private int CUSTOMERID { get; set; }
        private string FIRSTNAME{ get; set; }
        private string LASTNAME { get; set; }
        private string EMAIL { get; set; }
        private string HOUSENO { get; set; }
        private string STREET { get; set; }
        private string TOWN { get; set; }
        private string POSTCODE { get; set; }
    }
   
}