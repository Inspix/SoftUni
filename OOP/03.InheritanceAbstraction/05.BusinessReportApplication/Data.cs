using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company;

namespace BusinessReportApplication
{
    class Data
    {
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            List<Sale> sales = new List<Sale>()
                {
                    new Sale("Biri4ka", DateTime.Now, 5),
                    new Sale("Biri4ka", DateTime.Now, 10)
                }
            ;
            Manager manager = new Manager(20, "Goshko", "Kurtev", 500, "Production", new List<IEmployee>()
            {
                new RegularEmployee(26,"Toni","Montana","Accounting",1000)

            });
            SalesEmployee simo = new SalesEmployee(25, "Ani", "Ruseva", "Marketing", 700, sales);
            SalesEmployee semo = new SalesEmployee(27, "Sori", "Bratmi", "Sales", 250, sales);
            Developer dev = new Developer(55, "Kircho", "Atanasov", "Production", 2500, new List<Project>()
            {
                new Project("Game", DateTime.Now, "Igra za kef", "open"),
                new Project("Game2", DateTime.Now, "Igra za pari", "closed"),

            });

            employees.Add(manager);
            employees.Add(semo);
            employees.Add(simo);
            employees.Add(dev);

            return employees;
        }
    }
}
