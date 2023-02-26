using Shdooh_Employees.Models;

namespace MohdShdooh_.Models.Repository
{
    public class employeeRepository
    {
       
        private readonly EmoTestContext _context;
        public List<Employee> list;
        public employeeRepository( EmoTestContext context) {

            this._context = context;
        }
        public List<Employee> getEmployees()
        {
            
             this.list = _context.Employees.ToList();
            return this.list;
        }

    }
}
