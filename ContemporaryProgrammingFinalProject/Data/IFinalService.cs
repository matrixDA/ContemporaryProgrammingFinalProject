using ContemporaryProgrammingFinalProject.Models;

namespace ContemporaryProgrammingFinalProject.Data
{
	public interface IFinalService
    {

		int? AddHobby(Hobbies i);
		List<Hobbies> GetAllHobbies();
		Hobbies GetHobbyById(int Id);
		int? RemoveHobbyById(int Id);
		int? UpdateHobbies(Hobbies i);


		int? AddFood(FavoriteFood i);
		List<FavoriteFood> GetAllFood();
		FavoriteFood GetFoodById(int Id);
		int? RemoveFoodById(int Id);
		int? UpdateFood(FavoriteFood i);


		int? AddPersonal(PersonalInfo i);
		List<PersonalInfo> GetAllPersonal();
		PersonalInfo GetPersonalById(int Id);
		int? RemovePersonalById(int Id);
		int? UpdatePersonal(PersonalInfo i);


		int? AddVideoGames(VideoGames i);
		List<VideoGames> GetAllVideoGames();
		VideoGames GetVideoGamesById(int Id);
		int? RemoveVideoGamesById(int Id);
		int? UpdateVideoGames(VideoGames i);


	}
}
