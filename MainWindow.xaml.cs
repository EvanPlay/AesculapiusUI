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

namespace AesculapiusUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void btEnterCommand_Click(object sender, RoutedEventArgs e)
        {
            CommandString();
        }

        public void CommandString()
        {
            if(tbCommandEnter.Text.Length > 0)
            {
                CloseAppCommand();
                tblCommand.Text = $"Комманды \"{tbCommandEnter.Text/*.ToLower()*/}\" не сущесвтует.";
                tbCommandEnter.Text = "";
            }
            else
            {
                tblCommand.Text = "Введите команду.";
                tbCommandEnter.Text = "";
            }
        }

        private void CloseAppCommand()
        {
            string commandSet = tbCommandEnter.Text.ToLower();
            string commandGet = "exit";

            if(commandSet.IndexOf(commandGet) >= 0)
            {
                this.Close();
            }
        }
    }
}
