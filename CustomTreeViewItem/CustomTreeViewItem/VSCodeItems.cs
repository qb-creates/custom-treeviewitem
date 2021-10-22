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
{    public partial class VSCodeItems : TreeViewItem
    {
        private Border fullBorder;
        private Border presenterBorder;
        private Image expander;
        private bool isChecked = false;

        static VSCodeItems()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(VSCodeItems), new FrameworkPropertyMetadata(typeof(VSCodeItems)));
        }

      

        public void AddItem(VSCodeItems newItem)
        {
            newItem.MarginThickness  = new Thickness(9990, 0, 5, 0);
            Items.Add(newItem); 
        }
        public override void OnApplyTemplate()
        {
            fullBorder = (Border)GetTemplateChild("PART_FullBorder");
            expander = (Image)GetTemplateChild("PART_Expander");
            presenterBorder = (Border)GetTemplateChild("PART_PresenterBorder");

            this.MouseDoubleClick += VSCodeItems_MouseDoubleClick;
            fullBorder.MouseLeftButtonUp += Border_MouseLeftButtonUp;
            expander.MouseLeftButtonUp += Expander_MouseLeftButtonUp;
            presenterBorder.MouseLeftButtonUp += PresenterBorder_MouseLeftButtonUp;

            expander.Source = UncheckedImageSource;
        }


        private void VSCodeItems_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;
        }

        private void Border_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ToggleExpansion();
        }
        private void Expander_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ToggleExpansion();
        }
        private void PresenterBorder_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ToggleExpansion();
        }
        public void UnSubscribeEvents()
        {
            this.PreviewMouseLeftButtonUp += VSCodeItems_PreviewMouseLeftButtonUp;
            this.MouseDoubleClick -= VSCodeItems_MouseDoubleClick;
            fullBorder.MouseLeftButtonDown -= Border_MouseLeftButtonUp;
            expander.MouseLeftButtonUp -= Expander_MouseLeftButtonUp;
            presenterBorder.MouseLeftButtonUp -= PresenterBorder_MouseLeftButtonUp;
        }

        private void VSCodeItems_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ItemSelected = !ItemSelected;
        }

        private void ToggleExpansion()
        {
            isChecked = !isChecked;
            ItemSelected = !ItemSelected;
            if (isChecked && this.HasItems)
            {
                this.IsExpanded = true;
                expander.Source = CheckedImageSource;
            }
            else if (!isChecked && this.HasItems)
            {
                this.IsExpanded = false;
                expander.Source = UncheckedImageSource;
            }
        }

    }
}
