
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace MiPresentacionDilanTapia;

public partial class MainWindow : Window
{
    private bool saludoAlternativo = false;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void Presentarme_Click(object? sender, RoutedEventArgs e)
    {
        string nombre = txtNombre.Text?.Trim() ?? "";
        string apellido = txtApellido.Text?.Trim() ?? "";
        string edadTexto = txtEdad.Text?.Trim() ?? "";

        if (string.IsNullOrWhiteSpace(nombre))
        {
            txtResultado.Text = "Debes ingresar tu nombre.";
            return;
        }

        if (string.IsNullOrWhiteSpace(apellido))
        {
            txtResultado.Text = "Debes ingresar tu apellido.";
            return;
        }

        if (!int.TryParse(edadTexto, out int edad) || edad <= 0)
        {
            txtResultado.Text = "Ingresa una edad entera positiva.";
            return;
        }

        txtResultado.Text = $"Hola mi nombre es {nombre} {apellido},\ntengo {edad} años y estoy aprendiendo\na desarrollar interfaces graficas con C#.";
    }

    private void Limpiar_Click(object? sender, RoutedEventArgs e)
    {
        txtNombre.Text = "";
        txtApellido.Text = "";
        txtEdad.Text = "";

        txtResultado.Text = "Aqui aparecera la presentacion.";

        txtNombre.Focus();
    }

    private void CambiarSaludo_Click(object? sender, RoutedEventArgs e)
    {
        saludoAlternativo = !saludoAlternativo;

        if (saludoAlternativo)
        {
            txtResultado.Text = "Bienvenido, estoy dando mis primeros pasos en el desarrollo de aplicaciones de escritorio con C# y Avalonia";
        }
        else
        {
            txtResultado.Text = "Hola estoy aprendiendo a desarrollar interfaces graficas con C#.";
        }
    }
}
