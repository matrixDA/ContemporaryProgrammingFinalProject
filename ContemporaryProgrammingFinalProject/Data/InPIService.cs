using ContemporaryProgrammingFinalProject.Models;

namespace ContemporaryProgrammingFinalProject.Data
{
	public interface InPIService
    {
		//PersonalInfo
		int? AddInfo(PersonalInfo i);
		List<PersonalInfo> GetAllInfo();
		PersonalInfo GetInfoById(int Id);
		int? RemoveInfoById(int Id);
		int? UpdateInfo(PersonalInfo i);

	}
}
