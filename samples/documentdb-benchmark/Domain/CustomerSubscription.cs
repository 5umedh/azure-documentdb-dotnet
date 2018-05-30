using System.Collections.Generic;

namespace StreamOneOrderService.Domain
{
    public class CustomerSubscription
    {
        public string CustomerKey { get; set; }
        public List<Subscription> Subscriptions  { get; set; }
    }

    public class CustomerDomains
    {
        /// <summary>
        /// Customer Key of Subscription
        /// </summary>
        public string CustomerKey { get; set; }
        /// <summary>
        /// Vendor Key of Subscription
        /// </summary>
        public string VendorKey { get; set; }
        /// <summary>
        /// List of domains for the vendor
        /// </summary>
        public List<string> Domains { get; set; }
    }
}
