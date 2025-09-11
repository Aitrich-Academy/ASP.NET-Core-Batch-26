using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class DVD:LibraryItem
    {
        public int Duration { get; set; }

        private string Type = "DVD";
        
        public DVD(string itemid,string title,bool isavailable,int duration):base(itemid,title,isavailable)
        {
            Duration = duration;
        }
        public override string GetItemType(LibraryItem item)
        {
            return Type;
        }

    }
}
