
namespace RCArduinoT
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnComPort = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnOn = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtLogOutput = new System.Windows.Forms.TextBox();
            this.chkTimerRepeat = new System.Windows.Forms.CheckBox();
            this.btnStopTimer = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timerHours = new System.Windows.Forms.TextBox();
            this.timerMinutes = new System.Windows.Forms.TextBox();
            this.timerSeconds = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnComPort
            // 
            this.btnComPort.Location = new System.Drawing.Point(6, 19);
            this.btnComPort.Name = "btnComPort";
            this.btnComPort.Size = new System.Drawing.Size(171, 23);
            this.btnComPort.TabIndex = 0;
            this.btnComPort.Text = "Получить COM-порт";
            this.btnComPort.UseVisualStyleBackColor = true;
            this.btnComPort.Click += new System.EventHandler(this.btnComPort_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(6, 91);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(171, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Подключиться";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnOn
            // 
            this.btnOn.Location = new System.Drawing.Point(6, 249);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(171, 23);
            this.btnOn.TabIndex = 2;
            this.btnOn.Text = "Нажать кнопку 1";
            this.btnOn.UseVisualStyleBackColor = true;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(6, 278);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(171, 23);
            this.btnOff.TabIndex = 3;
            this.btnOff.Text = "Нажать кнопку 2";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(208, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Таймер";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnComPort);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btnOn);
            this.groupBox1.Controls.Add(this.btnOff);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 310);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подключение Arduino";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Служебные кнопки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Выберите COM-порт из списка";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Запуск таймера";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLogOutput
            // 
            this.txtLogOutput.Location = new System.Drawing.Point(513, 76);
            this.txtLogOutput.Multiline = true;
            this.txtLogOutput.Name = "txtLogOutput";
            this.txtLogOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogOutput.Size = new System.Drawing.Size(292, 315);
            this.txtLogOutput.TabIndex = 8;
            // 
            // chkTimerRepeat
            // 
            this.chkTimerRepeat.AutoSize = true;
            this.chkTimerRepeat.Location = new System.Drawing.Point(6, 77);
            this.chkTimerRepeat.Name = "chkTimerRepeat";
            this.chkTimerRepeat.Size = new System.Drawing.Size(194, 17);
            this.chkTimerRepeat.TabIndex = 9;
            this.chkTimerRepeat.Text = "Автоматический повтор таймера";
            this.chkTimerRepeat.UseVisualStyleBackColor = true;
            this.chkTimerRepeat.CheckedChanged += new System.EventHandler(this.chkTimerRepeat_CheckedChanged);
            // 
            // btnStopTimer
            // 
            this.btnStopTimer.Location = new System.Drawing.Point(0, 129);
            this.btnStopTimer.Name = "btnStopTimer";
            this.btnStopTimer.Size = new System.Drawing.Size(200, 23);
            this.btnStopTimer.TabIndex = 11;
            this.btnStopTimer.Text = "Останов таймера";
            this.btnStopTimer.UseVisualStyleBackColor = true;
            this.btnStopTimer.Click += new System.EventHandler(this.btnStopTimer_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(704, 12);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(100, 23);
            this.btnAbout.TabIndex = 12;
            this.btnAbout.Text = "О программе";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(208, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Таймер";
            // 
            // timerHours
            // 
            this.timerHours.Location = new System.Drawing.Point(9, 30);
            this.timerHours.Name = "timerHours";
            this.timerHours.Size = new System.Drawing.Size(44, 20);
            this.timerHours.TabIndex = 15;
            this.timerHours.TextChanged += new System.EventHandler(this.timerHours_TextChanged);
            this.timerHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timerHours_KeyPress);
            // 
            // timerMinutes
            // 
            this.timerMinutes.Location = new System.Drawing.Point(69, 30);
            this.timerMinutes.Name = "timerMinutes";
            this.timerMinutes.Size = new System.Drawing.Size(44, 20);
            this.timerMinutes.TabIndex = 16;
            this.timerMinutes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timerMinutes_KeyPress);
            // 
            // timerSeconds
            // 
            this.timerSeconds.Location = new System.Drawing.Point(131, 30);
            this.timerSeconds.Name = "timerSeconds";
            this.timerSeconds.Size = new System.Drawing.Size(44, 20);
            this.timerSeconds.TabIndex = 17;
            this.timerSeconds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timerSeconds_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Часы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Минуты";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Секунды";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.timerHours);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnStopTimer);
            this.groupBox2.Controls.Add(this.timerMinutes);
            this.groupBox2.Controls.Add(this.chkTimerRepeat);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.timerSeconds);
            this.groupBox2.Location = new System.Drawing.Point(201, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 219);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Таймер";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 445);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.txtLogOutput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Контроль температуры";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLogOutput;
        private System.Windows.Forms.CheckBox chkTimerRepeat;
        private System.Windows.Forms.Button btnStopTimer;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox timerHours;
        private System.Windows.Forms.TextBox timerMinutes;
        private System.Windows.Forms.TextBox timerSeconds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

