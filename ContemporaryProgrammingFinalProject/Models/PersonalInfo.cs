﻿using System.ComponentModel.DataAnnotations;

namespace ContemporaryProgrammingFinalProject.Models
{
	public class PersonalInfo
	{
		[Key]
		public int ID { get; set; }

		public string Member { get; set; }

		public DateTime BirthDate { get; set; }

		public string CollegeProgram { get; set; }

		public string YearInProgram { get; set; }

        public string GetText()
        {
            return $" {ID} \t {Member} \t {BirthDate} \t {CollegeProgram} \t {YearInProgram}";
        }
    }
}
