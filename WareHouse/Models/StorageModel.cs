namespace WareHouse.Models
{
    public class StorageModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
        public int AvailableCapacity { get; set; }
        public string ContactInfo { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
