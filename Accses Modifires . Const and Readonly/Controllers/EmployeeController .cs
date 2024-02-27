
using Accses_Modifires_._Const_and_Readonly.Helpers.Constants;
using Accses_Modifires_._Const_and_Readonly.Models;
using Accses_Modifires_._Const_and_Readonly.Services;

namespace Accses_Modifires_._Const_and_Readonly.Controllers
{
    internal class EmployeeController
    {
        private readonly EmployeeService employeeService;

        public EmployeeController()
        {
            employeeService = new EmployeeService();
        }

        public void GetAll()
        { 
            var result = employeeService.GetAll();

            foreach (var item in result)
            {
                Console.WriteLine(item.name + " " + item.surname);

            }
        }

        public void GetAllByAge()
        {

            var employees = employeeService.GetAll();

            var result = employeeService.GetAllByAge(employees,30);

            foreach (var item in result)
            {
                //Console.WriteLine(item.name + " " + item.surname + " " + item.age);

            }
 

        }

        public void GetCountByAge()
        {
            //Console.WriteLine("Add first age: ");
            int firstAge = int.Parse(Console.ReadLine());


            //Console.WriteLine("Add last age: ");
            int lastAge = int . Parse (Console.ReadLine());

            int count  = employeeService.GetCountBYAge (employeeService.GetAll(),firstAge,lastAge);
            //Console.WriteLine(count);

        }

        public void GetSumOfAges()
        {
            int sumOfAge = employeeService.SumOfAges(employeeService.GetAll());
           // Console.WriteLine(sumOfAge);

        }

        public void GetAllByCheckedEmail()
        {
            //Console.WriteLine("Add your text");
            string str = Console.ReadLine();

            Employee[] employees = employeeService.GetAll();

            Employee[] checkedEmployees = employeeService.GetAllByCheckedEmail(employees, str);
            if (checkedEmployees.Count() == 0)
            {
               // Console.WriteLine(ResponseMessages.Notfound);
                return;
                

            }

            foreach (var item in checkedEmployees)
            {
               // Console.WriteLine(item.name + " " + item.surname + " " + item.email);

            }
           



        }






    }
}
