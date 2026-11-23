using System.ComponentModel;

namespace Aniflex.Client.Vista.VistaEstudio;

public partial class FormAgregarEstudio : FormDetalleEstudio
{
    public FormAgregarEstudio()
    {
        InitializeComponent();
        if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
        Preparar(OperacionEstudio.Agregar, detalle, objectId, codigo, nombre, pais, fecha, series,
            accion: accion, serieCodigo: serieCodigo);
    }
}
