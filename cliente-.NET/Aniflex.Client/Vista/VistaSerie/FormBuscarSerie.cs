using Aniflex.Client.Controlador;
using Aniflex.Client.Modelo;
using Aniflex.Client.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace Aniflex.Client
{
    public partial class FormBuscarSerie : Form
    {
        private readonly ServicioSerie _service = ServicioSerie.GetInstance();
        public FormBuscarSerie()
        {
            InitializeComponent();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtId.Text.Trim();

                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Ingresa el ID manual de la serie.");
                    return;
                }

                textBoxID.Clear();
                Serie p = await _service.BuscarPorCodigoAsync(id);

                if (p != null)
                {
                    textBoxID.Text = p.Id;
                    txtTitulo.Text = p.Titulo;
                    txtTemporadas.Text = p.Temporadas.ToString();
                    txtCalificacion.Text = p.Calificacion.ToString();
                    chkEnEmision.Checked = p.EnEmision;
                    if (DateTime.TryParse(p.FechaEstreno, CultureInfo.InvariantCulture,
                          DateTimeStyles.None, out DateTime fecha))
                    {
                        dateTimePickerEstreno.Value = fecha;
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró ninguna serie con esos datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la búsqueda: {ex.Message}");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormBuscar_Load(object sender, EventArgs e)
        {

        }
    }
}
