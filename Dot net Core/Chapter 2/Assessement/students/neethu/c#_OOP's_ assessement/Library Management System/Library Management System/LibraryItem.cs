using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public abstract class LibraryItem
    {
        private string itemId;
        private string title;
        private bool isavailable;

        public string ItemId { get { return itemId; } }

        public string Title { get { return title; } }
        public bool IsAvailable { get { return isavailable; } }

        public LibraryItem(string itemId, string title, bool isavailable)
        {
            this.itemId = itemId;
            this.title = title;
            this.isavailable = isavailable;
        }
        public string GetItemId()
        {
            return itemId;
        }
        public string GetTitle()
        {
            return title;
        }
        public bool GetIsAvailable()
        {
            return isavailable;
        }
        public void BorrowItem()
        {
            if(isavailable)
            {
                isavailable = false;
            }
            else
            {
                Console.WriteLine("Item is not available");
            }
        }
        public void ReturnItem()
        {
            isavailable= true;

        }
        public abstract string GetItemType(LibraryItem item);
        
           
    }
}
