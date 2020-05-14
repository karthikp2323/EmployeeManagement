using System;
using System.Threading.Tasks;
using DAL.DataContext;
using DAL.Entities;
using DAL.Repositories.IRepository;

namespace DAL.Repositories.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EmployeeDBContext _context;
        //private UserRepository _userRepository;
        private GenericRepository<User> _user;

        public UnitOfWork(EmployeeDBContext context)
        {
            _context = context;
        }

        //public IUserRepository Users => _userRepository = _userRepository ?? new UserRepository(_context);

        //public GenericRepository<User> User => _user ?? new GenericRepository<User>(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        
    }
}
