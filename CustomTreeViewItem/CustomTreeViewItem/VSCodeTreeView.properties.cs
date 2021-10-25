using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace CustomTreeViewItem
{
    public partial class VSCodeTreeView
    {
        public List<TreeViewItem> MyItemSource
        {
            get { return (List<TreeViewItem>)GetValue(MyItemSourceProperty); }
            set { SetValue(MyItemSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyItemSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyItemSourceProperty =
            DependencyProperty.Register("MyItemSource", typeof(List<TreeViewItem>), typeof(VSCodeTreeView), new PropertyMetadata(null));

        public ImageSource CheckedImageSource
        {
            get { return (ImageSource)GetValue(CheckedImageSourceProperty); }
            set { SetValue(CheckedImageSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CheckedImageSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CheckedImageSourceProperty =
            DependencyProperty.Register("CheckedImageSource", typeof(ImageSource), typeof(VSCodeTreeView), new PropertyMetadata(new BitmapImage(new Uri("pack://application:,,,/CustomTreeViewItem;Component/Images/ArrowDown.png"))));

        public ImageSource UncheckedImageSource
        {
            get { return (ImageSource)GetValue(UncheckedImageSourceProperty); }
            set { SetValue(UncheckedImageSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for UncheckedImageSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UncheckedImageSourceProperty =
            DependencyProperty.Register("UncheckedImageSource", typeof(ImageSource), typeof(VSCodeTreeView), new PropertyMetadata(new BitmapImage(new Uri("pack://application:,,,/CustomTreeViewItem;Component/Images/ArrowRight.png"))));

        public ImageSource UtilityButtonOneImageSource
        {
            get { return (ImageSource)GetValue(ButtonOneImageSourceProperty); }
            set { SetValue(ButtonOneImageSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ButtonOneImageSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonOneImageSourceProperty =
            DependencyProperty.Register("ButtonOneImageSource", typeof(ImageSource), typeof(VSCodeTreeView), new PropertyMetadata(new BitmapImage(new Uri("pack://application:,,,/CustomTreeViewItem;Component/Images/PlaceholderIcon.png"))));

        public ImageSource UtilityButtonTwoImageSource
        {
            get { return (ImageSource)GetValue(ButtonTwoImageSourceProperty); }
            set { SetValue(ButtonTwoImageSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ButtonTwoImageSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonTwoImageSourceProperty =
            DependencyProperty.Register("ButtonTwoImageSource", typeof(ImageSource), typeof(VSCodeTreeView), new PropertyMetadata(new BitmapImage(new Uri("pack://application:,,,/CustomTreeViewItem;Component/Images/PlaceholderIcon.png"))));

        public ImageSource UtilityButtonThreeImageSource
        {
            get { return (ImageSource)GetValue(ButtonThreeImageSourceProperty); }
            set { SetValue(ButtonThreeImageSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ButtonThreeImageSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonThreeImageSourceProperty =
            DependencyProperty.Register("ButtonThreeImageSource", typeof(ImageSource), typeof(VSCodeTreeView), new PropertyMetadata(new BitmapImage(new Uri("pack://application:,,,/CustomTreeViewItem;Component/Images/PlaceholderIcon.png"))));
        public double UtilityButtonSize
        {
            get { return (double)GetValue(UtilityButtonSizeProperty); }
            set { SetValue(UtilityButtonSizeProperty, value); }
        }


        public Visibility UtilityButtonOneVisibility
        {
            get { return (Visibility)GetValue(UtilityButtonOneVisibilityProperty); }
            set { SetValue(UtilityButtonOneVisibilityProperty, value); }
        }

        // Using a DependencyProperty as the backing store for UtilityButtonOneVisibility.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UtilityButtonOneVisibilityProperty =
            DependencyProperty.Register("UtilityButtonOneVisibility", typeof(Visibility), typeof(VSCodeTreeView), new PropertyMetadata(Visibility.Collapsed));



        public Visibility UtilityButtonTwoVisibility
        {
            get { return (Visibility)GetValue(UtilityButtonTwoVisibilityProperty); }
            set { SetValue(UtilityButtonTwoVisibilityProperty, value); }
        }

        // Using a DependencyProperty as the backing store for UtilityButtonTwoVisibility.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UtilityButtonTwoVisibilityProperty =
            DependencyProperty.Register("UtilityButtonTwoVisibility", typeof(Visibility), typeof(VSCodeTreeView), new PropertyMetadata(Visibility.Collapsed));

        public Visibility UtilityButtonThreeVisibility
        {
            get { return (Visibility)GetValue(UtilityButtonThreeVisibilityProperty); }
            set { SetValue(UtilityButtonThreeVisibilityProperty, value); }
        }

        // Using a DependencyProperty as the backing store for UtilityButtonThreeVisibility.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UtilityButtonThreeVisibilityProperty =
            DependencyProperty.Register("UtilityButtonThreeVisibility", typeof(Visibility), typeof(VSCodeTreeView), new PropertyMetadata(Visibility.Collapsed));

        // Using a DependencyProperty as the backing store for UtilityButtonSize.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UtilityButtonSizeProperty =
            DependencyProperty.Register("UtilityButtonSize", typeof(double), typeof(VSCodeTreeView), new PropertyMetadata(15.0));

        public string Header
        {
            get { return (string)GetValue(HeaderProperty); }
            set { SetValue(HeaderProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Header.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HeaderProperty =
            DependencyProperty.Register("Header", typeof(string), typeof(VSCodeTreeView), new PropertyMetadata("No Header set"));

        static VSCodeTreeView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(VSCodeTreeView), new FrameworkPropertyMetadata(typeof(VSCodeTreeView)));
        }
    }
}
