using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomTreeViewItem
{
    public class VSCodeTreeView : Control
    {

        private TreeView treeView;
        private Border border;
        private Button utilityButtonOne;
        private Button utilityButtonTwo;
        private Button utilityButtonThree;
        private Image expander;
        private bool isChecked = false;
        private bool isMouseOverUtility = false;
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
            DependencyProperty.Register("ButtonOneImageSource", typeof(ImageSource), typeof(VSCodeTreeView));

        public ImageSource UtilityButtonTwoImageSource
        {
            get { return (ImageSource)GetValue(ButtonTwoImageSourceProperty); }
            set { SetValue(ButtonTwoImageSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ButtonTwoImageSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonTwoImageSourceProperty =
            DependencyProperty.Register("ButtonTwoImageSource", typeof(ImageSource), typeof(VSCodeTreeView));

        public ImageSource UtilityButtonThreeImageSource
        {
            get { return (ImageSource)GetValue(ButtonThreeImageSourceProperty); }
            set { SetValue(ButtonThreeImageSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ButtonThreeImageSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonThreeImageSourceProperty =
            DependencyProperty.Register("ButtonThreeImageSource", typeof(ImageSource), typeof(VSCodeTreeView));
        public double UtilityButtonSize
        {
            get { return (double)GetValue(UtilityButtonSizeProperty); }
            set { SetValue(UtilityButtonSizeProperty, value); }
        }

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

        public override void OnApplyTemplate()
        {
            treeView = (TreeView)GetTemplateChild("PART_TreeView");
            border = (Border)GetTemplateChild("PART_Border");
            expander = (Image)GetTemplateChild("PART_Expander");
            utilityButtonOne = (Button)GetTemplateChild("PART_UtilityButtonOne");
            utilityButtonTwo = (Button)GetTemplateChild("PART_UtilityButtonTwo");
            utilityButtonThree = (Button)GetTemplateChild("PART_UtilityButtonThree");

            if (UtilityButtonOneImageSource == null)
                utilityButtonOne.Visibility = Visibility.Collapsed;
            else
                utilityButtonOne.Visibility = Visibility.Visible;
            if (UtilityButtonTwoImageSource == null)
                utilityButtonTwo.Visibility = Visibility.Collapsed;
            else
                utilityButtonTwo.Visibility = Visibility.Visible;
            if (UtilityButtonThreeImageSource == null)
                utilityButtonThree.Visibility = Visibility.Collapsed;
            else
                utilityButtonThree.Visibility = Visibility.Visible;

            treeView.Visibility = Visibility.Collapsed;

            utilityButtonOne.MouseEnter += UtilityButton_MouseEnter;
            utilityButtonOne.MouseLeave += UtilityButton_MouseLeave;
            utilityButtonTwo.MouseEnter += UtilityButton_MouseEnter;
            utilityButtonTwo.MouseLeave += UtilityButton_MouseLeave;
            utilityButtonThree.MouseEnter += UtilityButton_MouseEnter;
            utilityButtonThree.MouseLeave += UtilityButton_MouseLeave;
            border.PreviewMouseLeftButtonDown += Border_PreviewMouseLeftButtonDown;
            utilityButtonOne.Click += UtilityButtonOne_Click;

            expander.Source = UncheckedImageSource;
        }

        private void UtilityButtonOne_Click(object sender, RoutedEventArgs e)
        {
        }

        private void UtilityButtonOne_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void UtilityButton_MouseLeave(object sender, MouseEventArgs e)
        {
            isMouseOverUtility = false;
        }

        private void UtilityButton_MouseEnter(object sender, MouseEventArgs e)
        {
            isMouseOverUtility = true;
        }

        private void Border_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (!isMouseOverUtility)
            {
                isChecked = !isChecked;

                if (isChecked)
                {
                    treeView.Visibility = Visibility.Visible;
                    expander.Source = CheckedImageSource;
                    this.BorderThickness = new Thickness(0, 0, 0, 0);
                }
                else
                {
                    treeView.Visibility = Visibility.Collapsed;
                    expander.Source = UncheckedImageSource;
                    this.BorderThickness = new Thickness(0, 0, 0, 0.5);
                }
            }
        }
        public void AddItem(TreeViewItem item)
        {
            treeView.Items.Add(item);
        }
    }
}

