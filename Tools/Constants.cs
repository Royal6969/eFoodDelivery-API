namespace eFoodDelivery_API.Tools
{
    public static class Constants
    {
        public const string SD_STORAGE_CONTAINER = "efooddeliveryimagenes";
        
        public const string ROLE_ADMIN = "admin";
        public const string ROlE_CUSTOMER = "customer";

        public const string STATUS_PENDING = "Pending";                     // initially the status will be pending
        public const string STATUS_CONFIRMED = "Confirmed";                 // once the payment is done, it will be confirmed
        public const string STATUS_BEING_COOKED = "Being Cooked";           // then when chef is cooking it will be being cook
        public const string STATUS_READY_FOR_PICKUP = "Ready for pickup";   // after it is done, it will be ready for pick up
        public const string STATUS_COMPLETED = "Completed";                 // and once it's picked up it will be completed
        public const string STATUS_CANCELLED = "Cancelled";                 // at any time they can cancel the order and status will be updated to cancelled
    }
}
