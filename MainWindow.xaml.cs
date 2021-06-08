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
using System.Text.RegularExpressions;

namespace gosuslugi
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int b = 0;
        public List<string> name = new List<string>();
        public List<string> familia = new List<string>();
        public List<string> ochestvo = new List<string>();
        public List<string> email = new List<string>();
        public List<string> tel = new List<string>();
        public List<string> cnils = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zAZ0-9}[\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (emailText.Text.Length > 0)
            {
                if (!rEMail.IsMatch(emailText.Text))
                {
                    MessageBox.Show("не верно введен email", "Error");
                    emailText.SelectAll();
                }
            }
            if (snilsbox.Text.Length == 14)
            {

            }
            else
            {
                MessageBox.Show("снилс введен не верно");
            }
            int countc = 0;
            for (int i = 0; i < telbox.Text.Length; i++)
            {
                if (char.IsDigit(telbox.Text[i]))
                {
                    countc++;
                }
            }
            try
            {
                if (telbox.Text[0] == '8' && countc == 11)
                {

                }
                else
                {
                    MessageBox.Show("Номер введен не верно");
                }
            }
            catch
            {

            }
        }

        
        private void snilsbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (snilsbox.Text.Length == 3)
            {
                snilsbox.Text += '-';
                snilsbox.CaretIndex = 4;
            }
            else if (snilsbox.Text.Length == 7)
            {
                snilsbox.Text += '-';
                snilsbox.CaretIndex = 8;
            }
            else if (snilsbox.Text.Length == 11)
            {
                snilsbox.Text += '-';
                snilsbox.CaretIndex = 12;
            }
        }

        private void telbox_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }
    }
}

               

        

       
        

        
    

   

