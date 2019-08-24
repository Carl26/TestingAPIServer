using System;

namespace ServerApi.Models
{
    public class Detail
    {
        public DateTime RecordTime { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
    }
}