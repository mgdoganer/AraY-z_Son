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

namespace AraYüz_Son
{
    public partial class Form1 : Form
    {
        bool on1 = true;
        bool on2 = true;
        bool on3 = true;
        bool on4 = true;
        bool toggleLight1 = true;
        bool toggleLight2 = true;
        bool toggleLight3 = true;
        bool toggleLight4 = true;
        Timer t1 = new Timer();
        Timer t2 = new Timer();
        Timer t3 = new Timer();
        Timer t4 = new Timer();
        string serialDataIn;
        sbyte indexOfA, indexOfB, indexOfC;
        string dataSensor1, dataSensor2, dataSensor3;

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_led1.Text = "Kapalı";
            t1.Interval = 1000;
            t1.Tick += new EventHandler(t_Tick1);

            button_led2.Text = "Kapalı";
            t2.Interval = 1000;
            t2.Tick += new EventHandler(t_Tick2);

            button_led3.Text = "Kapalı";
            t3.Interval = 1000;
            t3.Tick += new EventHandler(t_Tick3);

            button_led4.Text = "Kapalı";
            t4.Interval = 1000;
            t4.Tick += new EventHandler(t_Tick4);

            
            button_Open.Enabled = true;
            button_Close.Enabled = false;
            comboBox_Baud.Text = "9600";

        }

        private void t_Tick1(object sender, EventArgs e)
        {
            if(toggleLight1)
            {
                button_led1.BackColor = Color.LimeGreen;
                toggleLight1 = false;
            }
            else
            {
                button_led1.BackColor = Color.Gray;
                toggleLight1 = true;
            }
        }

        private void t_Tick2(object sender, EventArgs e)
        {
            if (toggleLight2)
            {
                button_led2.BackColor = Color.LimeGreen;
                toggleLight2 = false;
            }
            else
            {
                button_led2.BackColor = Color.Gray;
                toggleLight2 = true;
            }
        }

        private void t_Tick3(object sender, EventArgs e)
        {
            if (toggleLight3)
            {
                button_led3.BackColor = Color.LimeGreen;
                toggleLight3 = false;
            }
            else
            {
                button_led3.BackColor = Color.Gray;
                toggleLight3 = true;
            }
        }
        private void t_Tick4(object sender, EventArgs e)
        {
            if (toggleLight4)
            {
                button_led4.BackColor = Color.LimeGreen;
                toggleLight4 = false;
            }
            else
            {
                button_led4.BackColor = Color.Gray;
                toggleLight4 = true;
            }
        }

        private void comboBox_Port_DropDown(object sender, EventArgs e)
        {
            string[] portLists = SerialPort.GetPortNames();
            comboBox_Port.Items.Clear();
            comboBox_Port.Items.AddRange(portLists);

        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox_Port.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBox_Baud.Text);
                serialPort1.Open();

                button_Open.Enabled = false;
                button_Close.Enabled = true;

            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void button_led1_Click(object sender, EventArgs e)
        {
            if (on1)
            {
                
                button_led1.Text = "AÇIK";
                t1.Start();
                on1 = false;

            }
            else
            {
                
                button_led1.Text = "Kapalı";
                button_led1.BackColor = Color.Gray;
                t1.Stop();
                on1 = true;
            }
        }

        private void button_led2_Click(object sender, EventArgs e)
        {
            if (on2)
            {

                button_led2.Text = "AÇIK";
                t2.Start();
                on2 = false;

            }
            else
            {

                button_led2.Text = "Kapalı";
                button_led2.BackColor = Color.Gray;
                t2.Stop();
                on2 = true;
            }
        }

        private void button_led3_Click(object sender, EventArgs e)
        {
            if (on3)
            {

                button_led3.Text = "AÇIK";
                t3.Start();
                on3 = false;

            }
            else
            {

                button_led3.Text = "Kapalı";
                button_led3.BackColor = Color.Gray;
                t3.Stop();
                on3 = true;
            }
        }

        private void button_led4_Click(object sender, EventArgs e)
        {
            if (on4)
            {

                button_led4.Text = "AÇIK";
                t4.Start();
                on4 = false;

            }
            else
            {

                button_led4.Text = "Kapalı";
                button_led4.BackColor = Color.Gray;
                t4.Stop();
                on4 = true;
            }
        }

        private void trackBar_ServoKapı_Scroll(object sender, EventArgs e)
        {
            int degree = trackBar_ServoKapı.Value;

            label_ServoKapı.Text = "Aralık: " + degree.ToString();
            if(serialPort1.IsOpen)
            {
                serialPort1.Write(degree + "A" + "\n");
            }
        }

        private void trackBar_ServoPencere_Scroll(object sender, EventArgs e)
        {
            int degree = trackBar_ServoPencere.Value;

            label_ServoPencere.Text = "Aralık: " + degree.ToString();
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(degree + "B" + "\n");
            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();

                button_Open.Enabled = true;
                button_Close.Enabled = false;


            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                serialPort1.Close();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            serialDataIn = serialPort1.ReadLine();
            this.BeginInvoke(new EventHandler(ProcessData));

        }

        private void ProcessData(object sender, EventArgs e)
        {
            try
            {
                indexOfA = Convert.ToSByte(serialDataIn.IndexOf("A"));
                indexOfB = Convert.ToSByte(serialDataIn.IndexOf("B"));
                indexOfC = Convert.ToSByte(serialDataIn.IndexOf("C"));

                dataSensor1 = serialDataIn.Substring(0, indexOfA);
                dataSensor2 = serialDataIn.Substring(indexOfA + 1, (indexOfB - indexOfA) - 1);
                dataSensor3 = serialDataIn.Substring(indexOfB + 1, (indexOfC - indexOfB) - 1);

                textBox_sensor1.Text = dataSensor1;
                textBox_sensor2.Text = dataSensor2;
                textBox_sensor3.Text = dataSensor3;
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }
    }
}
