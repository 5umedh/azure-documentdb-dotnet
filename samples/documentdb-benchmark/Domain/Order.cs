using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace StreamOneOrderService.Domain
{
    public class Order : ICloneable
    {
        /// <summary>
        /// Gets the Order Unique Instance Identifier
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets the order business identifier (for example Service Order number SO#)
        /// </summary>
        public string OrderKey { get; set; }

        /// <summary>
        /// Reseller Business Identifier
        /// </summary>
        [JsonProperty("resellerKey")]
        public string ResellerKey { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        /// <summary>
        /// Gets  or sets  the order status
        /// </summary>
        public OrderStatusEnum  OrderStatus { get; set; }

        /// <summary>
        /// Gets or sets the order PO Number
        /// </summary>
        public string PONumber { get; set; }

        /// <summary>
        /// Gets or Sets the products
        /// </summary>
        public List<OrderLine> OrderLines { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        /// <summary>
        /// Gets or Sets the subscriptions
        /// </summary>
        public List<Subscription> Subscriptions { get; set; }
        /// <summary>
        /// Gets or Sets the Provisioned Date
        /// </summary>
        public DateTime ProvisionedOnUtc { get; set; }

        /// <summary>
        /// Gets or sets the date and time of product creation
        /// </summary>
        public DateTime CreatedOnUtc { get; set; }

        /// <summary>
        /// Gets or sets the date and time of product update
        /// </summary>
        public DateTime UpdatedOnUtc { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        /// <summary>
        /// Gets or sets CreatedBy 
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets UpdatedBy
        /// </summary>
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Payment method type from paymentMethod model
        /// </summary>
        public PaymentMethodTypeEnum? PaymentMethodType { get; set; }

        public string CardId { get; set; }
    }

    public enum PaymentMethodTypeEnum
    {
        TestStatus = 0, // dummy status for the purpose of data fix
        Terms = 1,
        FloorPlanning = 2,
        CreditCard = 3
    }

    public class ProvisionSettings
    {
        /// <summary>
        ///     gets or sets product Settings 
        /// </summary>
        public Setting ProductSettings { get; set; }
        /// <summary>
        ///     gets or sets customer Settings 
        /// </summary>
        public Setting CustomerSettings { get; set; }
        /// <summary>
        ///     gets or sets reseller Settings 
        /// </summary>
        public Setting ResellerSettings { get; set; }
    }

    public class Setting
    {
        /// <summary>
        ///     Key to the template with which User inputted his/her values
        /// </summary>
        public string TemplateKey { get; set; }
        /// <summary>
        ///     Actual QA depending upon template and the user's values
        /// </summary>
        public IDictionary<string, string> Settings { get; set; }
    }

    public class OrderLine : ProvisionSettings
    {
        /// <summary>
        ///     Gets the order Unique Instance Identifier. Similar to StreamOne EntitlementId
        /// </summary>
        public string OrderLineId { get; set; }
        /// <summary>
        /// Gets or Sets Parent Config Key
        /// </summary>
        public string ParentConfigKey { get; set; } // for TNG internal only

        /// <summary>
        /// Gets or Sets Vendor Config Key of Addon product
        /// </summary>
        public string VendorProductConfigKey { get; set; } //for Provisioning only 

        public string VendorSubscriptionDisplayName { get; set; }

        /// <summary>
        /// Product's Name
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// Gets or sets the product business key ex SKU 11111
        /// </summary>
        public string ProductKey { get; set; }

        /// <summary>
        /// Gets or sets the Vendor business key ex SKU 11111
        /// </summary>
        public string VendorKey { get; set; }

        /// <summary>
        /// Gets the product config Id
        /// </summary>
        public string ProductConfigKey { get; set; }

        /// <summary>
        /// Gets or sets the product quantity
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        ///  Get or sets the price
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the customer business kkey ex Customer_1234
        /// </summary>
        public string CustomerKey { get; set; }

        public string CustomerContactId { get; set; }

        /// <summary>
        /// Gets or sets the customer domain   
        /// </summary>
        public string CustomerDomainPrefix { get; set; }  // This is applicable only for Microsoft Orders

        /// <summary>
        /// Gets the customer Unique Instance Identifier
        /// </summary>
        public string CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the company name
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or sets the first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the phone number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the email address 
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the address line1 
        /// </summary>
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Gets or sets the address line2 
        /// </summary>
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Gets or sets the city 
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the state 
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the Country 
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the zip code
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        ///     Gets or sets the subscription Id provided by Vendor 
        /// </summary>
        public string VendorSubscriptionId { get; set; }

        /// <summary>
        ///     Gets or sets the EntitlementId ( TNG Subscription ID )
        /// </summary>
        public string EntitlementId { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        /// <summary>
        ///     Gets the Product Provision Type
        /// </summary>
        public ProductProvisionTypeEnum ProductProvisionType { get; set; }

        public VendorProvisionResponse VendorProvisionResponse { get; set; }

        public DateTime ProvisionedOnUtc { get; set; }

        /// <summary>
        /// Gets or sets the date and time of product creation
        /// </summary>
        public DateTime CreatedOnUtc { get; set; }

        /// <summary>
        /// Gets or sets the date and time of product update
        /// </summary>
        public DateTime UpdatedOnUtc { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        /// <summary>
        /// Gets  or sets  the order status
        /// </summary>
        public OrderLineStatusEnum OrderLineStatus { get; set; }
        /// <summary>
        /// Gets or sets product promotion applied in cart
        /// </summary>
        public CartProductPromotion CartProductPromotion { get; set; }

        /// <summary>
        ///     Gets the order Unique Instance Identifier. Similar to StreamOne EntitlementId
        /// </summary>
        public string ParentOrderLineId { get; set; }

        /// <summary>
        ///     Gets or sets the subscription Id provided by Vendor 
        /// </summary>
        public string ParentVendorSubscriptionId { get; set; }

        /// <summary>
        ///     Gets or sets billing frequency
        /// </summary>
        public ProductBillingFrequencyEnum? BillingFrequency { get; set; }

        /// <summary>
        ///     Gets or sets billing type
        /// </summary>
        public ProductBillingTypeEnum? BillingType { get; set; }
    }

    public enum UnitTypeEnum
    {
        Seat = 1,
        GigaByte = 2,
        Account = 3
    }

    public enum ProductBillingTypeEnum
    {
        Subscription = 1,
        Consumption = 2,
        Download = 3
    }

    public enum ProductBillingFrequencyEnum
    {
        Monthly = 1,
        Yearly = 2,
        OneTime = 3
    }

    public enum TermsAndConditionTypeEnum
    {
        Vendor = 1,
        ResellerMarketplace = 2,
        VendorMarketplace = 3
    }

    public enum ProductTagEnum
    {
        SaaS = 1,
        IaaS = 2,
        PaaS = 3
    }

    /// <summary>
    ///     Cart's Product Promotion details
    /// </summary>
    public class CartProductPromotion
    {
        public CartProductCrossSellConfiguration CartProductCrossSellConfiguration { get; set; }
        public CartProductUpSellConfiguration CartProductUpSellConfiguration { get; set; }
    }

    /// <summary>
    ///     Product's Up Sell Configuration if applied in cart
    /// </summary>
    public class CartProductUpSellConfiguration
    {
        public int DiscountApplied { get; set; }
    }

    /// <summary>
    ///     Product's Cross Sell Configuration if applied in cart
    /// </summary>
    public class CartProductCrossSellConfiguration
    {
        public string CrossSellAppliedFromProductConfigKey { get; set; }
        public float OriginalPrice { get; set; }
    }

    public class VendorProvisionResponse
    {
        public string ProvisionStatus { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
    
    public enum ProductProvisionTypeEnum
    {
        //TODO will add more status later
        EndUser = 1,
        Reseller = 2,
        All = 3
    }

    public enum OrderStatusEnum
    {
        //TODO will add more status later
        InProgress = 1,
        Completed = 2,
        Failed = 3
    }

    public enum OrderLineStatusEnum
    {
        //TODO will add more status later
        TestStatus =0, //ading this for a data fix
        InProgress = 1,
        ProvisionSuccess = 2,
        ProvisionFailure = 3
    }

}
