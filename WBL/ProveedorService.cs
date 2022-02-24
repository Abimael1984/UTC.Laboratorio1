using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface IProveedorService
    {
        Task<DBEntity> Create(ProveedorEntity entity);
        Task<DBEntity> Delete(ProveedorEntity entity);
        Task<IEnumerable<ProveedorEntity>> Get();
        Task<ProveedorEntity> GetById(ProveedorEntity entity);
        Task<DBEntity> Update(ProveedorEntity entity);
    }

    public class ProveedorService : IProveedorService
    {
        private readonly IDataAcces sql;

        public ProveedorService(IDataAcces _sql)
        {
            sql = _sql;
        }

        #region MetodosCRUD

        //Metod GET para obtener datos, es de tipo asincronico

        public async Task<IEnumerable<ProveedorEntity>> Get()
        {
            try
            {
                var result = sql.QueryAsync<ProveedorEntity>(sp: "dbo.ProveedorObtener");
                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Metodo GetById
        public async Task<ProveedorEntity> GetById(ProveedorEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<ProveedorEntity>("dbo.ProveedorObtener", new { entity.IdProveedor });
                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Metodo Create
        public async Task<DBEntity> Create(ProveedorEntity entity)
        {
            try
            {
                var result = sql.ExcecuteAsync("dbo.ProveedorInsertar",
                    new
                    {
                        entity.Identificacion,
                        entity.Nombre,
                        entity.PrmierApellido,
                        entity.SegundoApellido,
                        entity.Edad,
                        entity.FechaNacimiento
                    });
                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Metodo Update
        public async Task<DBEntity> Update(ProveedorEntity entity)
        {
            try
            {
                var result = sql.ExcecuteAsync("dbo.ProveedorActualizar",
                    new
                    {
                        entity.IdProveedor,
                        entity.Identificacion,
                        entity.Nombre,
                        entity.PrmierApellido,
                        entity.SegundoApellido,
                        entity.Edad,
                        entity.FechaNacimiento
                    });
                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Metodo Delete
        public async Task<DBEntity> Delete(ProveedorEntity entity)
        {
            try
            {
                var result = sql.ExcecuteAsync("dbo.ProveedorActualizar",
                    new
                    {
                        entity.IdProveedor,
                    });
                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

    }
}
