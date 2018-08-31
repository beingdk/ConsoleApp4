using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
	public class Program
	{
		static void Main(string[] args)
		{
			using (var context = new DatabaseContext())
			{
				//context.Mydetails.Add(new Mydetail() { id = 001, name = "Dheeraj",address = "India" , city = "Delhi",mobile = 1234, salary = 90000,dob = DateTime.Now });
				//context.Peoples.Add(new People() { ProfessionName = Professions.Engineer, Name = "sonu", Salary = 100000 ,City = "Behror"});
				//context.Peoples.Add(new People() { ID = 002, ProfessionName = Professions.Engineer, Name = "Macho", Salary = 40000 });
				//context.Peoples.Add(new People() { ID = 003, ProfessionName = Professions.Engineer, Name = "Guru", Salary = 30000 });
				//context.Peoples.Add(new People() { ID = 004, ProfessionName = Professions.Doctor, Name = "Ponda", Salary = 20000 });
				context.SaveChanges();

				var topa = (from d in context.Peoples
						   where d.ProfessionName == Professions.Engineer
							select d).ToList();
				foreach (var a in topa)
					if (!(a.City == null))
					//{
						//Console.WriteLine("Name : {0} -" + a.City, a.Name);
					//}
				
					Console.WriteLine("ID : {0}, ProfessionName : {1}, Name : {2},Salary : {3},City : {4}",a.ID,a.ProfessionName,a.Name,a.Salary,a.City);
				//Console.WriteLine("ID : {0}, Name : {1}, address : {2},city : {3},mobile : {4},salary : {5},dob : {6}", a.id, a.name, a.address, a.city,a.mobile,a.salary,a.dob);
				Console.ReadKey();
			}
		}
	}
}
