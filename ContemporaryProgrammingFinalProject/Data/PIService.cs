using ContemporaryProgrammingFinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContemporaryProgrammingFinalProject.Data
{
	public class PIService : InPIService
	{
		FinalContext ctx;

		public PIService(FinalContext context)
		{
			ctx = context;
		}

		public int? AddInfo(PersonalInfo i)
		{
			var data = this.GetInfoById(i.ID);
			if (data != null)
			{
				return null;
			}
			ctx.PersonalInfo.Add(i);
			return ctx.SaveChanges();
		}

		public List<PersonalInfo> GetAllInfo()
		{
			return ctx.PersonalInfo.ToList();
		}

		public PersonalInfo GetInfoById(int Id)
		{
			return ctx.PersonalInfo.FirstOrDefault(x => x.ID == Id);
		}

		public int? RemoveInfoById(int Id)
		{
			var data = this.GetInfoById(Id);
			if (data == null)
			{
				return null;
			}
			ctx.PersonalInfo.Remove(data);
			return ctx.SaveChanges();
		}

		public int? UpdateInfo(PersonalInfo i)
		{
			ctx.PersonalInfo.Update(i);
			return ctx.SaveChanges();
		}
	}
}
