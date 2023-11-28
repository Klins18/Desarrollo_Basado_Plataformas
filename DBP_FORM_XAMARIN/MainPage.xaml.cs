using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace YourNamespace
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            EnviarButton.Clicked += EnviarButton_Clicked;
        }

        private void EnviarButton_Clicked(object sender, EventArgs e)
        {
            string nombre = NombreEntry.Text;
            DateTime fechaNacimiento = FechaDatePicker.Date;
            string correo = CorreoEntry.Text;
            string telefono = TelefonoEntry.Text;
            string direccion = DireccionEntry.Text;
            string nacionalidad = NacionalidadPicker.SelectedItem?.ToString();

            string nivelIngles = ObtenerNivelIngles();
            List<string> lenguajesSeleccionados = ObtenerLenguajesSeleccionados();

            string ocupacion = OcupacionEntry.Text;
            string aptitudes = AptitudesEntry.Text;

            List<string> habilidades = ObtenerHabilidadesSeleccionadas();
            string perfil = PerfilEditor.Text;

            MostrarAlerta("Datos del formulario", $"Nombre: {nombre}\nFecha de Nacimiento: {fechaNacimiento}\nCorreo: {correo}\nTeléfono: {telefono}\nDirección: {direccion}\nNacionalidad: {nacionalidad}\nNivel de inglés: {nivelIngles}\nLenguajes: {string.Join(", ", lenguajesSeleccionados)}\nOcupación: {ocupacion}\nAptitudes: {aptitudes}\nHabilidades: {string.Join(", ", habilidades)}\nPerfil: {perfil}");
        }

        private string ObtenerNivelIngles()
        {
            if (BasicoRadio.IsChecked) return "Básico";
            if (IntermedioRadio.IsChecked) return "Intermedio";
            if (AvanzadoRadio.IsChecked) return "Avanzado";

            return string.Empty;
        }

        private List<string> ObtenerLenguajesSeleccionados()
        {
            return LenguajesPicker.SelectedItems.ToList();
        }

        private List<string> ObtenerHabilidadesSeleccionadas()
        {
            List<string> habilidades = new List<string>();

            if (CreatividadCheckbox.IsChecked) habilidades.Add("Creatividad");
            if (FlexibilidadCheckbox.IsChecked) habilidades.Add("Flexibilidad");
            if (InnovarCheckbox.IsChecked) habilidades.Add("Innovar y crear");

            return habilidades;
        }

        private void MostrarAlerta(string titulo, string mensaje)
        {
            DisplayAlert(titulo, mensaje, "OK");
        }
    }
}
