using System.ComponentModel;

namespace SistemaDulceriaCine
{
    public partial class FrmDulceria : Form
    {
        private BindingList<Producto> listaProductos;

        public FrmDulceria()
        {
            InitializeComponent();
        }

        private void FrmDulceria_Load(object sender, EventArgs e)
        {
            List<Producto> datosCargados = ManejadorArchivo.CargarInventario();
            listaProductos = new BindingList<Producto>(datosCargados);
            dgvInventario.DataSource = listaProductos;
            lblProductos.Text = $"Productos en Inventario: {listaProductos.Count}";
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de entrada simple
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    throw new Exception("El nombre del producto no puede estar vacío.");
                }

                if (numPrecio.Value <= 0 || numExistencia.Value < 0)
                {
                    throw new Exception("El precio o existencia debe ser mayor a cero.");
                }

                // Creamos el nuevo objeto
                Producto nuevo = new Producto(
                    listaProductos.Count + 1, // ID auto-generado
                    txtNombre.Text,
                    (double)numPrecio.Value,
                    (int)numExistencia.Value
                );

                // Agregamos a la lista visual
                listaProductos.Add(nuevo);

                ManejadorArchivo.GuardarInventario(new List<Producto>(listaProductos));

                LimpiarCampos();
                MessageBox.Show("Producto registrado y guardado en archivo binario.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            numPrecio.Value = 0;
            numExistencia.Value = 0;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInventario.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un producto.");
                    return;
                }

                Producto seleccionado =
                    (Producto)dgvInventario.CurrentRow.DataBoundItem;

                listaProductos.Remove(seleccionado);

                ManejadorArchivo.GuardarInventario(
                    new List<Producto>(listaProductos));

                lblProductos.Text =
                    $"Productos en Inventario: {listaProductos.Count}";

                MessageBox.Show("Producto eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void btnAgregarExistencia_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInventario.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un producto.");
                    return;
                }

                int cantidad = (int)numCantidad.Value;

                if (cantidad <= 0)
                {
                    MessageBox.Show("Ingrese una cantidad válida.");
                    return;
                }

                Producto producto =
                    (Producto)dgvInventario.CurrentRow.DataBoundItem;

                producto.Existencia += cantidad;

                dgvInventario.Refresh();

                ManejadorArchivo.GuardarInventario(
                    new List<Producto>(listaProductos));

                MessageBox.Show("Existencias actualizadas.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDisminuirExistencias_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInventario.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un producto.");
                    return;
                }

                int cantidad = (int)numCantidad.Value;

                if (cantidad <= 0)
                {
                    MessageBox.Show("Ingrese una cantidad válida.");
                    return;
                }

                Producto producto =
                    (Producto)dgvInventario.CurrentRow.DataBoundItem;

                if (producto.Existencia < cantidad)
                {
                    MessageBox.Show(
                        "No hay suficientes existencias para realizar la operación.");
                    return;
                }

                producto.Existencia -= cantidad;

                dgvInventario.Refresh();

                ManejadorArchivo.GuardarInventario(
                    new List<Producto>(listaProductos));

                MessageBox.Show("Existencias actualizadas.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
