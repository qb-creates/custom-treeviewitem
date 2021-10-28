using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace CustomTreeViewItem
{
    public partial class VSCodeTreeView : Control
    {
        public delegate void ExpandedEventHandler(object sender, EventArgs args);
        public event ExpandedEventHandler OnTreeViewExpanded; 
        private Border treeViewContainer;
        private TreeView treeView;
        private Button buttonContainer;
        private StackPanel utilityButtonContainer;
        private Button utilityButtonOne;
        private Button utilityButtonTwo;
        private Button utilityButtonThree;
        private Image expanderImage;
        private bool isChecked = false;
        private bool isMouseOverUtility = false;

        public override void OnApplyTemplate()
        {
            buttonContainer = (Button)GetTemplateChild("PART_ButtonContainer");
            treeViewContainer = (Border)GetTemplateChild("PART_TreeViewContainer");
            treeView = (TreeView)GetTemplateChild("PART_TreeView");
            expanderImage = (Image)GetTemplateChild("PART_Expander");
            utilityButtonContainer = (StackPanel)GetTemplateChild("PART_UtilityButtonContainer");
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
            buttonContainer.PreviewMouseLeftButtonUp += Border_PreviewMouseLeftButtonUp;
            utilityButtonOne.Click += UtilityButtonOne_Click;

            expanderImage.Source = UncheckedImageSource;
        }

        private void VSCodeTreeView_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (OldItem != null)
                OldItem.ItemSelected = false;
            if(CurrentItem != null)
                CurrentItem.ItemSelected = true;
        }

        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            OldItem = (e.OldValue as VSCodeItems);
            CurrentItem = (e.NewValue as VSCodeItems);
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
                    expanderImage.Source = CheckedImageSource;
                    DoubleAnimation treeViewAnimation = new DoubleAnimation(0, treeView.ActualHeight, TimeSpan.FromMilliseconds(200));
                    treeViewContainer.BeginAnimation(Border.HeightProperty, treeViewAnimation);
                    treeViewContainer.Height = Double.NaN;
                    utilityButtonContainer.Visibility = Visibility.Visible;
                    OnTreeViewExpanded?.Invoke(this, new EventArgs());
                }
                else
                {
                    expanderImage.Source = UncheckedImageSource;
                    DoubleAnimation treeViewAnimation = new DoubleAnimation(treeView.ActualHeight, 0, TimeSpan.FromMilliseconds(200));
                    treeViewContainer.BeginAnimation(Border.HeightProperty, treeViewAnimation);
                    utilityButtonContainer.Visibility = Visibility.Hidden;
                }
            }
        }
        public void CollaspeTreeView()
        {
            if (isChecked)
            {
                isChecked = false;
                expanderImage.Source = UncheckedImageSource;
                DoubleAnimation treeViewAnimation = new DoubleAnimation(treeView.ActualHeight, 0, TimeSpan.FromMilliseconds(200));
                treeViewContainer.BeginAnimation(Border.HeightProperty, treeViewAnimation);
                utilityButtonContainer.Visibility = Visibility.Hidden;
            }
        }
        public void AddItem(TreeViewItem item)
        {
            treeView.Items.Add(item);
        }
    }
}

