using System.Collections.Generic;

namespace StreamOneOrderService.Domain
{
    public class CustomerOrder
    {
        public string CustomerKey { get; set; }
        
        /// <summary>
        /// Gets or sets the company name
        /// </summary>
        public string CompanyName { get; set; }
        public List<Order> Orders { get; set; }
        public int currentPageNumber { get; set; }
        public int TotalOrdersCount { get; set; }
    }
}
