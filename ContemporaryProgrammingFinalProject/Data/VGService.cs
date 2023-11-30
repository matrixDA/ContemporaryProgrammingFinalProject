using ContemporaryProgrammingFinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContemporaryProgrammingFinalProject.Data
{
	public class VGService : InVGService
	{
		VGContext ctxVG;

		public VGService(VGContext context)
		{
			ctxVG = context;
		}

		public int? AddGame(VideoGames i)
		{
			var data = this.GetGameById(i.ID);
			if (data != null)
			{
				return null;
			}
			ctxVG.VideoGames.Add(i);
			return ctxVG.SaveChanges();
		}

		public List<VideoGames> GetAllGame()
		{
			return ctxVG.VideoGames.ToList();
		}

		public VideoGames GetGameById(int Id)
		{
			return ctxVG.VideoGames.FirstOrDefault(x => x.ID == Id);
		}

		public int? RemoveGameById(int Id)
		{
			var data = this.GetGameById(Id);
			if (data == null)
			{
				return null;
			}
			ctxVG.VideoGames.Remove(data);
			return ctxVG.SaveChanges();
		}

		public int? UpdateGame(VideoGames i)
		{
			ctxVG.VideoGames.Update(i);
			return ctxVG.SaveChanges();
		}
	}
}
