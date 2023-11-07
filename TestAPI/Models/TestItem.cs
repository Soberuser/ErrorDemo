

using Newtonsoft.Json;

namespace TestAPI.Models
{
    public class TestItem
    {
    }
    public class Customer
    {
        public ulong Id { get; set; }
        public string? Name { get; set; }
        //[JsonIgnore]
        public List<Manager> Managers { get; set; } = new List<Manager>();
    }

    public class Manager
    {
        public ulong Id { get; set; }
        public string? Name { get; set; }
        [JsonIgnore]
        public List<Customer> Customers { get; set; } = new List<Customer>();
    }
}
