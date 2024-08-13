namespace EmployeeCRUDBlazor.Data
{
    public interface IEmployeeService
    {
        public Task<List<Employees>> GetAllEmployees();
        public Task<bool> AddNewEmployees(Employees employees);
        public Task<Employees> GetEmployeesById(int id);
        public Task<bool> UpdateEmployees(Employees employees);
        public Task<bool> DeleteEmployees(Employees employees);
    }
}
