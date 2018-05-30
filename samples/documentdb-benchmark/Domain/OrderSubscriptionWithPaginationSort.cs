using System.Collections.Generic;

namespace StreamOneOrderService.Domain
{
    public class OrderSubscriptionWithPaginationSort
    {    
        /// <summary>
        /// Gets or sets draw
        /// </summary>
        public int Draw { get; set; }

        /// <summary>
        /// Gets or sets Records Total
        /// </summary>
        public int RecordsTotal { get; set; }

        /// <summary>
        /// Gets or sets Records Filtered 
        /// </summary>
        public int RecordsFiltered { get; set; }

        /// <summary>
        /// Gets or sets Subscription
        /// </summary>
        public List<Subscription> Data{ get;set;} 
    }

}
