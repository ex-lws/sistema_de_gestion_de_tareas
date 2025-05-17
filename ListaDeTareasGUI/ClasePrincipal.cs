using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

// Esta clase contiene el método Main, que es el punto de entrada de la aplicación GUI.

namespace ListaDeTareasGUI
{
    internal class ClasePrincipal
    {
        static void Main()
        {
            // Iniciarlizar y crear la base de datos perteneciente al programa.
            GestorBaseDatos.CrearBaseDeDatos();
            GestorBaseDatos.CrearTabla();

            // Inicializar la interfaz grafica.
            ApplicationConfiguration.Initialize();
            Application.Run(new VentanaMenuPrincipal());

        }
    }
}
