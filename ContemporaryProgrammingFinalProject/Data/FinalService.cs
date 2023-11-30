using ContemporaryProgrammingFinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContemporaryProgrammingFinalProject.Data
{
	public class FinalService : IFinalService
	{

		FinalContext ctx;

		public FinalService(FinalContext context)
		{
			ctx = context;
		}

		public int? AddFood(FavoriteFood i)
		{
			var data = this.GetFoodById(i.ID);
			if (data != null)
			{
				return null;
			}
			ctx.FavoriteFood.Add(i);
			return ctx.SaveChanges();
		}

		public int? AddHobby(Hobbies i)
		{
			var data = this.GetHobbyById(i.ID);
			if (data != null)
			{
				return null;
			}
			ctx.Hobbies.Add(i);
			return ctx.SaveChanges();
		}

		public int? AddPersonal(PersonalInfo i)
		{
			var data = this.GetPersonalById(i.ID);
			if (data != null)
			{
				return null;
			}
			ctx.PersonalInfo.Add(i);
			return ctx.SaveChanges();
		}

		public int? AddVideoGames(VideoGames i)
		{
			var data = this.GetVideoGamesById(i.ID);
			if (data != null)
			{
				return null;
			}
			ctx.VideoGames.Add(i);
			return ctx.SaveChanges();
		}







		public List<FavoriteFood> GetAllFood()
		{
			return ctx.FavoriteFood.ToList();
		}

		public List<Hobbies> GetAllHobbies()
		{
			return ctx.Hobbies.ToList();
		}

		public List<PersonalInfo> GetAllPersonal()
		{
			return ctx.PersonalInfo.ToList();
		}

		public List<VideoGames> GetAllVideoGames()
		{
			return ctx.VideoGames.ToList();
		}







		public FavoriteFood GetFoodById(int Id)
		{
			return ctx.FavoriteFood.FirstOrDefault(x => x.ID == Id);
		}

		public Hobbies GetHobbyById(int Id)
		{
			return ctx.Hobbies.FirstOrDefault(x => x.ID == Id);
		}

		public PersonalInfo GetPersonalById(int Id)
		{
			return ctx.PersonalInfo.FirstOrDefault(x => x.ID == Id);
		}

		public VideoGames GetVideoGamesById(int Id)
		{
			return ctx.VideoGames.FirstOrDefault(x => x.ID == Id);
		}








		public int? RemoveFoodById(int Id)
		{
			var data = this.GetFoodById(Id);
			if (data != null)
			{
				return null;
			}
			ctx.FavoriteFood.Remove(data);
			return ctx.SaveChanges();
		}

		public int? RemoveHobbyById(int Id)
		{
			var data = this.GetHobbyById(Id);
			if (data != null)
			{
				return null;
			}
			ctx.Hobbies.Remove(data);
			return ctx.SaveChanges();
		}

		public int? RemovePersonalById(int Id)
		{
			var data = this.GetPersonalById(Id);
			if (data != null)
			{
				return null;
			}
			ctx.PersonalInfo.Remove(data);
			return ctx.SaveChanges();
		}

		public int? RemoveVideoGamesById(int Id)
		{
			var data = this.GetVideoGamesById(Id);
			if (data != null)
			{
				return null;
			}
			ctx.VideoGames.Remove(data);
			return ctx.SaveChanges();
		}








		public int? UpdateFood(FavoriteFood i)
		{
			ctx.FavoriteFood.Update(i);
			return ctx.SaveChanges();
		}

		public int? UpdateHobbies(Hobbies i)
		{
			ctx.Hobbies.Update(i);
			return ctx.SaveChanges();
		}

		public int? UpdatePersonal(PersonalInfo i)
		{
			ctx.PersonalInfo.Update(i);
			return ctx.SaveChanges();
		}

		public int? UpdateVideoGames(VideoGames i)
		{
			ctx.VideoGames.Update(i);
			return ctx.SaveChanges();
		}
	}
}
