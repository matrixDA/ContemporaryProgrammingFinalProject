﻿using ContemporaryProgrammingFinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ContemporaryProgrammingFinalProject.Data
{
	public class PIContext : DbContext
	{
		public PIContext(DbContextOptions<PIContext> options) : base(options) { }

		public DbSet<PersonalInfo> PersonalInfo { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<PersonalInfo>().HasData(

				new PersonalInfo
				{
					ID = 1,
					Member = "Logan Freeman",
					BirthDate = new DateTime(2003, 11, 18),
					CollegeProgram = "Information Technology",
					YearInProgram = "Junior",
				},

				 new PersonalInfo
				 {
					 ID = 2,
					 Member = "Ian Mendez",
					 BirthDate = new DateTime(2000, 11, 2),
					 CollegeProgram = "Psychology",
					 YearInProgram = "Senior",
				 },

				  new PersonalInfo
				  {
					  ID = 3,
					  Member = "Loc Nguyen",
					  BirthDate = new DateTime(2004, 8, 6),
					  CollegeProgram = "Information Technology",
					  YearInProgram = "Sophomore",
				  },

				   new PersonalInfo
				   {
					   ID = 4,
					   Member = "Dinesh Adhikari",
					   BirthDate = new DateTime(2003, 5, 27),
					   CollegeProgram = "Information Technology",
					   YearInProgram = "Sophomore",
				   }

				);

		}
	}

}