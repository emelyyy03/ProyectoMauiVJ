using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace ProyectoMauiVJ
{
    public class LocalDbService
    {
        //private const string DB_NAME = "demo_suma.db3";
        private readonly SQLiteAsyncConnection _connection;

        public LocalDbService(string dbPath)
        {
            _connection = new SQLiteAsyncConnection(dbPath);
            _connection.CreateTableAsync<Cuentas>().Wait();
        }


        

        //Metodo para listar los registros de nuestra tabla
        public async Task<List<Cuentas>> GetCuentas()
        {
            return await _connection.Table<Cuentas>().ToListAsync();
        }

        //Metodo para listar los registros por id
        public async Task<Cuentas> GetById(int id)
        {
            return await _connection.Table<Cuentas>().Where(x => x.Id == id).FirstOrDefaultAsync();
        }


        //Metodo para crear registro 
        public async Task Create(Cuentas cuentas)
        {
            await _connection.InsertAsync(cuentas);
        }

        public Task<Cuentas> ObtenerUsuarioAsync(string nombreUsuario, string contraseña)
        {
            return _connection.Table<Cuentas>()
                     .Where(u => u.Nombre == nombreUsuario && u.Contraseña == contraseña)
                     .FirstOrDefaultAsync();
        }

        //Metodo para actualizar 
        public async Task Update(Cuentas cuentas)
        {
            await _connection.UpdateAsync(cuentas);
        }

        //Metodo para eliminar
        public async Task Delete(Cuentas cuentas)
        {
            await _connection.DeleteAsync(cuentas);
        }

    }
}
