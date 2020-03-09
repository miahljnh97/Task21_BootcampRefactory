using System;
namespace MerchantService.Model
{
    public class Merchant
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public double rating { get; set; }
        public DateTime created_at { get; set; } = DateTime.Now;
        public DateTime update_at { get; set; } = DateTime.Now;
    }

    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
    }

    public class RequestData<T>
    {
        public Data<T> data { get; set; }
    }

    public class Data<T>
    {
        public T attributes { get; set; }
    }
}
