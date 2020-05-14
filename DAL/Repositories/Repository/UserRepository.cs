using System;
using DAL.DataContext;
using DAL.Entities;
using DAL.Repositories.IRepository;

namespace DAL.Repositories.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(EmployeeDBContext context) :base(context)
        {
        }
    }
}
