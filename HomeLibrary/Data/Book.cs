namespace HomeLibrary.Data
{
    public class Book
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Author { get; set; }
        public required string Genre { get; set; }
        public required string Path { get; set; }
    }
}

