using ContemporaryProgrammingFinalProject.Models;
using Microsoft.AspNetCore.Mvc;

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
			var data = this.GetFoodById(i.ID);
			if (data != null)
			{
				return null;
			}
			FC.FavoriteFood.Add(i);
			return FC.SaveChanges();
		}

		public int? AddHobby(Hobbies i)
		{
			var data = this.GetHobbyById(i.ID);
			if (data != null)
			{
				return null;
			}
			FC.Hobbies.Add(i);
			return FC.SaveChanges();
		}

		public int? AddPersonal(PersonalInfo i)
		{
			var data = this.GetPersonalById(i.ID);
			if (data != null)
			{
				return null;
			}
			FC.PersonalInfo.Add(i);
			return FC.SaveChanges();
		}

		public int? AddVideoGames(VideoGames i)
		{
			var data = this.GetVideoGamesById(i.ID);
			if (data != null)
			{
				return null;
			}
			FC.VideoGames.Add(i);
			return FC.SaveChanges();
		}







		public List<FavoriteFood> GetAllFood()
		{
			return FC.FavoriteFood.ToList();
		}

		public List<Hobbies> GetAllHobbies()
		{
			return FC.Hobbies.ToList();
		}

		public List<PersonalInfo> GetAllPersonal()
		{
			return FC.PersonalInfo.ToList();
		}

		public List<VideoGames> GetAllVideoGames()
		{
			return FC.VideoGames.ToList();
		}







		public FavoriteFood GetFoodById(int Id)
		{
			return FC.FavoriteFood.FirstOrDefault(x => x.ID == Id);
		}

		public Hobbies GetHobbyById(int Id)
		{
			return FC.Hobbies.FirstOrDefault(x => x.ID == Id);
		}

		public PersonalInfo GetPersonalById(int Id)
		{
			return FC.PersonalInfo.FirstOrDefault(x => x.ID == Id);
		}

		public VideoGames GetVideoGamesById(int Id)
		{
			return FC.VideoGames.FirstOrDefault(x => x.ID == Id);
		}








		public int? RemoveFoodById(int Id)
		{
			var data = this.GetFoodById(Id);
			if (data != null)
			{
				return null;
			}
			FC.FavoriteFood.Remove(data);
			return FC.SaveChanges();
		}

		public int? RemoveHobbyById(int Id)
		{
			var data = this.GetHobbyById(Id);
			if (data != null)
			{
				return null;
			}
			FC.Hobbies.Remove(data);
			return FC.SaveChanges();
		}

		public int? RemovePersonalById(int Id)
		{
			var data = this.GetPersonalById(Id);
			if (data != null)
			{
				return null;
			}
			FC.PersonalInfo.Remove(data);
			return FC.SaveChanges();
		}

		public int? RemoveVideoGamesById(int Id)
		{
			var data = this.GetVideoGamesById(Id);
			if (data != null)
			{
				return null;
			}
			FC.VideoGames.Remove(data);
			return FC.SaveChanges();
		}








		public int? UpdateFood(FavoriteFood i)
		{
			FC.FavoriteFood.Update(i);
			return FC.SaveChanges();
		}

		public int? UpdateHobbies(Hobbies i)
		{
			FC.Hobbies.Update(i);
			return FC.SaveChanges();
		}

		public int? UpdatePersonal(PersonalInfo i)
		{
			FC.PersonalInfo.Update(i);
			return FC.SaveChanges();
		}

		public int? UpdateVideoGames(VideoGames i)
		{
			FC.VideoGames.Update(i);
			return FC.SaveChanges();
		}
	}
}
