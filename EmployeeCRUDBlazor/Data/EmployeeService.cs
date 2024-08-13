using EmployeeCRUDBlazor.DBContext;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCRUDBlazor.Data
{
    public class EmployeeService : IEmployeeService
    {
        private readonly AppDBContext _appDBContext;
        public EmployeeService(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        // Add New Employeed Record
        public async Task<bool> AddNewEmployees(Employees employees)
        {
            await _appDBContext.AddAsync(employees);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        // Delete Employees Date
        public async Task<bool> DeleteEmployees(Employees employees)
        {
            _appDBContext.Employees.Remove(employees);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        // Get All Employees List
        public async Task<List<Employees>> GetAllEmployees()
        {
            return await _appDBContext.Employees.ToListAsync();
        }

        // Get Employeed By Id
        public async Task<Employees> GetEmployeesById(int id)
        {
            Employees employees = await _appDBContext.Employees.FirstOrDefaultAsync(x=> x.Id == id);
            return employees;
        }

        // Update Employees Date
        public async Task<bool> UpdateEmployees(Employees employees)
        {
            _appDBContext.Employees.Update(employees);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
    }
}
