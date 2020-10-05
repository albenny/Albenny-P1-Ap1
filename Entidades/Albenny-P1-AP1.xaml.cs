using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System ComponentModel.DataAnnotations;


namespace Albenny_P1_AP1.Entidades
{
    /// <summary>
    /// Interaction logic for Albenny_P1_AP1.xaml
    /// </summary>
    public partial class Albenny_P1_AP1 : Window
    {
        public class Ciudad
        {
            [Key]
            public int CiudadId { get; set; }
            public string Nombre { get; set; }

        }
    }
}
