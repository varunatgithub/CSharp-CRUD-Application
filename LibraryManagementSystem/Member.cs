namespace LMS
{
  public class Member
  {
    public string MemberId { get; }
    public string Name { get; set; }


    public List<Book> borrowedBooks=new List<Book>();
    public string GetMemberId()
    {
      return Guid.NewGuid().ToString();
    }

    public Member(string name)
    {
      MemberId=GetMemberId();
      Name=name;
    }

    public void BorrowBook(Book book)
    {
      book.IsAvailable=false;
      borrowedBooks.Add(book);
      
    }

    public void ReturnBook(Book book)
    {
      book.IsAvailable=true;
      borrowedBooks.Remove(book);
    }

    public List<Book> GetBorrowedBooks()
    {
      var memBorrowedBooks=borrowedBooks.ToList();
      return memBorrowedBooks;
    }

  }
}