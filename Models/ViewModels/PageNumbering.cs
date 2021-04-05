using System;
namespace BowlingLeague.Models.ViewModels
{
    //This class just takes care of the page numbering
    public class PageNumbering
    {
        public decimal NumItemsPerPage { get; set; }

        public int CurrentPage { get; set; }

        public int TotalItems { get; set; }

        //Calculate the Number of Pages. By declaring (decimal) before something that was an int orginally it changes it. This is called casting. 
        //Good concept ^^ though I ended up changing it a bit as I was having a bug.
        public int NumPages => (int)(Math.Ceiling(TotalItems / NumItemsPerPage));
    }
}
