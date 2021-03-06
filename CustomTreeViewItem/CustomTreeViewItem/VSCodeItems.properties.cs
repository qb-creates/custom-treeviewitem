using System;
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
            DependencyProperty.Register("MarginThickness", typeof(Thickness), typeof(VSCodeItems), new PropertyMetadata(new Thickness(10025, 0, 5, 0)));

        public Brush HighlightedColor
        {
            get { return (Brush)GetValue(HighlightedColorProperty); }
            set { SetValue(HighlightedColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HighlightedColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HighlightedColorProperty =
            DependencyProperty.Register("HighlightedColor", typeof(Brush), typeof(VSCodeItems), new PropertyMetadata(new SolidColorBrush(Color.FromArgb(0x11, 0xFF, 0xFF, 0xFF))));


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


        internal bool ItemSelected
        {
            get { return (bool)GetValue(ItemSelectedProperty); }
            set { SetValue(ItemSelectedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Focused.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemSelectedProperty =
            DependencyProperty.Register("ItemSelected", typeof(bool), typeof(VSCodeItems), new PropertyMetadata(false));



        internal bool ItemFocused
        {
            get { return (bool)GetValue(ItemFocusedProperty); }
            set { SetValue(ItemFocusedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ItemFocused.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemFocusedProperty =
            DependencyProperty.Register("ItemFocused", typeof(bool), typeof(VSCodeItems), new PropertyMetadata(false));



        public SolidColorBrush TextColor
        {
            get { return (SolidColorBrush)GetValue(TextColorProperty); }
            set { SetValue(TextColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextColorProperty =
            DependencyProperty.Register("TextColor", typeof(SolidColorBrush), typeof(VSCodeItems), new PropertyMetadata(new SolidColorBrush(Color.FromArgb(0xFF, 0xDC, 0xDC, 0xDC))));

    }
}
