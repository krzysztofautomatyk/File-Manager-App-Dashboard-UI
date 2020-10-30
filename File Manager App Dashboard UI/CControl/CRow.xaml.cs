using System;
using System.Collections.Generic;
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

namespace File_Manager_App_Dashboard_UI.CControl
{
    /// <summary>
    /// Interaction logic for CRow.xaml
    /// </summary>
    public partial class CRow : UserControl
    {
        public CRow()
        {
            InitializeComponent();
        }


        public Uri ImageSource1
        {
            get { return (Uri)GetValue(ImageSource1Property); }
            set { SetValue(ImageSource1Property, value); }
        }

        // Using a DependencyProperty as the backing store for ImageSource. This enables animation, stylin, binding, etc...
        public static readonly DependencyProperty ImageSource1Property =
            DependencyProperty.Register("ImageSource1", typeof(Uri), typeof(CRow));

        public Uri ImageSource2
        {
            get { return (Uri)GetValue(ImageSource2Property); }
            set { SetValue(ImageSource2Property, value); }
        }

        // Using a DependencyProperty as the backing store for ImageSource. This enables animation, stylin, binding, etc...
        public static readonly DependencyProperty ImageSource2Property =
            DependencyProperty.Register("ImageSource2", typeof(Uri), typeof(CRow));

        public Uri ImageSource3
        {
            get { return (Uri)GetValue(ImageSource3Property); }
            set { SetValue(ImageSource3Property, value); }
        }

        // Using a DependencyProperty as the backing store for ImageSource. This enables animation, stylin, binding, etc...
        public static readonly DependencyProperty ImageSource3Property =
            DependencyProperty.Register("ImageSource3", typeof(Uri), typeof(CRow));



        public PathGeometry Icon
        {
            get { return (PathGeometry)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImageSource. This enables animation, stylin, binding, etc...
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(PathGeometry), typeof(CRow));



        public string DocName
        {
            get { return (string)GetValue(DocNameProperty); }
            set { SetValue(DocNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DriveName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DocNameProperty =
            DependencyProperty.Register("DocName", typeof(string), typeof(CRow));



        public string FileSize
        {
            get { return (string)GetValue(FileSizeProperty); }
            set { SetValue(FileSizeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsChecked.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FileSizeProperty =
            DependencyProperty.Register("FileSize", typeof(string), typeof(CRow));



        public string LastEdit
        {
            get { return (string)GetValue(LastEditProperty); }
            set { SetValue(LastEditProperty, value); }
        }

        // Using a DependencyProperty as the backing store for lastChange.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LastEditProperty =
            DependencyProperty.Register("LastEdit", typeof(string), typeof(CRow));

        public bool IsChecked
        {
            get { return (bool)GetValue(IsCheckedProperty); }
            set { SetValue(IsCheckedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for lastChange.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsCheckedProperty =
            DependencyProperty.Register("IsChecked", typeof(bool), typeof(CRow));


    }
}
