using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetAuthentication.Models;
using AspNetAuthentication.Repository;
using Microsoft.EntityFrameworkCore;

namespace AspNetAuthentication.Services {
    public class EmployeeRepository : IEmployee {
        private readonly ApplicationDbContext _context;

        public EmployeeRepository (ApplicationDbContext context) {
            _context = context;
        }
        public Task<bool> DeleteEmployeeAsync (Guid EmployeeId) {
            throw new NotImplementedException ();
        }

        public Task<Employee> EmployeeAsync (Guid EmployeeId) {
            throw new NotImplementedException ();
        }

        public Task<bool> EmployeeExistAsync (Guid EmployeeId) {
            throw new NotImplementedException ();
        }

        public async Task<IEnumerable<Employee>> EmployeesAsync () {
            return await _context.Employees.ToListAsync ();
        }

        public Task<Employee> InsertEmployeeAsync (Employee Employee) {
            throw new NotImplementedException ();
        }

        public Task<bool> SaveEmployeeAsync () {
            throw new NotImplementedException ();
        }

        public Task<bool> UpdateEmployeeAsync (Guid EmployeeId) {
            throw new NotImplementedException ();
        }
    }
}