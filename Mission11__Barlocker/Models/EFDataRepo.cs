namespace Mission11__Barlocker.Models;

public class EFDataRepo : IDataRepo
{
    private DataContext _context;
    public EFDataRepo(DataContext temp) 
    { 
        _context = temp;
    }
    
    public List<Book> Books => _context.Books.ToList();
}