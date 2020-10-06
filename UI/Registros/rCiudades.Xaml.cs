using Albenny_P1_AP1.BLL;
using Albenny_P1_AP1.Entidades;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;


namespace Albenny_P1_AP1.UI.Registros
{
    public partial class rCiudades : Window
    {
        private Ciudades ciudades = new Ciudades();
        public rCiudades()
        {
            InitializeComponent();
            this.DataContext = ciudades;
        }
        //Limpiar//
        private void Limpiar()
        {
            this.ciudades = new Ciudades();
            this.DataContext = ciudades;
        }

        //validar//
        private bool Validar()
        {
            bool esValido = true;
            if (CiudadIdTextbox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("NO ES VALIDO", "ERROR", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            return esValido;
        }
        //Buscar//
        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var ciudad = CiudadesBLL.Buscar(Utilidades.ToInt(CiudadIdTextbox.Text));
            if (ciudad != null)
                this.ciudades = ciudad;
            else
                this.ciudades = new Ciudades();
            this.DataContext = this.ciudades;
        }
        //Nuevo//
        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }
        //Guardar//
        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            {
                if (!Validar())
                    return;

                if (NombreTextbox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("El campo Nombre esta vacio.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    NombreTextbox.Focus();
                    return;
                }

                var paso = CiudadesBLL.Guardar(ciudades);
                if (paso)
                {
                    Limpiar();
                    MessageBox.Show("Transaccion Exitosa!", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                    MessageBox.Show("Transaccion Fallida", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        //Eliminar
        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            {
                if (CiudadesBLL.Eliminar(Utilidades.ToInt(CiudadIdTextbox.Text)))
                {
                    Limpiar();
                    MessageBox.Show("Registro Eliminado!", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                    MessageBox.Show("No fue posible eliminar", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}