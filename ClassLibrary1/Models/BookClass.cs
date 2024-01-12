using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    internal class BookClass
    {
        public string bookcode { get; set; }
        public string name { get; set; }   
        public string writer { get; set; } 
        public string Subject { get; set; } 
        public string publishers { get; set; }  
        public  DateTime yearOfPublication { get; set; }
        public string edition { get; set; }
    }
}
