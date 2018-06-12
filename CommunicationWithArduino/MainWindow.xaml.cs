using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace CommunicationWithArduino
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SerialPortCommunication com1 = new SerialPortCommunication();
        DispatcherTimer t = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            
            com1.GetAvaiableComPorts(CBComPorts);
            
            t.Interval = TimeSpan.FromMilliseconds(1);
            t.Start();
            t.Tick += T_Tick;
        }

        private void T_Tick(object sender, EventArgs e)
        {
            if (com1.Connected)
            {
                com1.readCommand();
            }
        }
       



        private void BTconnect_Click(object sender, RoutedEventArgs e)
        {
            if (!com1.Connected)
            {
                com1.ConnectToArduino(CBComPorts.SelectedItem.ToString());
                BTconnect.Content = "Disconect";
                image2.Visibility = Visibility.Visible;
                image1.Visibility = Visibility.Hidden;
                StackPanelControl.IsEnabled = true;
            }
            else
            {
                com1.DisconnectFromArduino();
                BTconnect.Content = "Connect";
                image1.Visibility = Visibility.Visible;
                image2.Visibility = Visibility.Hidden;
                StackPanelControl.IsEnabled = false;
            }
        }


        private void CheckBoxDiode_Click(object sender, RoutedEventArgs e)
        {
           if (com1.Connected)
            {
                if (CheckBoxDiode.IsChecked == true)
                {
                    CheckBoxDiode.Content = "POWER ON";
                    if (CheckBoxPWM.IsChecked == true)
                    {
                        com1.SendCommand("PWM1", Slider1.Value.ToString());
                    }
                    else
                    {
                        com1.SendCommand("LED1", "ON");
                    }
                }
                else
                {
                    com1.SendCommand("LED1", "OFF");
                    CheckBoxDiode.Content = "POWER OFF";
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            button2.Visibility = Visibility.Hidden;
            CheckBoxMainLight.Visibility = Visibility.Visible;
        }

        private void CheckBoxMainLight_Click(object sender, RoutedEventArgs e)
        {
            if (com1.Connected)
            {
                if (CheckBoxMainLight.IsChecked == true)
                {
                    com1.SendCommand("ML01", "ON");
                }
                else
                {
                    com1.SendCommand("ML01", "OFF");
                }
            }
        }

        private void CheckBoxPWM_Click(object sender, RoutedEventArgs e)
        {
            if (CheckBoxPWM.IsChecked == true)
            {
                com1.SendCommand("PWM1", Slider1.Value.ToString());
                Slider1.IsEnabled = true;
            }
            else
            {
                Slider1.IsEnabled = false;
                if(CheckBoxDiode.IsChecked==true)
                    com1.SendCommand("LED1", "ON");
                else
                    com1.SendCommand("LED1", "OFF");
            }
        }

        private void Slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if(CheckBoxDiode.IsChecked == true)
            {
                    if (CheckBoxPWM.IsChecked == true)
                    {
                    com1.SendCommand("PWM1", Slider1.Value.ToString());
                    Text1.Text = Slider1.Value.ToString();
                }
            }
        }
    }
}
