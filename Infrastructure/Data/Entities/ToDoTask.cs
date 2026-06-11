using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.Entities
{
    public class ToDoTask
    {
        public int id { get;set; }
        public string Task { get;set; } = string.Empty;

        public DateTime CreatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
