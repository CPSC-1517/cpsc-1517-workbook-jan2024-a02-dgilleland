using WestWindWholesale.DAL;
using WestWindWholesale.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore; // for the .Include

namespace WestWindWholesale;

public class ProductServices
{
    private readonly WestWindContext _context;
    internal ProductServices(WestWindContext context)
    {
        _context = context;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public List<Product> GetProductsByCategoryId(int id)
    {
        return _context.Products
            .Include(p => p.Supplier)
            .Where(p => p.CategoryId == id)
            .ToList<Product>();
    }

    public List<Product> GetProducts()
    {
        return _context.Products
            .Include(p => p.Supplier)
            .Include(p => p.Category)
            .ToList();
    }
}
