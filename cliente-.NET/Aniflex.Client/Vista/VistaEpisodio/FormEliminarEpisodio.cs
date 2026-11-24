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

namespace Aniflex.Client.Vista.VistaEpisodio
{
    public partial class FormEliminarEpisodio : Form
    {
        private string? idCargado;
        private readonly ServicioEpisodio _service = ServicioEpisodio.GetInstance();
        public FormEliminarEpisodio()
        {
            InitializeComponent();

        }

        private void LimpiarCampos()
        {
            idCargado = null;
            textBoxID.Clear();
            txtNumEpisodio.Clear();
            txtTitulo.Clear();
            txtCalificacion.Clear();
            chkEsEspecial.Checked = false;
            txtSerie.Clear();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
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

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = idCargado ?? "";

                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Busca primero el episodio que deseas eliminar.");
                    return;
                }

                var confirmacion = MessageBox.Show("¿Estás seguro de que deseas eliminar este episodio?",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    bool eliminado = await _service.EliminarAsync(id);

                    if (eliminado)
                    {
                        MessageBox.Show("Episodio eliminado correctamente.");
                        EpisodioObserver.NotificarCambio();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar o el ID no existe.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar: {ex.Message}");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
