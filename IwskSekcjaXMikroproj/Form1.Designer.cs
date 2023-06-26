namespace IwskSekcjaXMikroproj
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sendTB = new TextBox();
            receiveTB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label10 = new Label();
            stationTypeCB = new ComboBox();
            label8 = new Label();
            flowControlTypeCB = new ComboBox();
            label9 = new Label();
            controlLetterCB = new ComboBox();
            label6 = new Label();
            dataBitsNumberCB = new ComboBox();
            label5 = new Label();
            stopBitsNumberCB = new ComboBox();
            label4 = new Label();
            transmissionSpeedBytesCB = new ComboBox();
            panel2 = new Panel();
            pingBT = new Button();
            receiveBT = new Button();
            sendBT = new Button();
            label11 = new Label();
            portCB = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // sendTB
            // 
            sendTB.Location = new Point(16, 81);
            sendTB.Margin = new Padding(3, 4, 3, 4);
            sendTB.Multiline = true;
            sendTB.Name = "sendTB";
            sendTB.Size = new Size(768, 280);
            sendTB.TabIndex = 2;
            // 
            // receiveTB
            // 
            receiveTB.Location = new Point(16, 392);
            receiveTB.Margin = new Padding(3, 4, 3, 4);
            receiveTB.Multiline = true;
            receiveTB.Name = "receiveTB";
            receiveTB.Size = new Size(768, 280);
            receiveTB.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 57);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 4;
            label1.Text = "Wysłano";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 368);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 5;
            label2.Text = "Odebrano";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 9);
            label3.Name = "label3";
            label3.Size = new Size(97, 23);
            label3.TabIndex = 6;
            label3.Text = "Ustawienia";
            // 
            // panel1
            // 
            panel1.Controls.Add(label11);
            panel1.Controls.Add(portCB);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(stationTypeCB);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(flowControlTypeCB);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(controlLetterCB);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dataBitsNumberCB);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(stopBitsNumberCB);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(transmissionSpeedBytesCB);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(818, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(290, 684);
            panel1.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 108);
            label10.Name = "label10";
            label10.Size = new Size(93, 20);
            label10.TabIndex = 18;
            label10.Text = "Rodzaj stacji";
            // 
            // stationTypeCB
            // 
            stationTypeCB.FormattingEnabled = true;
            stationTypeCB.Location = new Point(6, 132);
            stationTypeCB.Margin = new Padding(3, 4, 3, 4);
            stationTypeCB.Name = "stationTypeCB";
            stationTypeCB.Size = new Size(284, 28);
            stationTypeCB.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 397);
            label8.Name = "label8";
            label8.Size = new Size(159, 20);
            label8.TabIndex = 16;
            label8.Text = "Typ kontroli przepływu";
            // 
            // flowControlTypeCB
            // 
            flowControlTypeCB.FormattingEnabled = true;
            flowControlTypeCB.Location = new Point(6, 421);
            flowControlTypeCB.Margin = new Padding(3, 4, 3, 4);
            flowControlTypeCB.Name = "flowControlTypeCB";
            flowControlTypeCB.Size = new Size(284, 28);
            flowControlTypeCB.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 338);
            label9.Name = "label9";
            label9.Size = new Size(107, 20);
            label9.TabIndex = 14;
            label9.Text = "Znak kontrolny";
            // 
            // controlLetterCB
            // 
            controlLetterCB.FormattingEnabled = true;
            controlLetterCB.Location = new Point(6, 362);
            controlLetterCB.Margin = new Padding(3, 4, 3, 4);
            controlLetterCB.Name = "controlLetterCB";
            controlLetterCB.Size = new Size(284, 28);
            controlLetterCB.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 282);
            label6.Name = "label6";
            label6.Size = new Size(144, 20);
            label6.TabIndex = 12;
            label6.Text = "Liczba bitów danych";
            // 
            // dataBitsNumberCB
            // 
            dataBitsNumberCB.FormattingEnabled = true;
            dataBitsNumberCB.Location = new Point(6, 306);
            dataBitsNumberCB.Margin = new Padding(3, 4, 3, 4);
            dataBitsNumberCB.Name = "dataBitsNumberCB";
            dataBitsNumberCB.Size = new Size(284, 28);
            dataBitsNumberCB.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 223);
            label5.Name = "label5";
            label5.Size = new Size(134, 20);
            label5.TabIndex = 10;
            label5.Text = "Liczba bitów stopu";
            // 
            // stopBitsNumberCB
            // 
            stopBitsNumberCB.FormattingEnabled = true;
            stopBitsNumberCB.Location = new Point(6, 247);
            stopBitsNumberCB.Margin = new Padding(3, 4, 3, 4);
            stopBitsNumberCB.Name = "stopBitsNumberCB";
            stopBitsNumberCB.Size = new Size(284, 28);
            stopBitsNumberCB.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 164);
            label4.Name = "label4";
            label4.Size = new Size(203, 20);
            label4.TabIndex = 8;
            label4.Text = "Prędkość transmisji w bajtach";
            // 
            // transmissionSpeedBytesCB
            // 
            transmissionSpeedBytesCB.FormattingEnabled = true;
            transmissionSpeedBytesCB.Location = new Point(6, 188);
            transmissionSpeedBytesCB.Margin = new Padding(3, 4, 3, 4);
            transmissionSpeedBytesCB.Name = "transmissionSpeedBytesCB";
            transmissionSpeedBytesCB.Size = new Size(284, 28);
            transmissionSpeedBytesCB.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(pingBT);
            panel2.Controls.Add(receiveBT);
            panel2.Controls.Add(sendBT);
            panel2.Controls.Add(sendTB);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(receiveTB);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 684);
            panel2.TabIndex = 8;
            // 
            // pingBT
            // 
            pingBT.Location = new Point(216, 9);
            pingBT.Name = "pingBT";
            pingBT.Size = new Size(94, 29);
            pingBT.TabIndex = 12;
            pingBT.Text = "Ping";
            pingBT.UseVisualStyleBackColor = true;
            pingBT.Click += pingBT_Click;
            // 
            // receiveBT
            // 
            receiveBT.Location = new Point(116, 9);
            receiveBT.Name = "receiveBT";
            receiveBT.Size = new Size(94, 29);
            receiveBT.TabIndex = 11;
            receiveBT.Text = "Odbiór";
            receiveBT.UseVisualStyleBackColor = true;
            receiveBT.Click += receiveBT_Click;
            // 
            // sendBT
            // 
            sendBT.Location = new Point(16, 9);
            sendBT.Name = "sendBT";
            sendBT.Size = new Size(94, 29);
            sendBT.TabIndex = 6;
            sendBT.Text = "Nadawanie";
            sendBT.UseVisualStyleBackColor = true;
            sendBT.Click += sendBT_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 52);
            label11.Name = "label11";
            label11.Size = new Size(93, 20);
            label11.TabIndex = 20;
            label11.Text = "Wybór portu";
            // 
            // portCB
            // 
            portCB.FormattingEnabled = true;
            portCB.Location = new Point(6, 76);
            portCB.Margin = new Padding(3, 4, 3, 4);
            portCB.Name = "portCB";
            portCB.Size = new Size(284, 28);
            portCB.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 708);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox sendTB;
        private TextBox receiveTB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label label7;
        private ComboBox comboBox3;
        private Label label8;
        private ComboBox flowControlTypeCB;
        private Label label9;
        private ComboBox controlLetterCB;
        private Label label6;
        private ComboBox dataBitsNumberCB;
        private Label label5;
        private ComboBox stopBitsNumberCB;
        private Label label4;
        private ComboBox transmissionSpeedBytesCB;
        private Panel panel2;
        private Button button3;
        private Button button2;
        private Button sendBT;
        private Button pingBT;
        private Button receiveBT;
        private Label label10;
        private ComboBox stationTypeCB;
        private Label label11;
        private ComboBox portCB;
    }
}