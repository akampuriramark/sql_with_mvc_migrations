namespace MVCLibrary.Models
{
    public class Book
    {
        // Identifier of the book in the library
        public int BookID { get; set; }
        //Name of the book
        public string Title { get; set; }
        // Location of the book in the library
        public string CallNumber { get; set; }
        //Book author
        public string Author { get; set; }
    }
}
