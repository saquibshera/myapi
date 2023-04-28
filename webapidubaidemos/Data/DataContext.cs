using webapidubaidemos.Models;

namespace webapidubaidemos.Data
{
    public class DataContext
    {
        List<Employee> employees;

        public DataContext()
        {
            employees = new List<Employee>();
        }
        public List<Employee> getempoyees()
        {
            return employees;
            
        }
        public void addemp(Employee emp)
        {
            employees.Add(emp);
        }
    }
}
