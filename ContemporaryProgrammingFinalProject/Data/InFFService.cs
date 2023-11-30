using ContemporaryProgrammingFinalProject.Models;

namespace ContemporaryProgrammingFinalProject.Data
{
	public interface InFFService
    {

		//FavoriteFood
		int? AddFood(FavoriteFood i);
		List<FavoriteFood> GetAllFood();
		FavoriteFood GetFoodById(int Id);
		int? RemoveFoodById(int Id);
		int? UpdateFood(FavoriteFood i);


	}
}
