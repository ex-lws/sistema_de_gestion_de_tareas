using System;

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
}
