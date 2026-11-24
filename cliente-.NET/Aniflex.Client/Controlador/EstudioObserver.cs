namespace Aniflex.Client.Controlador;

public static class EstudioObserver
{
    public static event Action? OnEstudiosCambiados;
    public static void NotificarCambio() => OnEstudiosCambiados?.Invoke();
}
