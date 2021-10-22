using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace CustomTreeViewItem
{
    public partial class VSCodeItems
    {
        internal Thickness MarginThickness
        {
            get { return (Thickness)GetValue(MarginThicknessProperty); }
            set { SetValue(MarginThicknessProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MarginThickness.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MarginThicknessProperty =
            DependencyProperty.Register("MarginThickness", typeof(Thickness), typeof(VSCodeItems), new PropertyMetadata(new Thickness(10015, 0, 5, 0)));

        public Brush HighlightedColor
        {
            get { return (Brush)GetValue(HighlightedColorProperty); }
            set { SetValue(HighlightedColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HighlightedColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HighlightedColorProperty =
            DependencyProperty.Register("HighlightedColor", typeof(Brush), typeof(VSCodeItems), new PropertyMetadata(new SolidColorBrush(Color.FromArgb(0xAA, 0x31, 0x31, 0x31))));


        public ImageSource CheckedImageSource
        {
            get { return (ImageSource)GetValue(CheckedImageSourceProperty); }
            set { SetValue(CheckedImageSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CheckedImageSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CheckedImageSourceProperty =
            DependencyProperty.Register("CheckedImageSource", typeof(ImageSource), typeof(VSCodeItems), new PropertyMetadata(new BitmapImage(new Uri("pack://application:,,,/CustomTreeViewItem;Component/Images/ArrowDown.png"))));
        public ImageSource UncheckedImageSource
        {
            get { return (ImageSource)GetValue(UncheckedImageSourceProperty); }
            set { SetValue(UncheckedImageSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for UncheckedImageSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UncheckedImageSourceProperty =
            DependencyProperty.Register("UncheckedImageSource", typeof(ImageSource), typeof(VSCodeItems), new PropertyMetadata(new BitmapImage(new Uri("pack://application:,,,/CustomTreeViewItem;Component/Images/ArrowRight.png"))));



        public bool ItemSelected
        {
            get { return (bool)GetValue(ItemSelectedProperty); }
            set { SetValue(ItemSelectedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ItemSelected.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemSelectedProperty =
            DependencyProperty.Register("ItemSelected", typeof(bool), typeof(VSCodeItems), new PropertyMetadata(false));


    }
}
