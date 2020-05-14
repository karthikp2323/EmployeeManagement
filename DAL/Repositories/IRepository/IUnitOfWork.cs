using System;
using System.Threading.Tasks;
using DAL.DataContext;
using DAL.Entities;
using DAL.Repositories.Repository;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.IRepository
{
    public interface IUnitOfWork  
    {
        //IUserRepository Users { get; }
        //public GenericRepository<User> User { get; }
        
        Task<int> CommitAsync();
    }
}
