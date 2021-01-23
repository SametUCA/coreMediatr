using System;

namespace coreMediatr.Models
{
    public class Creator
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatingTime { get; set; }
    }
}