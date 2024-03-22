namespace Mission11__Barlocker.Models;

public interface IDataRepo
{
    List<Book> Books { get; }
    public List<Book> GetBooks(int pageNumber, int pageSize);
}