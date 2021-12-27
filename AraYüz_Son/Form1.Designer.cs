
namespace AraYüz_Son
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_sensor3 = new System.Windows.Forms.TextBox();
            this.textBox_sensor2 = new System.Windows.Forms.TextBox();
            this.textBox_sensor1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_Open = new System.Windows.Forms.Button();
            this.comboBox_Baud = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Port = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_led4 = new System.Windows.Forms.Button();
            this.button_led3 = new System.Windows.Forms.Button();
            this.button_led2 = new System.Windows.Forms.Button();
            this.button_led1 = new System.Windows.Forms.Button();
            this.groupBox_ServoPosition = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.trackBar_ServoKapı = new System.Windows.Forms.TrackBar();
            this.trackBar_ServoPencere = new System.Windows.Forms.TrackBar();
            this.label_ServoKapı = new System.Windows.Forms.Label();
            this.label_ServoPencere = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_ServoPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_ServoKapı)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_ServoPencere)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBox_sensor3);
            this.panel1.Controls.Add(this.textBox_sensor2);
            this.panel1.Controls.Add(this.textBox_sensor1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(391, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 154);
            this.panel1.TabIndex = 0;
            // 
            // textBox_sensor3
            // 
            this.textBox_sensor3.Location = new System.Drawing.Point(315, 61);
            this.textBox_sensor3.Name = "textBox_sensor3";
            this.textBox_sensor3.Size = new System.Drawing.Size(100, 20);
            this.textBox_sensor3.TabIndex = 5;
            // 
            // textBox_sensor2
            // 
            this.textBox_sensor2.Location = new System.Drawing.Point(180, 62);
            this.textBox_sensor2.Name = "textBox_sensor2";
            this.textBox_sensor2.Size = new System.Drawing.Size(99, 20);
            this.textBox_sensor2.TabIndex = 4;
            // 
            // textBox_sensor1
            // 
            this.textBox_sensor1.Location = new System.Drawing.Point(34, 64);
            this.textBox_sensor1.Name = "textBox_sensor1";
            this.textBox_sensor1.Size = new System.Drawing.Size(98, 20);
            this.textBox_sensor1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(341, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Sıcaklık";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(177, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hareket Sensörü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(43, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Gaz Sensörü";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(45, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Portlar:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button_Close);
            this.groupBox1.Controls.Add(this.button_Open);
            this.groupBox1.Controls.Add(this.comboBox_Baud);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_Port);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(512, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 145);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port Ayarları";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(201, 92);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(59, 24);
            this.button_Close.TabIndex = 6;
            this.button_Close.Text = "Kapa";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_Open
            // 
            this.button_Open.Location = new System.Drawing.Point(201, 34);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(59, 24);
            this.button_Open.TabIndex = 5;
            this.button_Open.Text = "Aç";
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // comboBox_Baud
            // 
            this.comboBox_Baud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Baud.FormattingEnabled = true;
            this.comboBox_Baud.Items.AddRange(new object[] {
            "9600",
            "38400",
            "57600",
            "115200"});
            this.comboBox_Baud.Location = new System.Drawing.Point(99, 95);
            this.comboBox_Baud.Name = "comboBox_Baud";
            this.comboBox_Baud.Size = new System.Drawing.Size(70, 21);
            this.comboBox_Baud.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(37, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Frekans:";
            // 
            // comboBox_Port
            // 
            this.comboBox_Port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Port.FormattingEnabled = true;
            this.comboBox_Port.Location = new System.Drawing.Point(99, 37);
            this.comboBox_Port.Name = "comboBox_Port";
            this.comboBox_Port.Size = new System.Drawing.Size(70, 21);
            this.comboBox_Port.TabIndex = 2;
            this.comboBox_Port.DropDown += new System.EventHandler(this.comboBox_Port_DropDown);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button_led4);
            this.groupBox2.Controls.Add(this.button_led3);
            this.groupBox2.Controls.Add(this.button_led2);
            this.groupBox2.Controls.Add(this.button_led1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(21, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 145);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Işık Kontrol";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(360, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "220 V ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(251, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Led 3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Led 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Led 1";
            // 
            // button_led4
            // 
            this.button_led4.BackColor = System.Drawing.Color.Gray;
            this.button_led4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_led4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_led4.Location = new System.Drawing.Point(338, 59);
            this.button_led4.Name = "button_led4";
            this.button_led4.Size = new System.Drawing.Size(76, 40);
            this.button_led4.TabIndex = 3;
            this.button_led4.UseVisualStyleBackColor = false;
            this.button_led4.Click += new System.EventHandler(this.button_led4_Click);
            // 
            // button_led3
            // 
            this.button_led3.BackColor = System.Drawing.Color.Gray;
            this.button_led3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_led3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_led3.Location = new System.Drawing.Point(234, 59);
            this.button_led3.Name = "button_led3";
            this.button_led3.Size = new System.Drawing.Size(82, 40);
            this.button_led3.TabIndex = 2;
            this.button_led3.UseVisualStyleBackColor = false;
            this.button_led3.Click += new System.EventHandler(this.button_led3_Click);
            // 
            // button_led2
            // 
            this.button_led2.BackColor = System.Drawing.Color.Gray;
            this.button_led2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_led2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_led2.Location = new System.Drawing.Point(121, 59);
            this.button_led2.Name = "button_led2";
            this.button_led2.Size = new System.Drawing.Size(82, 40);
            this.button_led2.TabIndex = 1;
            this.button_led2.UseVisualStyleBackColor = false;
            this.button_led2.Click += new System.EventHandler(this.button_led2_Click);
            // 
            // button_led1
            // 
            this.button_led1.BackColor = System.Drawing.Color.Gray;
            this.button_led1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_led1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_led1.Location = new System.Drawing.Point(6, 59);
            this.button_led1.Name = "button_led1";
            this.button_led1.Size = new System.Drawing.Size(82, 40);
            this.button_led1.TabIndex = 0;
            this.button_led1.UseVisualStyleBackColor = false;
            this.button_led1.Click += new System.EventHandler(this.button_led1_Click);
            // 
            // groupBox_ServoPosition
            // 
            this.groupBox_ServoPosition.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_ServoPosition.Controls.Add(this.label_ServoPencere);
            this.groupBox_ServoPosition.Controls.Add(this.label_ServoKapı);
            this.groupBox_ServoPosition.Controls.Add(this.trackBar_ServoPencere);
            this.groupBox_ServoPosition.Controls.Add(this.trackBar_ServoKapı);
            this.groupBox_ServoPosition.Controls.Add(this.label11);
            this.groupBox_ServoPosition.Controls.Add(this.label10);
            this.groupBox_ServoPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox_ServoPosition.Location = new System.Drawing.Point(21, 6);
            this.groupBox_ServoPosition.Name = "groupBox_ServoPosition";
            this.groupBox_ServoPosition.Size = new System.Drawing.Size(353, 160);
            this.groupBox_ServoPosition.TabIndex = 4;
            this.groupBox_ServoPosition.TabStop = false;
            this.groupBox_ServoPosition.Text = "Kapı,Pencere ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Kapı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Pencere";
            // 
            // trackBar_ServoKapı
            // 
            this.trackBar_ServoKapı.Location = new System.Drawing.Point(74, 29);
            this.trackBar_ServoKapı.Maximum = 180;
            this.trackBar_ServoKapı.Name = "trackBar_ServoKapı";
            this.trackBar_ServoKapı.Size = new System.Drawing.Size(173, 45);
            this.trackBar_ServoKapı.TabIndex = 2;
            this.trackBar_ServoKapı.Scroll += new System.EventHandler(this.trackBar_ServoKapı_Scroll);
            // 
            // trackBar_ServoPencere
            // 
            this.trackBar_ServoPencere.Location = new System.Drawing.Point(74, 94);
            this.trackBar_ServoPencere.Maximum = 180;
            this.trackBar_ServoPencere.Name = "trackBar_ServoPencere";
            this.trackBar_ServoPencere.Size = new System.Drawing.Size(173, 45);
            this.trackBar_ServoPencere.TabIndex = 3;
            this.trackBar_ServoPencere.Scroll += new System.EventHandler(this.trackBar_ServoPencere_Scroll);
            // 
            // label_ServoKapı
            // 
            this.label_ServoKapı.AutoSize = true;
            this.label_ServoKapı.Location = new System.Drawing.Point(253, 47);
            this.label_ServoKapı.Name = "label_ServoKapı";
            this.label_ServoKapı.Size = new System.Drawing.Size(43, 13);
            this.label_ServoKapı.TabIndex = 4;
            this.label_ServoKapı.Text = "Aralık:";
            // 
            // label_ServoPencere
            // 
            this.label_ServoPencere.AutoSize = true;
            this.label_ServoPencere.Location = new System.Drawing.Point(253, 111);
            this.label_ServoPencere.Name = "label_ServoPencere";
            this.label_ServoPencere.Size = new System.Drawing.Size(39, 13);
            this.label_ServoPencere.TabIndex = 5;
            this.label_ServoPencere.Text = "Aralık";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(147, 330);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 16);
            this.label12.TabIndex = 5;
            this.label12.Text = "Mehmet Gökay DOĞANER";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(509, 330);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 16);
            this.label13.TabIndex = 6;
            this.label13.Text = "Veysel Can DEMİR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(825, 352);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox_ServoPosition);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Akıllı Ev Kontrol ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox_ServoPosition.ResumeLayout(false);
            this.groupBox_ServoPosition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_ServoKapı)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_ServoPencere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.ComboBox comboBox_Baud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Port;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_sensor3;
        private System.Windows.Forms.TextBox textBox_sensor2;
        private System.Windows.Forms.TextBox textBox_sensor1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_led4;
        private System.Windows.Forms.Button button_led3;
        private System.Windows.Forms.Button button_led2;
        private System.Windows.Forms.Button button_led1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox_ServoPosition;
        private System.Windows.Forms.TrackBar trackBar_ServoPencere;
        private System.Windows.Forms.TrackBar trackBar_ServoKapı;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_ServoPencere;
        private System.Windows.Forms.Label label_ServoKapı;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

