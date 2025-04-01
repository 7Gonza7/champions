using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Champions_League
{
    public partial class InformacionDeEquipo : Form
    {
        DataTable dtChampions = new DataTable("Champions");
        int indiceTAbla = -1;
        public InformacionDeEquipo()
        {
            InitializeComponent();
            GenerarColumnas();
            CargarProducto();
        }
        private void GenerarColumnas()
        {
            dtChampions.Columns.Add("NombreDeEquipo", typeof(string));
            dtChampions.Columns.Add("NombreDeEntrenador", typeof(string));
            dtChampions.Columns.Add("PresidenteDeEquipo", typeof(string));
            dtChampions.Columns.Add("NumeroDeChampions", typeof(int));

            Tabla.DataSource = dtChampions;
        }
        private DataTable GenerarTabla(string NombreDeEquipo, string NombreDeEntrenador, string PresidenteDeEquipo, int NumeroDechampions, int indice)
        {
            if (indice < 0)
            {
                DataRow fila = dtChampions.NewRow();
                fila["NombreDeEquipo"] = NombreDeEquipo;
                fila["NombreDeEntrenador"] = NombreDeEntrenador;
                fila["PresidenteDeEquipo"] = PresidenteDeEquipo;
                fila["NumeroDeChampions"] = NumeroDechampions;

                dtChampions.Rows.Add(fila);
            }
            else
            {
                dtChampions.Rows[indice]["NombreDeEquipo"] = NombreDeEquipo;
                dtChampions.Rows[indice]["NombreDeEntrenador"] = NombreDeEntrenador;
                dtChampions.Rows[indice]["PresidenteDeEquipo"] = PresidenteDeEquipo;
                dtChampions.Rows[indice]["NumeroDeChampions"] = NumeroDechampions;
            }
            return dtChampions;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombreEquipo.Text) && !string.IsNullOrEmpty(txtEntrenador.Text) && !string.IsNullOrEmpty(txtPresidente.Text) && (nudChampions.Value > 0))
            {
                Tabla.DataSource = GenerarTabla(txtNombreEquipo.Text, txtEntrenador.Text, txtPresidente.Text, (int)nudChampions.Value, indiceTAbla);
                limpiar();
            }
            else
            {
                if (string.IsNullOrEmpty(txtNombreEquipo.Text)) MessageBox.Show("Ingrese nombre");
                if (string.IsNullOrEmpty(txtEntrenador.Text)) MessageBox.Show("ingrese Nombre");
                if (string.IsNullOrEmpty(txtPresidente.Text)) MessageBox.Show("Ingrese Presidente");
                if (nudChampions.Value <= 0) MessageBox.Show("Ingrese Champions");
            }
        }
        private void limpiar()
        {
            txtNombreEquipo.Clear();
            txtEntrenador.Clear();
            txtPresidente.Clear();
            nudChampions.Value = 0;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (Tabla.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar la fila seleccionada?", "Confirmar eliminación", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in Tabla.SelectedRows)
                    {
                        Tabla.Rows.RemoveAt(row.Index);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.");
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFiltro.Text))
            {
                try
                {
                    DataView tablaFiltrada = new DataView(dtChampions);
                    string filtro = txtFiltro.Text.Replace("'", "''");
                    tablaFiltrada.RowFilter = $"NombreDeEquipo = '{filtro}'";


                    if (tablaFiltrada.Count == 0)
                    {
                        MessageBox.Show("No se encontraron resultados.");
                    }
                    else
                    {
                        Tabla.DataSource = tablaFiltrada;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al filtrar: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un nombre de equipo para filtrar.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Tabla.SelectedRows.Count > 0) 
            {
                DataGridViewRow filaSeleccionada = Tabla.SelectedRows[0];

          
                txtNombreEquipo.Text = filaSeleccionada.Cells["NombreDeEquipo"].Value.ToString();
                txtEntrenador.Text = filaSeleccionada.Cells["NombreDeEntrenador"].Value.ToString();
                txtPresidente.Text = filaSeleccionada.Cells["PresidenteDeEquipo"].Value.ToString();
                nudChampions.Value = Convert.ToDecimal(filaSeleccionada.Cells["NumeroDeChampions"].Value);

                
                indiceTAbla = filaSeleccionada.Index; 
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para editar.");
            }            
        }
        private void CargarProducto()
        {
            cmbGrupo.Items.Insert(0, "selecciones");
            cmbGrupo.Items.Insert(1, "A");
            cmbGrupo.Items.Insert(2, "B");
            cmbGrupo.Items.Insert(3, "C");
            cmbGrupo.Items.Insert(4, "D");
            cmbGrupo.Items.Insert(5, "E");
            cmbGrupo.Items.Insert(6, "F");
            cmbGrupo.Items.Insert(7, "G");
            cmbGrupo.Items.Insert(8, "H");

            cmbGrupo.SelectedIndex = 0;
        }
        private void Form_Load(object sender, EventArgs e)
        {
            
            Tabla.DataSource = dtChampions;

            
            Tabla.Columns["NombreDeEquipo"].Width = 150; 
            Tabla.Columns["NombreDeEntrenador"].Width = 120;
            Tabla.Columns["PresidenteDeEquipo"].Width = 130;
            Tabla.Columns["NumeroDeChampions"].Width = 100;

        }
    }
}
