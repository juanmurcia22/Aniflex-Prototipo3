using System.ComponentModel;

namespace Aniflex.Client.Vista.VistaEstudio;

public partial class FormBuscarEstudio : FormDetalleEstudio
{
    public FormBuscarEstudio()
    {
        InitializeComponent();
        if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
        Preparar(OperacionEstudio.Buscar, detalle, objectId, codigo, nombre, pais, fecha, series,
            codigoBusqueda: codigoBusqueda);
    }

    public FormBuscarEstudio(string codigoManual) : this()
    {
        BuscarAlAbrir(codigoManual);
    }
}
