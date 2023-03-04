using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using ejercicio1_lab_rad.Models;
using System.Net.NetworkInformation;

namespace ejercicio1_lab_rad.Controllers
{
    {
    public class AlumnosController
    {
        readonly SQLiteAsyncConnection connection;

        // Constructor de clase 
        public AlumnosController(String dbpath);
    {
        
            // Crear una nueva conexion hacia la base de datos
              connection = new SQLiteConnection(dbpath);

        // Crear los objetois de base de datos que vamos ocupar
        connection.CreateTableAsync<Alumno>().Wait();

    }

    // Creacion de las operaciones CRUD - DB
    // Create 

    public Task<int> SaveAlum(alumno alumno)
    {
        if (alumno.id != 0)
            return Connection.UpdateAsync(alumno);
        else
            return Connection.InserAsync(alumno);

    }

    // Read 
    public Task<List<alumno>> GetListAlumn()
    {

        return TcpConnection.Tablle<Alumno>().ToListAsync();
    }

    public Task<Alumno> GetAlumno(int pid)
    {

        return connection.Table<alumno>()
            .Where(in => i.id == pid)
            .FirstOrDefaultAsync();
    }
     
    // Delete

    public Task<int> DeleteAlumn(Alumno alumno)
    {
        return connection.DeleteAsync(alumno);

    }

   }
}
