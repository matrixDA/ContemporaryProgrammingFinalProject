namespace ContemporaryProgrammingFinalProject.Models
{
	public class Hobbies
	{
		public int ID { get; set; }

		public string Member { get; set; }

		public string Hobby { get; set; }

		public int InterestLevel { get; set; }

		public string Discovery { get; set; }

        public string GetText()
        {
            return $" {ID} \t {Member} \t {Hobby} \t {InterestLevel} \t {Discovery}";
        }
    }
}
