using System.ComponentModel;

namespace Aniflex.Client.Vista.VistaEstudio;

public partial class FormEliminarEstudio : FormDetalleEstudio
{
    public FormEliminarEstudio()
    {
        InitializeComponent();
        if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
        Preparar(OperacionEstudio.Eliminar, detalle, objectId, codigo, nombre, pais, fecha, series,
            accion: accion, codigoBusqueda: codigoBusqueda);
    }
}
