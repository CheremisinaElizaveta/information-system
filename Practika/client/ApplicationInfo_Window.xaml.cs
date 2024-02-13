using Newtonsoft.Json;

using Practika.TehSupportDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;


namespace Practika
{

    public partial class ApplicationInfo_Window : Window
    {

        application_TableAdapter application_TableAdapter = new application_TableAdapter();
        public ApplicationInfo_Window()
        {
            InitializeComponent();
            ApplicationInfo_W.ItemsSource = application_TableAdapter.GetData();
            
        }
    }
}
