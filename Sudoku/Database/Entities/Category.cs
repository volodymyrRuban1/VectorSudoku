using System.ComponentModel.DataAnnotations;

namespace Database.Entities
{
	public class Category
	{
		public int CategoryId { get; set; }

		public string CategoryName { get; set; }

		public string Description { get; set; }
	}
}
