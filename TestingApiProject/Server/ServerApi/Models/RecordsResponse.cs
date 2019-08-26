using System.Collections.Generic;

namespace ServerApi.Models
{
    public class RecordsResponse
    {
        public int UserId { get; set; }
        public IList<Detail> Details { get; set; }
    }
}