namespace LMS
{
  /// <summary>
  /// This is a Book Class. Which Behaves as a real world book comparison.
  /// </summary>
  public class Book
  {
    public string BookId { get; }
    public string Title { get; set; }
    public string Author { get; set; }
    public bool IsAvailable { get; set; }

    //This is a Method used to assign unique BookId to each book. Which is set during a Book instatiation & cannot be modified later.
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