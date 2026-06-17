using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDulceriaCine
{
    public static class ManejadorArchivo
    {
        private static string ruta = "inventario_dulceria.dat";
        // --- OPERACIÓN DE ESCRITURA (GUARDAR) ---
        public static void GuardarInventario(List<Producto> lista)
        {
            try
            {
                // BinaryWriter traduce los datos primitivos a bytes
                using (FileStream fs = new FileStream(ruta, FileMode.Create))
                using (BinaryWriter escritor = new BinaryWriter(fs))
                {
                    // 1. Guardamos la cantidad total de productos para saber cuántos leer después
                    escritor.Write(lista.Count);

                    // 2. Guardamos propiedad por propiedad en orden estricto
                    foreach (Producto prod in lista)
                    {
                        escritor.Write(prod.Id);
                        escritor.Write(prod.Nombre);
                        escritor.Write(prod.Precio);
                        escritor.Write(prod.Existencia);
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error de entrada/salida: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado al guardar: " + ex.Message);
            }
        }

        // --- OPERACIÓN DE LECTURA (CARGAR) ---
        public static List<Producto> CargarInventario()
        {
            List<Producto> listaRecuperada = new List<Producto>();

            if (!File.Exists(ruta)) return listaRecuperada;

            try
            {
                // BinaryReader reconstruye los bytes a datos primitivos
                using (FileStream fs = new FileStream(ruta, FileMode.Open))
                using (BinaryReader lector = new BinaryReader(fs))
                {
                    // 1. Leemos cuántos productos hay en el archivo
                    int cantidadProductos = lector.ReadInt32();

                    // 2. Reconstruimos los objetos respetando el mismo orden en que los guardamos
                    for (int i = 0; i < cantidadProductos; i++)
                    {
                        int id = lector.ReadInt32();
                        string nombre = lector.ReadString();
                        double precio = lector.ReadDouble();
                        int existencia = lector.ReadInt32();

                        Producto prod = new Producto(id, nombre, precio, existencia);
                        listaRecuperada.Add(prod);
                    }
                }
            }
            catch (EndOfStreamException)
            {
                MessageBox.Show("Error: El archivo está incompleto o corrupto.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }

            return listaRecuperada;
        }
        }
}
