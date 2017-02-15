using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using WindowsFormesMVVM.Models;

namespace WindowsFormesMVVM.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            var result = initCouleurs();
            ComboBoxCouleurs = new ObservableCollection<Couleur>(result);
            BtnValider = new RelayCommand(ActionSetForm);
        }



        private ObservableCollection<Couleur> _comboBoxCouleurs;
        private ICommand _btnValider;
        private String _width;
        private String _height;
        private ComboBoxItem _comboBoxFormeItem;
        private ComboBoxItem _comboBoxTransformItem;

        public ComboBoxItem ComboBoxTransformItem
        {
            get { return _comboBoxTransformItem; }
            set { _comboBoxTransformItem = value; }
        }


        public ComboBoxItem ComboBoxFormeItem
        {
            get { return _comboBoxFormeItem; }
            set { _comboBoxFormeItem = value; }
        }


        public String Height
        {
            get { return _height; }
            set { _height = value; }
        }


        public String Width
        {
            get { return _width; }
            set { _width = value; }
        }


        public ObservableCollection<Couleur> ComboBoxCouleurs
        {
            get { return _comboBoxCouleurs; }
            set
            {
                _comboBoxCouleurs = value;
                RaisePropertyChanged();
            }
        }

        public ICommand BtnValider
        {
            get { return _btnValider; }
            set
            {
                _btnValider = value;
                RaisePropertyChanged();
            }
        }



        private void ActionSetForm()
        {

            /*RectangleViewModel rectangle = new RectangleViewModel();
            rectangle.Fill = new SolidColorBrush(Windows.UI.Colors.Red);
            rectangle.Height = Convert.ToInt32(Height);
            rectangle.Width = Convert.ToInt32(Width);
            */

        }



        public List<Couleur> initCouleurs()
        {
            List<Couleur> listColors = new List<Couleur>();
            listColors.Add(new Couleur("Rouge", new SolidColorBrush(Windows.UI.Colors.Red)));
            listColors.Add(new Couleur("Bleu", new SolidColorBrush(Windows.UI.Colors.Blue)));
            listColors.Add(new Couleur("Jaune", new SolidColorBrush(Windows.UI.Colors.Yellow)));
            listColors.Add(new Couleur("Blanc", new SolidColorBrush(Windows.UI.Colors.White)));

            return listColors;
        }


    }
}
