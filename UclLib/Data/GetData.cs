using System.Collections.Generic;
using System.Diagnostics;
using System.Web;
using System.IO;
using Newtonsoft.Json;
using UclLib.Objects;


namespace UclLib.Data
{
	public static class GetData
    {
		public static string ReadFile(string path)
		{
			return File.ReadAllText(HttpContext.Current.Server.MapPath(path));
		}

        public static List<Student> GetStudents()
        {
            return JsonConvert.DeserializeObject<List<Student>>(ReadFile("~/db/StudentsData.json"));
		}

        public static List<Teacher> GetTeachers()
        {
			return JsonConvert.DeserializeObject<List<Teacher>>(ReadFile("~/db/TeachersData.json"));
		}

        // TODO: Create a combined list of students AND teachers
        public static List<Person> GetAllUclData()
        {
            List<Person> personsList = new List<Person>();
            personsList.AddRange(GetStudents());
            personsList.AddRange(GetTeachers());

            return personsList;
        }
    }
}
