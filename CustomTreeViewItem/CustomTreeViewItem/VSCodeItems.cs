﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CustomTreeViewItem
{
    public partial class VSCodeItems : TreeViewItem
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
            newItem.MarginThickness  = new Thickness(10000, 0, 5, 0);
            Items.Add(newItem); 
        }
        public override void OnApplyTemplate()
        {
            fullBorder = (Border)GetTemplateChild("PART_FullBorder");
            expander = (Image)GetTemplateChild("PART_Expander");
            presenterBorder = (Border)GetTemplateChild("PART_PresenterBorder");
            
            this.MouseDoubleClick += VSCodeItems_MouseDoubleClick;
            fullBorder.MouseLeftButtonUp += TreeViewItem_MouseLeftButtonUp;
            expander.MouseLeftButtonUp += TreeViewItem_MouseLeftButtonUp;
            presenterBorder.MouseLeftButtonUp += TreeViewItem_MouseLeftButtonUp;
    
            expander.Source = UncheckedImageSource;
        }

        private void VSCodeItems_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;
        }
        private void TreeViewItem_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            isChecked = !isChecked;

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
      


        public void UnSubscribeEvents()
        {
            this.MouseDoubleClick -= VSCodeItems_MouseDoubleClick;
            fullBorder.MouseLeftButtonUp -= TreeViewItem_MouseLeftButtonUp;
            expander.MouseLeftButtonUp -= TreeViewItem_MouseLeftButtonUp;
            presenterBorder.MouseLeftButtonUp -= TreeViewItem_MouseLeftButtonUp;
        }
    }
}
