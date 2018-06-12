using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CommunicationWithArduino
{
    class SerialPortCommunication
    {
        bool connected;
        SerialPort port1;
        String[] ports;

        public bool Connected { get { return connected; } }

        public void GetAvaiableComPorts (ComboBox comboBox)
        {
            ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBox.Items.Add(port);
                Console.WriteLine(port);
                if (ports[0] != null)
                    comboBox.SelectedItem = ports[0];
            }
        }

        public void ConnectToArduino (string portName)
        {
            connected = true;
            port1 = new SerialPort(portName, 9600, Parity.None, 8, StopBits.One);
            startCommunication();
        }

        private void startCommunication()
        {
            port1.Open();
            port1.Write(sendCommand("STAR"));
            Console.WriteLine("Connected");
        }

        public void readCommand()
        {
            if (port1.BytesToRead>=10)
            {
                string something = port1.ReadLine();
                Console.WriteLine(something);
                
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="adress"> 0-9 number of device</param>
        /// <param name="code"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        private string sendCommand(byte adress, string code, string data)
        {
            //adress is 0-9 number
            string command = adress.ToString() + code + data + "\n";
            return command;
        }
        /// <summary>
        /// This function send code with additional data and default device adress equal 1
        /// </summary>
        /// <param name="code"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        private string sendCommand(string code, string data)
        {
            string command = 1.ToString() + code + data + "\n";
            return command;
        }
        /// <summary>
        /// This functrion sends only code with default value of adress equal 1 and no additional data.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        private string sendCommand(string code)
        {
            string command = 1.ToString() + code + "\n";
            return command;
        }
        /// <summary>
        /// This function sends code with adress of device without additional data
        /// </summary>
        /// <param name="adress">Adress is 0-9 number of device.</param>
        /// <param name="code"></param>
        /// <returns></returns>
        private string sendCommand(byte adress, string code)
        {
            string command = adress.ToString() + code + "\n";
            return command;
        }

        public void DisconnectFromArduino()
        {
            connected = false;
            stopCommunication();
        }

        private void stopCommunication()
        {
            port1.Write(sendCommand("STOP"));
            port1.Close();
            Console.WriteLine("Disconnected");
        }

        /// <summary>
        /// This function sends code with additional data and default adress of device equal 1.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="data"></param>
        public void SendCommand (string code, string data)
        {
            port1.Write(sendCommand(code, data));
            Console.WriteLine("Kod: " + code + " Dane: " + data);
        }

        /// <summary>
        /// This function sends code without additional data and default adress of device equal 1.
        /// </summary>
        /// <param name="code"></param>
        public void SendCommand(string code)
        {
            port1.Write(sendCommand(code));
            Console.WriteLine("Kod: " + code + " Dane: brak");
        }
    }
}
