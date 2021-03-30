using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace RCArduinoT
{
    public partial class Form1 : Form
    {
        bool isConnected = false;

        int timeLeft = 10;
        bool repeatTimer = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnComPort_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            string[] portnames = SerialPort.GetPortNames();
            if(portnames.Length == 0)
            {
                MessageBox.Show("COM порт не найден!");
            }
            foreach(string portName in portnames)
            {
                comboBox1.Items.Add(portName);
                Console.WriteLine(portName.Length);
                if(portnames[0] != null)
                {
                    comboBox1.SelectedItem = portnames[0];
                }
            }

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(!isConnected)
            {
                ConnectToArduino();
            }
            else
            {
                DisconnectFromArduino();
            }
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            if(isConnected)
            {
                serialPort1.Write("1");
                txtLogOutput.AppendText(DateTime.Now + " " + "1Сигнал кнопки 1 отправлен" + Environment.NewLine);
            }
            
            
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            if(isConnected)
            {
                serialPort1.Write("0");
                txtLogOutput.AppendText(DateTime.Now + " " + "Сигнал кнопки 2 отправлен" + Environment.NewLine);
            }
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Close();
                
            }
        }

        private void ConnectToArduino()
        {
            isConnected = true;
            string selectedPort = comboBox1.GetItemText(comboBox1.SelectedItem);
            serialPort1.PortName = selectedPort;
            serialPort1.Open();
            btnConnect.Text = "Отключить";
            txtLogOutput.AppendText(DateTime.Now + " " + "Arduino подключен" + Environment.NewLine);
        }

        private void DisconnectFromArduino()
        {
            isConnected = false;
            serialPort1.Close();
            btnConnect.Text = "Подключить";
            txtLogOutput.AppendText(DateTime.Now + " " + "Arduino отключен" + Environment.NewLine);
        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timeLeft > 0)
            {
                timeLeft -= 1;
                label1.Text = "или " + timeLeft + " секунд";
                //label2.Text = "Осталось " + (timeLeft / 60) + " минут" + " и " + (timeLeft % 60) + " секунд";
                label2.Text = "Осталось " + (timeLeft / 3600) + " часов, " + ((timeLeft % 3600)/60) + " минут" + " и " + ((timeLeft % 3600)%60) + " секунд";
            }
            else
            {
                timer1.Stop();
                label1.Text = "Таймер завершен";
                label2.Text = "";
                txtLogOutput.AppendText(DateTime.Now + " " + "Таймер завершен" + Environment.NewLine);
                if (isConnected)
                {
                    //serialPort1.Write("9");
                    serialPort1.Write("1");
                    System.Threading.Thread.Sleep(2000);
                    serialPort1.Write("0");
                    txtLogOutput.AppendText(DateTime.Now + " " + "Команды отправлены" + Environment.NewLine);
                }
                if(repeatTimer)
                {
                    StartTimer();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartTimer();
        }

        private void chkTimerRepeat_CheckedChanged(object sender, EventArgs e)
        {
            if(chkTimerRepeat.Checked == true)
            {
                repeatTimer = true;
            }
            else
            {
                repeatTimer = false;
            }
        }

        private void StartTimer()
        {

            int hours;
            int minutes;
            int seconds;

            if(int.TryParse(timerHours.Text, out hours))
            {
                //
            }
            else
            {
                hours = 0;
            }

            if(int.TryParse(timerMinutes.Text, out minutes))
            {
                //
            }
            else
            {
                minutes = 0;
            }

            if(int.TryParse(timerSeconds.Text, out seconds))
            {
                //
            }
            else
            {
                seconds = 0;
            }

            timeLeft = (hours * 60 * 60) + (minutes * 60) + seconds;
            if(timeLeft > 0)
            {
                label1.Text = "или " + timeLeft + " секунд";
                //label2.Text = "Осталось " + (timeLeft / 60) + " минут" + " и " + (timeLeft % 60) + " секунд";
                label2.Text = "Осталось " + (timeLeft / 3600) + " часов, " + ((timeLeft % 3600) / 60) + " минут" + " и " + ((timeLeft % 3600) % 60) + " секунд";
                timer1.Start();
                txtLogOutput.AppendText(DateTime.Now + " " + "Таймер запущен" + Environment.NewLine);
            }
            else
            {
                txtLogOutput.AppendText(DateTime.Now + " " + "Пожалуйста, задайте время. Таймер НЕ запущен." + Environment.NewLine);
            }

            
        }

        private void txtTimer_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if(!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void btnStopTimer_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label1.Text = "СТОП";
            label2.Text = "";
            txtLogOutput.AppendText(DateTime.Now + " " + "Таймер прерван" + Environment.NewLine);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void timerHours_TextChanged(object sender, EventArgs e)
        {

        }

        private void timerHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void timerMinutes_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void timerSeconds_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
