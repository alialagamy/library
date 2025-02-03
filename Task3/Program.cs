namespace Task3
{
    public class Book
    {
        string Title;
        string Author;
        string ISBN;
        bool Availability;

        public Book(string title = "none", string author = "none" , string isbn = "none")
        {
            this.Title = title;
            this.Author = author;
            this.ISBN = isbn;
            this.Availability = true;
        }
        public string gettitle() {return Title;}
        public string getauthor() {return Author;}
        public string getISBN() {return ISBN;}
       
    }
    public class Library
    {
        List<Book> books = new List<Book>();
        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("Book added successfully.");
        }
        public void SearchBook(string title)
        {
            
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            // Adding books to the library
            library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565"));
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084"));
            library.AddBook(new Book("1984", "George Orwell", "9780451524935"));

            // Searching and borrowing books
            Console.WriteLine("Searching and borrowing books...");
            library.BorrowBook("Gatsby");
            library.BorrowBook("1984");
            library.BorrowBook("Harry Potter"); // This book is not in the library

            // Returning books
            Console.WriteLine("\nReturning books...");
            library.ReturnBook("Gatsby");
            library.ReturnBook("Harry Potter"); // This book is not borrowed

            Console.ReadLine();
        }
    }
}
