using SharedLibrary.Dtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace UdemyAuthServer.Core.Services
{
    public interface IServiceGeneric<TEntity, TDto> where TEntity : class where TDto : class
    {
        Task<Response<TDto>> GetByIdAsync(int id);

        Task<Response<IEnumerable<TDto>>> GetAllAsync();

        Task<Response<IEnumerable<TDto>>> Where(Expression<Func<TEntity, bool>> predicate);

        Task<Response<TDto>> AddAsync(TEntity entity);

        Task<Response<NoDataDto>> Remove(TEntity entity);

        Task<Response<NoDataDto>> Update(TEntity entity);
    }
}