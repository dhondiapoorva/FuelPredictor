using System;
namespace FuelQuoteApp_p1.EntModels.Models
{
    public class Quote
    {
        public int Id { get; set; }
        public int GallonsRequested { get; set; }
        public string DeliveryAddress { get; set; }
        public DateTime DateRequested { get; set; }
        public float PricePerGallon { get; set; }
        public float TotalAmount { get; set; }
        public User User { get; set; }
    }
}
