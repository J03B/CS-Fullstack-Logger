using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS_Fullstack_Logger.Models {
    public class Entry {
        public int Id { get; set; }
        public string? EntryTitle { get; set; }
        public string? EntryDescription { get; set; }

        public Entry() {
            
        }
    }
}