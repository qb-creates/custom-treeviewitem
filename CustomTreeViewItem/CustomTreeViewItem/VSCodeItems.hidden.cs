using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace CustomTreeViewItem
{
    public partial class VSCodeItems
    {
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
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public new Brush Background
        {
            get;
            internal set;
        }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public new Brush BorderBrush
        {
            get;
            internal set;
        }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public new Thickness BorderThickness
        {
            get;
            internal set;
        }
    }
}
