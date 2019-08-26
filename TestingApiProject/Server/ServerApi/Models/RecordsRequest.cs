using System;

namespace ServerApi.Models
{
    public class RecordsRequest 
    {
        public int UserId { get; set; }
        public DateTime ByDate { get; set; }
        public Detail Record { get; set; }
    }
}