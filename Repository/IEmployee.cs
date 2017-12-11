using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetAuthentication.Models;

namespace AspNetAuthentication.Repository {
    public interface IEmployee {
        Task<IEnumerable<Employee>> EmployeesAsync ();
        Task<Employee> EmployeeAsync (Guid EmployeeId);
        Task<Employee> InsertEmployeeAsync (Employee Employee);
        Task<bool> UpdateEmployeeAsync (Guid EmployeeId);
        Task<bool> DeleteEmployeeAsync (Guid EmployeeId);
        Task<bool> EmployeeExistAsync (Guid EmployeeId);
        Task<bool> SaveEmployeeAsync ();

    }
}