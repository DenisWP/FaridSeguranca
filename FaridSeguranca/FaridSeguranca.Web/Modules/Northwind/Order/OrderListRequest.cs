using Serenity.Services;

namespace FaridSeguranca.Northwind
{
    public class OrderListRequest : ListRequest
    {
        public int? ProductID { get; set; }
    }
}