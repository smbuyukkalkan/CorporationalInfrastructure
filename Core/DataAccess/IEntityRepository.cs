using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    /// <summary> Defines create, read, update and delete (CRUD) operations of an <see cref="IEntity"/>. </summary>
    /// <typeparam name="T"> The entity whose the operations will operate on. </typeparam>
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        /// <summary> Retrieves all <typeparamref name="T"/>s, optionally ones which satisfy conditions identified by <paramref name="filter"/>, from the data source. </summary>
        /// <param name="filter">The conditions which will be checked when retrieving <typeparamref name="T"/>s. </param>
        /// <returns> Returns a <see cref="List{T}"/> which contains all <typeparamref name="T"/> in the data source. </returns>
        List<T> GetAll(Expression<Func<T, bool>> filter = null);

        /// <summary> Retrieves a <typeparamref name="T"/>, which satisfy conditions identified by <paramref name="filter"/>, from the data source. </summary>
        /// <param name="filter"></param>
        /// <returns>Returns a <typeparamref name="T"/> which satisfy the conditions identified by <paramref name="filter"/>. </returns>
        T Get(Expression<Func<T, bool>> filter);

        /// <summary> Adds a <see cref="T"/> to the database. </summary>
        /// <param name="entity">The <see cref="T"/> to be added to the data source. </param>
        void Add(T entity);

        /// <summary> Updates properties of an existing <see cref="T"/> in the data source. </summary>
        /// <param name="entity"> The <see cref="T"/> to be updated. </param>
        void Update(T entity);

        /// <summary> Deletes a <see cref="T"/> from the database. </summary>
        /// <param name="entity"> The <see cref="T"/> to be deleted from the data source. </param>
        void Delete(T entity);
    }
}
