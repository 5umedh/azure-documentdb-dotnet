using System;

namespace StreamOneOrderService.Domain
{
    public class Entitlement
    {
        /// <summary>
        ///     Sales Order Number
        /// </summary>
        public string SalesOrder { get; set; }
        /// <summary>
        ///     Order Date
        /// </summary>
        public DateTime OrderDate { get; set; }
        /// <summary>
        ///     Product's SKU
        /// </summary>
        public string SKU { get; set; }
        /// <summary>
        ///     Product's Name
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        ///     Line Item's number
        /// </summary>
        public int LineNumber { get; set; }
        /// <summary>
        ///     Domain Name
        /// </summary>
        public string Domain { get; set; }
        /// <summary>
        ///     CSP Status
        /// </summary>
        public string CSPStatus { get; set; }
        /// <summary>
        ///     CSP Error
        /// </summary>
        public string CSPError { get; set; }
        /// <summary>
        ///     Reseller Name
        /// </summary>
        public string Reseller { get; set; }
        /// <summary>
        ///     End Customer's Name
        /// </summary>
        public string EndCustomer { get; set; }
    }

    /// <summary>
    ///     Sorting Field Column Enum
    /// </summary>
    public enum SortingField
    {
        SalesOrder = 1,
        OrderDate = 2,
        SKU = 3,
        ProductName = 4,
        LineNumber = 5,
        Domain = 6,
        CSPStatus = 7,
        CSPError = 8,
        Reseller = 9,
        EndCustomer = 10
    }
}
