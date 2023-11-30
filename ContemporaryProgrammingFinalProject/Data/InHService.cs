using ContemporaryProgrammingFinalProject.Models;

namespace ContemporaryProgrammingFinalProject.Data
{
	public interface InHService
	{
    
		//Hobbies
		int? AddHobby(Hobbies i);
		List<Hobbies> GetAllHobby();
		Hobbies GetHobbyById(int Id);
		int? RemoveHobbyById(int Id);
		int? UpdateHobby(Hobbies i);

	}
}
