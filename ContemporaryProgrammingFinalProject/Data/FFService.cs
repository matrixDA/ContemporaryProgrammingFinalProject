﻿using System.Collections;
using System.Diagnostics.Eventing.Reader;
using ContemporaryProgrammingFinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using NJsonSchema.Annotations;

namespace ContemporaryProgrammingFinalProject.Data
{
	public class FFService : InFFService
	{
		FinalContext ctx;

		public FFService(FinalContext context)
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

		public List<FavoriteFood> GetAllFood()
		{
			return ctx.FavoriteFood.ToList();
		}

		public FavoriteFood GetFoodById(int Id)
		{
			return ctx.FavoriteFood.FirstOrDefault(x => x.ID == Id);

		}

		public int? RemoveFoodById(int Id)
		{
			var data = this.GetFoodById(Id);
			if (data == null)
			{
				return null;
			}
			ctx.FavoriteFood.Remove(data);
			return ctx.SaveChanges();
		}

		public int? UpdateFood(FavoriteFood i)
		{
			ctx.FavoriteFood.Update(i);
			return ctx.SaveChanges();
		}
	}
}
