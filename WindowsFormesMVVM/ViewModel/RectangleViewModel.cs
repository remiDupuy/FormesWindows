using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using Windows.UI.Xaml.Media;

namespace WindowsFormesMVVM.ViewModel
{
    public class RectangleViewModel : ViewModelBase
    {
        public RectangleViewModel()
        {
            
        }

        private SolidColorBrush _fill;
        private Double _width;
        private Double _height;

        public Double Height
        {
            get { return _height; }
            set { _height = value; }
        }


        public Double Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public SolidColorBrush Fill
        {
            get { return _fill; }
            set { _fill = value; }
        }

    }
}
