using System.Linq;

namespace StaticWebPageTest.Models
{
	public class Seed
	{
		private ApplicationDbContext db;

		public Seed(ApplicationDbContext _db)
		{
			db = _db;
		}

		public void SeedDb()
		{
			db.Database.EnsureCreated();

			if (db.Items.Any()) { return; }

			//for (int i = 0; i < 1000; i++)
			//{
				var post = new Item
				{
					Name = "{i}"
				};
				db.Add(post);
				db.SaveChanges();
			//}
		}
	}
}
