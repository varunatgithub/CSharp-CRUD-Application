namespace LMS
{
  public class Program
  {
    static void Main(string[] args)
    {
      System.Console.WriteLine("Hello, World! welcome to Library Management System.");

      List<Book> books = new List<Book>();

      Book book1 = new Book("Rich Dad, Poor Dad", "Robert Kiyosaki", true);
      books.Add(book1);

      Book book2 = new Book("To Kill a Mockingbird", "Harper Lee", true);
      books.Add(book2);

      Book book3 = new Book("The Great Gatsby", "F. Scott Fitzgerald", true);
      books.Add(book3);

      Book book4 = new Book("1984", "George Orwell", false);
      books.Add(book4);

      Book book5 = new Book("The Catcher in the Rye", "J.D. Salinger", true);
      books.Add(book5);

      Book book6 = new Book("The Hobbit", "J.R.R. Tolkien", true);
      books.Add(book6);

      Book book7 = new Book("Pride and Prejudice", "Jane Austen", false);
      books.Add(book7);


      Library library=new Library(books);

      Member member1=new Member("Varun Reddy");
      Member member2=new Member("Harsha Reddy");

      library.BorrowBook(member1,book5);
      library.BorrowBook(member1,book6);

      System.Console.WriteLine($"{library.GetAvailableBooks().Count()}");
      System.Console.WriteLine("----------------------------");
      System.Console.WriteLine($"{library.GetBorrowedBooks(member1).Count()}");
      System.Console.WriteLine("----------------------------");
      System.Console.WriteLine($"{library.GetBorrowedBooks(member2).Count()}");
      System.Console.WriteLine("----------------------------");
      



    }
  }
}