namespace Mission11__Barlocker.Models;

public class EFDataRepo : IDataRepo
{
    private DataContext _context;
    public EFDataRepo(DataContext temp) 
    { 
        _context = temp;
    }
    public List<Book> Books => _context.Books.ToList();
    public List<Book> GetBooks(int pageNumber, int pageSize)
    {
        return _context.Books
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToList();
    }
}