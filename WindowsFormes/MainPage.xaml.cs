using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;
using WindowsFormes.Models;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WindowsFormes
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            initCouleurs();
        }


        private async void btnValider_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.grille.Children.Clear();

                Shape myShape = null;
                if (this.cbxForme.SelectionBoxItem.ToString() == "Rectangle")
                {
                    myShape = new Rectangle();
                }
                else if (this.cbxForme.SelectionBoxItem.ToString() == "Cercle")
                {
                    myShape = new Ellipse();
                }

                myShape.Fill = ((Couleur)this.cbxInnerColor.SelectedItem).Brush;
                myShape.Stroke = ((Couleur)this.cbxExternColor.SelectedItem).Brush;
                myShape.Height = Convert.ToInt32(txtHeight.Text);
                myShape.Width = Convert.ToInt32(txtWidth.Text);

                this.grille.Children.Add(myShape);
            }
            catch (Exception ex)
            {
                String msg = "";

                if(ex.GetType() == typeof(NullReferenceException))
                {
                    msg = "Champ(s) manquant(s)";
                }
                else if(ex.GetType() == typeof(FormatException))
                {
                    msg = "Format incorrect";
                }

                MessageDialog msgDialog = new MessageDialog(msg);
                await msgDialog.ShowAsync();
            }

        }

        private void cbxForme_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public void initCouleurs()
        {
            List<Couleur> listColors = new List<Couleur>();
            listColors.Add(new Couleur("Rouge", new SolidColorBrush(Windows.UI.Colors.Red)));
            listColors.Add(new Couleur("Bleu", new SolidColorBrush(Windows.UI.Colors.Blue)));
            listColors.Add(new Couleur("Jaune", new SolidColorBrush(Windows.UI.Colors.Yellow)));
            listColors.Add(new Couleur("Blanc", new SolidColorBrush(Windows.UI.Colors.White)));
            this.cbxInnerColor.DataContext = listColors;
            this.cbxExternColor.DataContext = listColors;
        }
    }
}
