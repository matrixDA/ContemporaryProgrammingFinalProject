using ContemporaryProgrammingFinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContemporaryProgrammingFinalProject.Data
{
	public class HService : InHService
	{
		HContext ctx;

		public HService(HContext context)
		{
			ctx = context;
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

		public List<Hobbies> GetAllHobby()
		{
			return ctx.Hobbies.ToList();
		}

		public Hobbies GetHobbyById(int Id)
		{
			return ctx.Hobbies.FirstOrDefault(x => x.ID == Id);
		}

		public int? RemoveHobbyById(int Id)
		{
			var data = this.GetHobbyById(Id);
			if (data == null)
			{
				return null;
			}
			ctx.Hobbies.Remove(data);
			return ctx.SaveChanges();
		}

		public int? UpdateHobby(Hobbies i)
		{
			ctx.Hobbies.Update(i);
			return ctx.SaveChanges();
		}
	}
}
