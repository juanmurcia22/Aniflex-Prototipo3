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
using Aniflex.Client.Controlador;

namespace Aniflex.Client.Vista.VistaEpisodio
{
    public partial class FormActualizarEpisodio : Form
    {
        private string? idCargado;
        private readonly ServicioEpisodio _service = ServicioEpisodio.GetInstance();
        public FormActualizarEpisodio()
        {
            InitializeComponent();

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

                    txtTitulo.Enabled = true;
                    txtCalificacion.Enabled = true;
                    txtNumEpisodio.Enabled = true;
                    chkEsEspecial.Enabled = true;
                    dateTimePickerEstreno.Enabled = true;
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

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = idCargado ?? "";
                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Busca primero el episodio que deseas actualizar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string serieId = txtSerie.Text.Trim();
                if (string.IsNullOrEmpty(serieId))
                {
                    MessageBox.Show("El episodio no tiene serie asociada.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string titulo = txtTitulo.Text.Trim();
                if (string.IsNullOrEmpty(titulo))
                {
                    MessageBox.Show("El título es obligatorio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtNumEpisodio.Text, out int noEpisodio) || noEpisodio < 1)
                {
                    MessageBox.Show("El nº de episodio debe ser un entero mayor o igual a 1.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(txtCalificacion.Text, out double calificacion))
                {
                    MessageBox.Show("La calificación debe ser un valor numérico válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Episodio epEditado = new Episodio
                {
                    Id = id,
                    Codigo = textBoxID.Text.Trim(),
                    SerieId = serieId,
                    NoEpisodio = noEpisodio,
                    Titulo = titulo,
                    Calificacion = calificacion,
                    EsEspecial = chkEsEspecial.Checked,
                    FechaEmision = dateTimePickerEstreno.Value.ToString("yyyy-MM-dd'T'HH:mm:ss", CultureInfo.InvariantCulture)
                };

                Episodio resultado = await _service.ActualizarAsync(epEditado);

                if (resultado != null)
                {
                    MessageBox.Show("Episodio actualizado exitosamente.");
                    EpisodioObserver.NotificarCambio();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar: {ex.Message}");
            }
        }
    }
}
