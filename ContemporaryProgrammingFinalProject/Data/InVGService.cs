using ContemporaryProgrammingFinalProject.Models;

namespace ContemporaryProgrammingFinalProject.Data
{
	public interface InVGService
    {

		//VideoGames
		int? AddGame(VideoGames i);
		List<VideoGames> GetAllGame();
		VideoGames GetGameById(int Id);
		int? RemoveGameById(int Id);
		int? UpdateGame(VideoGames i);


	}
}
