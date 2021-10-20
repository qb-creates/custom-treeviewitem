using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
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

        public ItemCollection MyItems
        {
            get
            {
                return Items;
            }
        }
    
        static VSCodeItems()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(VSCodeItems), new FrameworkPropertyMetadata(typeof(VSCodeItems)));
        }
        protected override void AddChild(object value)
        {

        }
 
        public override void OnApplyTemplate()
        { 
            border = (Border)GetTemplateChild("FullBorder");
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
