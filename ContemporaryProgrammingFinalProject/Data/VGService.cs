using ContemporaryProgrammingFinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContemporaryProgrammingFinalProject.Data
{
	public class VGService : InVGService
	{
		FinalContext ctx;

		public VGService(FinalContext context)
		{
			ctx = context;
		}

		public int? AddGame(VideoGames i)
		{
			var data = this.GetGameById(i.ID);
			if (data != null)
			{
				return null;
			}
			ctx.VideoGames.Add(i);
			return ctx.SaveChanges();
		}

		public List<VideoGames> GetAllGame()
		{
			return ctx.VideoGames.ToList();
		}

		public VideoGames GetGameById(int Id)
		{
			return ctx.VideoGames.FirstOrDefault(x => x.ID == Id);
		}

		public int? RemoveGameById(int Id)
		{
			var data = this.GetGameById(Id);
			if (data == null)
			{
				return null;
			}
			ctx.VideoGames.Remove(data);
			return ctx.SaveChanges();
		}

		public int? UpdateGame(VideoGames i)
		{
			ctx.VideoGames.Update(i);
			return ctx.SaveChanges();
		}
	}
}
