using Dapper;
using Dapper.Contrib.Extensions;
using DataBridge.Interfaces;
using DataBridge.Shared.Classes;
using DataBridge.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using DataBridge.Shared.Utilities;
using System.Text.RegularExpressions;

namespace DataBridge.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly string Table = "";
        ICustomConnectionFactory sqlFactory = null;
        public Repository(ICustomConnectionFactory sqlFactory, string Table)
        {
            this.sqlFactory = sqlFactory;
            this.Table = Table;
        }

        public async Task<long> Insert(TEntity entity)
        {
            var baseEntity = entity as BaseEntity;
            baseEntity.Created = DateTime.Now;
            baseEntity.Modified = DateTime.Now;

            using (IDbConnection conn = sqlFactory.Connection)
            {
                conn.Open();
                return await conn.InsertAsync(entity);
            }
        }

        public async Task<long> Insert(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                BaseEntity baseEntity = entity as BaseEntity;
                baseEntity.Created = DateTime.Now;
                baseEntity.Modified = DateTime.Now;
            }

            using (IDbConnection conn = sqlFactory.Connection)
            {
                conn.Open();
                return await conn.InsertAsync(entities);
            }
        }

        public async Task<bool> Update(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                BaseEntity baseEntity = entity as BaseEntity;

                if (baseEntity.Created.Year < 1754)
                    baseEntity.Created = DateTime.Now;

                baseEntity.Modified = DateTime.Now;
            }

            using (IDbConnection conn = sqlFactory.Connection)
            {
                conn.Open();
                return await conn.UpdateAsync(entities);
            }
        }

        public async Task<bool> Update(TEntity entity)
        {
            var baseEntity = entity as BaseEntity;

            if (baseEntity.Created.Year < 1754)
                baseEntity.Created = DateTime.Now;

            baseEntity.Modified = DateTime.Now;

            using (IDbConnection conn = sqlFactory.Connection)
            {
                conn.Open();
                try
                {
                    var ok = await conn.UpdateAsync(entity);
                    return ok;
                }
                catch (Exception exc)
                {
                    return false;
                }
 
            }
        }

        public async Task<int> Delete(Guid id)
        {
            if (string.IsNullOrEmpty(Table))
                return -1;

            using (IDbConnection conn = sqlFactory.Connection)
            {
                conn.Open();
                return await conn.ExecuteAsync($"DELETE FROM {Table} WHERE Id = '{id}'");
            }
        }

        public async Task<bool> Delete(TEntity entity)
        {
            using (IDbConnection conn = sqlFactory.Connection)
            {
                conn.Open();
                return await conn.DeleteAsync(entity);
            }
        }

        public async Task<TEntity> Get(Guid Id)
        {
            using (IDbConnection conn = sqlFactory.Connection)
            {
                conn.Open();
                return await conn.GetAsync<TEntity>(Id);
            }
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            using (IDbConnection conn = sqlFactory.Connection)
            {
                conn.Open();
                return await conn.GetAllAsync<TEntity>();
            }
        }

        public async Task<IEnumerable<TEntity>> Query(MapperObject map)
        {
            using (IDbConnection conn = sqlFactory.Connection)
            {
                string sql = map.ToSQL();
                DynamicParameters parameters = map.Parameters == null ? null : new DynamicParameters(map.Parameters);

                conn.Open();
                return await conn.QueryAsync<TEntity>(sql, parameters);
            }
        }
    }
}
