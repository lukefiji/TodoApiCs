using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// A model is a set of classes that represent the data that the app manages
namespace TodoApiCs.Models
{
    // The model for this app is a single TodoItem class
    public class TodoItem
    {
        public long Id { get; set; } // Database key
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
