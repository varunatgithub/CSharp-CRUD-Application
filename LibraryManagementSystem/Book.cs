namespace LMS
{
  public class Book
  {
    public string BookId { get; }
    public string Title { get; set; }
    public string Author { get; set; }
    public bool IsAvailable { get; set; }

    public string GetBookId()
    {
      return Guid.NewGuid().ToString();
    }

    public Book(string _title,string _author,bool _isAvailable)
    {
      BookId=GetBookId();
      Author=_author;
      Title=_title;
      IsAvailable=_isAvailable;
    }

    public void UpdateAvailability(bool isAvailable)
    {
      IsAvailable=isAvailable;
    }

    
  }
}