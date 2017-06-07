using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;

namespace ColorPalettes.ViewModels
{
    class ColorPageViewModel : INotifyPropertyChanged
    {
        private Color color;
        private SolidColorBrush brush;

        public Color Color { get => this.color; set => Set(ref this.color, value); }
        public SolidColorBrush Brush { get => this.brush; set => Set(ref this.brush,value); }


        public ColorPageViewModel()
        {
            color = new Color();
            brush = new SolidColorBrush(color);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void Set<T>(ref T target, T value, [CallerMemberName] String propertyName = "")
        {
            if (Equals(target, value))
            {
                return;
            }

            target = value;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
