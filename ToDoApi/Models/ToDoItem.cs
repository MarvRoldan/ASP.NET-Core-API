using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApi.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public int Task { get; set; }
        public int Completed { get; set; }     
    }
}
