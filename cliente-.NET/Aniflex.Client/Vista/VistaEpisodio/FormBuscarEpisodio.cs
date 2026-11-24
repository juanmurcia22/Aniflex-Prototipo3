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

namespace Aniflex.Client.Vista.VistaEpisodio
{
    public partial class FormBuscarEpisodio : Form
    {
        private string? idCargado;
        private readonly ServicioEpisodio _service = ServicioEpisodio.GetInstance();

        public FormBuscarEpisodio()
        {
            InitializeComponent();

        }

        private async void btnBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                idCargado = null;
                textBoxID.Clear();
                Episodio ep = await _service.BuscarPorCodigoAsync(txtNumEliminar.Text.Trim());

                if (ep != null)
                {
                    idCargado = ep.Id;
                    textBoxID.Text = ep.Codigo;
                    txtTitulo.Text = ep.Titulo;
                    txtCalificacion.Text = ep.Calificacion.ToString();
                    txtNumEpisodio.Text = ep.NoEpisodio.ToString();
                    chkEsEspecial.Checked = ep.EsEspecial;
                    txtSerie.Text = ep.SerieId.ToString();

                    if (DateTime.TryParse(ep.FechaEmision, CultureInfo.InvariantCulture,
                            DateTimeStyles.None, out DateTime fecha))
                    {
                        dateTimePickerEstreno.Value = fecha;
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró un episodio con ese ID manual.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la búsqueda: {ex.Message}");
            }
        }
    }
}
