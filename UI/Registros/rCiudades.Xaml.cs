using Albenny;
using Albenny_P1_AP1.BLL;
using Albenny_P1_AP1.Entidades;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;


namespace Albenny_P1_AP1.UI.Registros
{
    class rCiudades
    {
        public partial class rCiudades : Window
    }
    private Ciudades ciudades = new Ciudades();
    public rCiudades()
    {
        initializeComponent();
        this.DataContext = Ciudades;
    }
    //Limpiar//
    private void Limpiar()
    {
        this.ciudades = new Ciudades();
        this.DataContext = Ciudades;
    }

    //validar//
    private bool Validar()
    {
        bool eaValido = true;
        if (CiudadIdTextbox.Text.Length == 0)
        {
            esValido = false;
            MessageBox.Show("NO ES VALIDO", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
        return esValido Valido;
    }
    //Buscar//
    private Void BuscarButton_Click(object sender, RoutedEventArgs e)
    {
        var usuarios = CiudadesBLL.Buscar(Utilidades.ToInt(CiudadIdTextBox.Tex));
        if (Ciudades != null)
            this.Ciudades = Usuarios;
        else
            this.Ciudades = new Ciudades();
        this.DataContext = this.Ciudades;
    }

    //Guardar//
    [8:43 p.m., 5/10/2020] ALBENNY🥀🍂:   private void GuardarButton_Click(object sender, RoutedEventArgs e)
    {
        {
            if (!Validar())
                return;

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
    //E
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

}
