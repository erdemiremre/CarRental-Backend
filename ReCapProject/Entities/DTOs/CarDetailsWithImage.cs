using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailsWithImage
    {
        public int CarId { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public string Model { get; set; }
        public short ModelYear { get; set; }
        public List<string> ImagePath { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
