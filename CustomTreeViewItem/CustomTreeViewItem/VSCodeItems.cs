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
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:CustomTreeViewItem"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:CustomTreeViewItem;assembly=CustomTreeViewItem"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:VSCodeItems/>
    ///
    /// </summary>
    public class VSCodeItems : TreeViewItem
    {
        private Border border;
        private ToggleButton expander;

        static VSCodeItems()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(VSCodeItems), new FrameworkPropertyMetadata(typeof(VSCodeItems)));
        }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public new double Width
        {
            get;
            internal set;
        }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public new double MaxWidth
        {
            get;
            internal set;
        }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public new double Height
        {
            get;
            internal set;
        }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public new double MaxHeight
        {
            get;
            internal set;
        }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public new Thickness Margin
        {
            get;
            internal set;
        }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public new Thickness Padding
        {
            get;
            internal set;
        }

        internal Thickness MarginThickness
        {
            get { return (Thickness)GetValue(MarginThicknessProperty); }
            set { SetValue(MarginThicknessProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MarginThickness.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MarginThicknessProperty =
            DependencyProperty.Register("MarginThickness", typeof(Thickness), typeof(VSCodeItems), new PropertyMetadata(new Thickness(10030, 0, 5, 0)));



        public Brush HighlightedColor
        {
            get { return (Brush)GetValue(HighlightedColorProperty); }
            set { SetValue(HighlightedColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HighlightedColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HighlightedColorProperty =
            DependencyProperty.Register("HighlightedColor", typeof(Brush), typeof(VSCodeItems), new PropertyMetadata(new SolidColorBrush(Color.FromArgb(0xAA, 0x31, 0x31, 0x31))));


        public void AddItem(VSCodeItems newItem)
        {
            newItem.MarginThickness  = new Thickness(10010, 0, 5, 0);
            Items.Add(newItem); 
        }
        public override void OnApplyTemplate()
        {
            border = (Border)GetTemplateChild("FullBorder");
            expander = (ToggleButton)GetTemplateChild("Expander");
            
            border.MouseEnter += Border_MouseEnter;
            border.MouseLeave += Border_MouseLeave;
        }


        private void Border_MouseLeave(object sender, MouseEventArgs e)
        {
   
        }

        private void Border_MouseEnter(object sender, MouseEventArgs e)
        {
     
        }

    }
}
