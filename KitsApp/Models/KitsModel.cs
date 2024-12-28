namespace KitsApp.Models
{
	public class KitsModel
	{
		public int Id { get; set; }
		public string ImageTitle { get; set; }
		public string KitName { get; set; }
		public string KitNumber { get; set; }
		public float BasePrice { get; set; } = 50;
		public bool Badge { get; set; }
		public float FinalPrice { get; set; }
		public string League { get; set; }
	}
}
