namespace ContemporaryProgrammingFinalProject.Models
{
	public class VideoGames
	{
		public int ID { get; set; }

		public string Member { get; set; }

		public string Title { get; set; }

		public string Developer { get; set; }

		public string PlayTime { get; set; }

		public string Genre { get; set; }

		public string Rank { get; set; }

		public string GetText()
		{
			return $" {ID} \t {Member} \t {Title} \t {Developer} \t {PlayTime} \t {Genre} \t {Rank}";
		}
	}
}
