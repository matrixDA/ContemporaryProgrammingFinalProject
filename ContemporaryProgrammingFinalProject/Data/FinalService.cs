using ContemporaryProgrammingFinalProject.Models;

namespace ContemporaryProgrammingFinalProject.Data
{
	public class FinalService : IFinalService
	{

		FinalContext FC;

		public FinalService(FinalContext context)
		{
			FC = context;
		}

		public int? AddFood(FavoriteFood i)
		{
			throw new NotImplementedException();
		}

		public int? AddHobby(Hobbies i)
		{
			throw new NotImplementedException();
		}

		public int? AddPersonal(PersonalInfo i)
		{
			throw new NotImplementedException();
		}

		public int? AddVideoGames(VideoGames i)
		{
			throw new NotImplementedException();
		}

		public List<FavoriteFood> GetAllFood()
		{
			throw new NotImplementedException();
		}

		public List<Hobbies> GetAllHobbies()
		{
			throw new NotImplementedException();
		}

		public List<PersonalInfo> GetAllPersonal()
		{
			throw new NotImplementedException();
		}

		public List<VideoGames> GetAllVideoGames()
		{
			throw new NotImplementedException();
		}

		public FavoriteFood GetFoodById(int Id)
		{
			throw new NotImplementedException();
		}

		public Hobbies GetHobbyById(int Id)
		{
			throw new NotImplementedException();
		}

		public PersonalInfo GetPersonalById(int Id)
		{
			throw new NotImplementedException();
		}

		public VideoGames GetVideoGamesById(int Id)
		{
			throw new NotImplementedException();
		}

		public int? RemoveFoodById(int Id)
		{
			throw new NotImplementedException();
		}

		public int? RemoveHobbyById(int Id)
		{
			throw new NotImplementedException();
		}

		public int? RemovePersonalById(int Id)
		{
			throw new NotImplementedException();
		}

		public int? RemoveVideoGamesById(int Id)
		{
			throw new NotImplementedException();
		}

		public int? UpdateFood(FavoriteFood i)
		{
			throw new NotImplementedException();
		}

		public int? UpdateHobbies(Hobbies i)
		{
			throw new NotImplementedException();
		}

		public int? UpdatePersonal(PersonalInfo i)
		{
			throw new NotImplementedException();
		}

		public int? UpdateVideoGames(VideoGames i)
		{
			throw new NotImplementedException();
		}
	}
}
