using System.Collections.Generic;

namespace ServerApi.Models
{
    public class GetDetailsResponse
    {
        public int UserId { get; set; }
        public List<Detail> Details { get; set; }
    }
}