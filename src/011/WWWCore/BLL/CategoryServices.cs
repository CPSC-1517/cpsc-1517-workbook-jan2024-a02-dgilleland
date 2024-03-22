using WestWindWholesale.DAL;
using WestWindWholesale.Models;

namespace WestWindWholesale;

public class CategoryServices
	{
		private readonly WestWindContext _context;
		internal CategoryServices(WestWindContext context)
		{
			_context = context;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public List<Category> GetAllCategories()
		{
			return _context.Categories.ToList<Category>();
		}
	}
