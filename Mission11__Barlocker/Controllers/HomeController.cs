using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission11__Barlocker.Models;

namespace Mission11__Barlocker.Controllers;

public class HomeController : Controller
{
    private IDataRepo _repo;
    private const int PageSize = 10;

    public HomeController(IDataRepo repo)
    {
        _repo = repo;
    }
    public IActionResult Index(int pageNumber = 1)
    {
        var books = _repo.GetBooks(pageNumber, PageSize);
        
        var totalBooksCount = _repo.Books.Count;
        var totalPages = (int)Math.Ceiling((double)totalBooksCount / PageSize);

        ViewBag.PageNumber = pageNumber;
        ViewBag.TotalPages = totalPages;
        ViewBag.HasPreviousPage = pageNumber > 1;
        ViewBag.HasNextPage = pageNumber < totalPages;
        
        return View(books);
    }
}