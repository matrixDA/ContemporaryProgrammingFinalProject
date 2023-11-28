namespace ContemporaryProgrammingFinalProject.Models
{
	public class VideoGames
	{
		public int ID { get; set; }

		public String Member { get; set; }

		public String Title { get; set; }

		public String Developer { get; set; }

		public String PlayTime { get; set; }

		public String Genre { get; set; }

		public String Rank { get; set; }

		public string GetText()
		{
			return $" {ID} \t {Member} \t {Title} \t {Developer} \t {PlayTime} \t {Genre} \t {Rank}";
		}
	}
}
