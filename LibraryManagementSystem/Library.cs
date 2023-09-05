namespace LMS
{
  public class Library
  {

    private readonly List<Book> _books;

    public Library(List<Book> books)
    {
      _books=books;
    }
    public void AddBook(Book book)
    {
      _books.Add(book);
    }

    public void RemoveBook(Book book)
    {
      _books.Remove(book);
    }
    public void BorrowBook(Member member,Book book)
    {
      member.BorrowBook(book);

    }
    public void ReturnBook(Member member,Book book)
    {
      member.ReturnBook(book);
    }

    public List<Book> GetAvailableBooks()
    {
      var getAvailableBooks=_books.Where(x=>x.IsAvailable==true).ToList();
      return getAvailableBooks;
    }

    public List<Book> GetBorrowedBooks(Member member)
    {
      var getBorrowedBooks=member.GetBorrowedBooks().ToList();
      return getBorrowedBooks;
    }
  }
}