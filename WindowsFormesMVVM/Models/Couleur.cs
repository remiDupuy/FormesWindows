using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;

namespace WindowsFormesMVVM.Models
{
    public class Couleur
    {
        private String libelle;
        private SolidColorBrush brush;



        public SolidColorBrush Brush
        {
            get
            {
                return brush;
            }

            set
            {
                brush = value;
            }
        }

        public string Libelle
        {
            get
            {
                return libelle;
            }

            set
            {
                libelle = value;
            }
        }

        public Couleur(String unLib, SolidColorBrush unBrush)
        {
            Libelle = unLib;
            Brush = unBrush;
        }

        public override string ToString()
        {
            return this.Libelle;
        }
    }
}
