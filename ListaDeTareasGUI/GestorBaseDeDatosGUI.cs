using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using static System.Windows.Forms.MonthCalendar;

public class GestorBaseDatos
{
    // Esta clase tiene como finalidad crear lo necesario para trabajar con la base de datos.
    // Por otro lado, ejecutrar las operaciones CRUD en la base de datos.

    public static void CrearBaseDeDatos()
    {
        // Nombre para la base de datos.
        String rutaBaseDeDatos = "ListaDeTareas.db";

        // Si no existe, entonces crea el archivo de la base de datos.
        if (!File.Exists(rutaBaseDeDatos))
        {
            SQLiteConnection.CreateFile(rutaBaseDeDatos);
        }
    }

    public static void CrearTabla()
    {
        String rutaBaseDeDatos = "ListaDeTareas.db";

        // Conexion a la base de datos.

        using (SQLiteConnection conexion = new SQLiteConnection("Data Source=" + rutaBaseDeDatos + ";Version=3;"))
        {
            conexion.Open();
            // Crear la tabla, en caso de que no exista ya.
            String codigoSQL = "CREATE TABLE IF NOT EXISTS Tareas (IdTarea INTEGER PRIMARY KEY AUTOINCREMENT, NombreTarea TEXT, DescripcionTarea TEXT, PrioridadTarea TEXT)";
            SQLiteCommand ejecutarQuery = new SQLiteCommand(codigoSQL, conexion);
            ejecutarQuery.ExecuteNonQuery();
            conexion.Close();
        }
    }

    // Este metodo requiere parametros en su llamada. Recaba informacion pertinente previo a insertar en la BD.
    public static void InsertarTarea(String nombreTarea, String descripcionTarea, String prioridadTarea)
    {
        String rutaBaseDeDatos = "ListaDeTareas.db";
        // Conexion a la base de datos.
        using (SQLiteConnection conexion = new SQLiteConnection("Data Source=" + rutaBaseDeDatos + ";Version=3;"))
        {
            conexion.Open();

            String codigoSQL = "INSERT INTO Tareas (NombreTarea, DescripcionTarea, PrioridadTarea) VALUES (@nombre, @descripcion, @prioridad)";
            using (SQLiteCommand ejecutarQuery = new SQLiteCommand(codigoSQL, conexion))
            {
                ejecutarQuery.Parameters.AddWithValue("@nombre", nombreTarea);
                ejecutarQuery.Parameters.AddWithValue("@descripcion", descripcionTarea);
                ejecutarQuery.Parameters.AddWithValue("@prioridad", prioridadTarea);
                ejecutarQuery.ExecuteNonQuery();
            }
            conexion.Close();
            Console.WriteLine("Tarea agregada correctamente.");
        }
    }

    // Eliminar una tarea por medio del ID.

    public static void ElminarTarea(int idTarea)
    {
        
        // Conexion a la base de datos
        String rutaBaseDeDatos = "ListaDeTareas.db";

        using (SQLiteConnection conexion = new SQLiteConnection("Data Source = " + rutaBaseDeDatos + " ;Version=3;"))

        {
            conexion.Open();
            // Mostramos todas las tareas pendientes con su respectivo id.
            String codigoSQLEliminar = "DELETE FROM Tareas where IdTarea = @idTarea;";

            // Eliminar la tarea seleccionada por el usuario.
            using (SQLiteCommand ejecutarQueryEliminar = new SQLiteCommand(codigoSQLEliminar, conexion))
            {
                ejecutarQueryEliminar.Parameters.AddWithValue("@idTarea", idTarea);
                ejecutarQueryEliminar.ExecuteNonQuery();
                Console.WriteLine("Tarea completada correctamente.");
            }

        }

    }

    public static void ActualizarTareas()
    {
        // Conexion a la base de datos
        String rutaBaseDeDatos = "ListaDeTareas.db";

        using (SQLiteConnection conexion = new SQLiteConnection("Data Source = " + rutaBaseDeDatos + " ;Version=3;"))

        {
            conexion.Open();
            // Mostramos todas las tareas pendientes con su respectivo id.
            String codigoSQLEliminar = "SELECT * FROM Tareas;";

            // Eliminar la tarea seleccionada por el usuario.
            using (SQLiteCommand ejecutarQueryEliminar = new SQLiteCommand(codigoSQLEliminar, conexion));
            

        }

    }

    

}
