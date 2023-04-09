using ConsoleAppOOPClasses;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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

namespace WpfAppClassFirst
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClassTrain train = new ClassTrain();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSavestudent_Click(object sender, RoutedEventArgs e)
        {
            train.ntrain = TxtN.Text;
            train.DStart = (DateTime)DtDstart.SelectedDate;
            train.PunktNasnachenia = TxtX.Text; ;

            LstTrain.Items.Clear();
            LstTrain.Items.Add(train.PrintToScreen());
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == false)
                return;
            train.SaveToFile(saveFileDialog.FileName);
        }
    }
}
