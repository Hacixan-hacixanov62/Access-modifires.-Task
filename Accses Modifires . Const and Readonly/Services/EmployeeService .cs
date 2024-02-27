
using Accses_Modifires_._Const_and_Readonly.Models;

namespace Accses_Modifires_._Const_and_Readonly.Services
{
    internal class EmployeeService: Employee 
    { 
        public Employee[] GetAll() 
        {
            Employee employee1 = new()
            {
                id = 1,
                name = "Employe1",
                surname = "Employev1",
                address = "Bakil",
                email = "employe1@gmail.com",
                age = 18
            };

            Employee employee2 = new()
            {
                id = 2,
                name = "Employe2",
                surname = "Employev2",
                address = "Bakil2",
                email = "employe2@gmail.com",
                age = 19
            };
            Employee employee3 = new()
            {
                id = 3,
                name = "Employe3",
                surname = "Employev3",
                address = "Bakil3",
                email = "employe3@gmail.com",
                age = 54
            };
            Employee employee4 = new()
            {
                id = 4,
                name = "Employe4",
                surname = "Employev4",
                address = "Bakil4",
                email = "employe4@gmail.com",
                age = 67
            };
            Employee employee5 = new()
            {
                id = 5,
                name = "Employe5",
                surname = "Employev5",
                address = "Bakil5",
                email = "tploye5@gmail.com",
                age = 23
            };
            Employee employee6 = new()
            {
                id = 6,
                name = "Employe6",
                surname = "Employev6",
                address = "Bakil6",
                email = "employe6@gmail.com",
                age = 13
            };

            Employee employee7 = new()
            {
                id = 7,
                name = "Employe7",
                surname = "Employev7",
                address = "Bakil7",
                email = "tmploye7@gmail.com",
                age = 42
            };

            Employee[] employers = { employee1, employee2, employee3, employee4, employee5, employee6, employee7 };
            return employers;


        }

        public Employee[] GetAllByAge(Employee[] employees ,int age)
        {
           // var employees = GetAll();
            return employees.Where(m=> m.age > age).ToArray();
        }     

        public int GetCountBYAge(Employee[] employees , int firstAge , int lastAge)
        {
             return employees.Where( m=>m.age > firstAge  &&  m.age < lastAge ).Count();
        }

        public int SumOfAges(Employee[] employees )
        {
            return employees.Sum(m => m.age);
        }

        public Employee[] GetAllByCheckedEmail(Employee[]employees , string str)
        {
            return employees.Where(m => m.email.StartsWith(str)).ToArray();


        }


    }
}
