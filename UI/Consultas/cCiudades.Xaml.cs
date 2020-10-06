using System;
using System.Windows;
using System.Collections.Generic;
using Albenny_P1_AP1.BLL;
using Albenny_P1_AP1.Entidades;

namespace Albenny_P1_AP1.UI.Consultas
{
    public partial class cCiudades : Window
    {
        public cCiudades()
        {
            InitializeComponent();
        }
        private void ConsultarButton_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<Ciudades>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        try
                        {
                            listado = CiudadesBLL.GetList(c => c.CiudadId == Utilidades.ToInt(CriterioTextBox.Text));
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("este criterio no es valido, agrega uno que si sea valido.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        break;
                    case 1:
                        try
                        {
                            listado = CiudadesBLL.GetList(n => n.Nombre.Contains(CriterioTextBox.Text));
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("este criterio no es valido, agrega uno que si lo sea.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        break;
                }
            }
            else
            {
                listado = CiudadesBLL.GetList(c => true);
            }

            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;
        }
