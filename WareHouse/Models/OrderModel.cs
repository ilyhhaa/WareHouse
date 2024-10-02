namespace WareHouse.Models
{
    public class OrderModel
    {
        public Guid Id { get; set; }

        public string CustomerName { get; set; }

        public string ServiceType { get; set; }

        public DateTime OrderDate { get; set; }

        public string CustomerPhoneNumber { get; set; }

        public int CargoWeight { get; set; }

        public Guid StorageId { get; set; }

        public StorageModel Storage { get; set; }


    }
}
