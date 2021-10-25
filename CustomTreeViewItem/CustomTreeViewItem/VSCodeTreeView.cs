﻿using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CustomTreeViewItem
{
    public partial class VSCodeTreeView : Control
    {
        private Grid treeViewGrid;
        private TreeView treeView;
        private Border border;
        private Button utilityButtonOne;
        private Button utilityButtonTwo;
        private Button utilityButtonThree;
        private Image expander;
        private VSCodeItems newFocusedItem;
        private VSCodeItems oldFocusedItem;
        private bool isChecked = false;
        private bool isMouseOverUtility = false;
        

        public override void OnApplyTemplate()
        {
            treeViewGrid = (Grid)GetTemplateChild("PART_TreeViewGrid");
            treeView = (TreeView)GetTemplateChild("PART_TreeView");
            border = (Border)GetTemplateChild("PART_Border");
            expander = (Image)GetTemplateChild("PART_Expander");
            utilityButtonOne = (Button)GetTemplateChild("PART_UtilityButtonOne");
            utilityButtonTwo = (Button)GetTemplateChild("PART_UtilityButtonTwo");
            utilityButtonThree = (Button)GetTemplateChild("PART_UtilityButtonThree");

            treeView.MouseLeftButtonUp += VSCodeTreeView_MouseLeftButtonUp;
            treeView.SelectedItemChanged += TreeView_SelectedItemChanged;
            utilityButtonOne.MouseEnter += UtilityButton_MouseEnter;
            utilityButtonOne.MouseLeave += UtilityButton_MouseLeave;
            utilityButtonTwo.MouseEnter += UtilityButton_MouseEnter;
            utilityButtonTwo.MouseLeave += UtilityButton_MouseLeave;
            utilityButtonThree.MouseEnter += UtilityButton_MouseEnter;
            utilityButtonThree.MouseLeave += UtilityButton_MouseLeave;
            border.PreviewMouseLeftButtonUp += Border_PreviewMouseLeftButtonUp;
            utilityButtonOne.Click += UtilityButtonOne_Click;

            expander.Source = UncheckedImageSource;
        }

        private void VSCodeTreeView_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (oldFocusedItem != null)
                oldFocusedItem.ItemSelected = false;
            if(newFocusedItem != null)
                newFocusedItem.ItemSelected = true;
        }

        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            oldFocusedItem = (e.OldValue as VSCodeItems);
            newFocusedItem = (e.NewValue as VSCodeItems);
        }

        private void UtilityButtonOne_Click(object sender, RoutedEventArgs e)
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

        private void Border_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (!isMouseOverUtility)
            {
                isChecked = !isChecked;

                if (isChecked)
                {
                    treeViewGrid.Visibility = Visibility.Visible;
                    expander.Source = CheckedImageSource;
                    
                }
                else
                {
                    treeViewGrid.Visibility = Visibility.Collapsed;
                    expander.Source = UncheckedImageSource;
                }
            }
        }
        public void AddItem(TreeViewItem item)
        {
            treeView.Items.Add(item);
        }
    }
}

