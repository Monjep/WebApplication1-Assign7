using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Note
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Notes { get; set; }

        public DateTime CreatedOn { get; set; }

        public int CategoryId { get; set; }

        public int UserId { get; set; }

        public bool IsDeleted { get; set; }

        public Category Category { get; set; }

        public User User { get; set; }
    }
}