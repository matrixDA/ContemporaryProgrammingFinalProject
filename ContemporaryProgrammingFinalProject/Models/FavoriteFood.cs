namespace ContemporaryProgrammingFinalProject.Models
{
	public class FavoriteFood
	{
		public int ID { get; set; }

		public string Member { get; set; }

		public string Breakfast { get; set; }

		public string Lunch { get; set; }

		public string Dinner { get; set; }

		public string Snack { get; set; }

        public string GetText()
        {
            return $" {ID} \t {Member} \t {Breakfast} \t {Lunch} \t {Dinner} \t {Snack}";
        }
    }
}
