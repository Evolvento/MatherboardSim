using System.Resources;

namespace MotherBoardDiagnostic
{
  partial class Form1
  {
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Button buttonVoltage;
    private System.Windows.Forms.Button buttonResistance;
    private System.Windows.Forms.Button buttonContinuity;
    private System.Windows.Forms.Button buttonSignals;
    private System.Windows.Forms.Button buttonTemperature;
    private System.Windows.Forms.Button buttonRAM;
    private System.Windows.Forms.Button buttonArea1;
    private System.Windows.Forms.Button buttonArea2;
    private System.Windows.Forms.Button buttonArea3;
    private System.Windows.Forms.Button buttonArea4;
    private System.Windows.Forms.Button buttonArea5;
    private System.Windows.Forms.Button buttonArea6;
    private System.Windows.Forms.Button buttonArea7;
    private System.Windows.Forms.Button buttonArea8;

    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.buttonVoltage = new System.Windows.Forms.Button();
            this.buttonResistance = new System.Windows.Forms.Button();
            this.buttonContinuity = new System.Windows.Forms.Button();
            this.buttonSignals = new System.Windows.Forms.Button();
            this.buttonTemperature = new System.Windows.Forms.Button();
            this.buttonRAM = new System.Windows.Forms.Button();
            this.buttonArea1 = new System.Windows.Forms.Button();
            this.buttonArea2 = new System.Windows.Forms.Button();
            this.buttonArea3 = new System.Windows.Forms.Button();
            this.buttonArea4 = new System.Windows.Forms.Button();
            this.buttonArea5 = new System.Windows.Forms.Button();
            this.buttonArea6 = new System.Windows.Forms.Button();
            this.buttonArea7 = new System.Windows.Forms.Button();
            this.buttonArea8 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVoltage
            // 
            this.buttonVoltage.Location = new System.Drawing.Point(13, 12);
            this.buttonVoltage.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVoltage.Name = "buttonVoltage";
            this.buttonVoltage.Size = new System.Drawing.Size(100, 48);
            this.buttonVoltage.TabIndex = 0;
            this.buttonVoltage.Text = "Вольтметр";
            this.buttonVoltage.UseVisualStyleBackColor = true;
            this.buttonVoltage.Click += new System.EventHandler(this.SelectTool);
            // 
            // buttonResistance
            // 
            this.buttonResistance.Location = new System.Drawing.Point(121, 11);
            this.buttonResistance.Margin = new System.Windows.Forms.Padding(4);
            this.buttonResistance.Name = "buttonResistance";
            this.buttonResistance.Size = new System.Drawing.Size(123, 48);
            this.buttonResistance.TabIndex = 1;
            this.buttonResistance.Text = "Проверка на КЗ";
            this.buttonResistance.UseVisualStyleBackColor = true;
            this.buttonResistance.Click += new System.EventHandler(this.SelectTool);
            // 
            // buttonContinuity
            // 
            this.buttonContinuity.Location = new System.Drawing.Point(252, 11);
            this.buttonContinuity.Margin = new System.Windows.Forms.Padding(4);
            this.buttonContinuity.Name = "buttonContinuity";
            this.buttonContinuity.Size = new System.Drawing.Size(149, 47);
            this.buttonContinuity.TabIndex = 2;
            this.buttonContinuity.Text = "Диодная прозвонка";
            this.buttonContinuity.UseVisualStyleBackColor = true;
            this.buttonContinuity.Click += new System.EventHandler(this.SelectTool);
            // 
            // buttonSignals
            // 
            this.buttonSignals.Location = new System.Drawing.Point(409, 11);
            this.buttonSignals.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSignals.Name = "buttonSignals";
            this.buttonSignals.Size = new System.Drawing.Size(115, 47);
            this.buttonSignals.TabIndex = 3;
            this.buttonSignals.Text = "Осциллограф";
            this.buttonSignals.UseVisualStyleBackColor = true;
            this.buttonSignals.Click += new System.EventHandler(this.SelectTool);
            // 
            // buttonTemperature
            // 
            this.buttonTemperature.Location = new System.Drawing.Point(532, 11);
            this.buttonTemperature.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTemperature.Name = "buttonTemperature";
            this.buttonTemperature.Size = new System.Drawing.Size(174, 47);
            this.buttonTemperature.TabIndex = 4;
            this.buttonTemperature.Text = "Измерение температуры";
            this.buttonTemperature.UseVisualStyleBackColor = true;
            this.buttonTemperature.Click += new System.EventHandler(this.SelectTool);
            // 
            // buttonRAM
            // 
            this.buttonRAM.Location = new System.Drawing.Point(714, 11);
            this.buttonRAM.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRAM.Name = "buttonRAM";
            this.buttonRAM.Size = new System.Drawing.Size(103, 47);
            this.buttonRAM.TabIndex = 5;
            this.buttonRAM.Text = "Тестер ОЗУ";
            this.buttonRAM.UseVisualStyleBackColor = true;
            this.buttonRAM.Click += new System.EventHandler(this.SelectTool);
            // 
            // buttonArea1
            // 
            this.buttonArea1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonArea1.Location = new System.Drawing.Point(743, 252);
            this.buttonArea1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonArea1.Name = "buttonArea1";
            this.buttonArea1.Size = new System.Drawing.Size(64, 28);
            this.buttonArea1.TabIndex = 6;
            this.buttonArea1.Tag = "Area1";
            this.buttonArea1.Text = "3,3 В";
            this.buttonArea1.UseVisualStyleBackColor = false;
            this.buttonArea1.Visible = false;
            this.buttonArea1.Click += new System.EventHandler(this.SelectArea);
            // 
            // buttonArea2
            // 
            this.buttonArea2.Location = new System.Drawing.Point(743, 192);
            this.buttonArea2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonArea2.Name = "buttonArea2";
            this.buttonArea2.Size = new System.Drawing.Size(128, 52);
            this.buttonArea2.TabIndex = 7;
            this.buttonArea2.Tag = "Area2";
            this.buttonArea2.Text = "Проверка на КЗ омметром";
            this.buttonArea2.UseVisualStyleBackColor = true;
            this.buttonArea2.Visible = false;
            this.buttonArea2.Click += new System.EventHandler(this.SelectArea);
            // 
            // buttonArea3
            // 
            this.buttonArea3.Location = new System.Drawing.Point(190, 239);
            this.buttonArea3.Margin = new System.Windows.Forms.Padding(4);
            this.buttonArea3.Name = "buttonArea3";
            this.buttonArea3.Size = new System.Drawing.Size(100, 28);
            this.buttonArea3.TabIndex = 8;
            this.buttonArea3.Tag = "Area3";
            this.buttonArea3.Text = "Usb тест";
            this.buttonArea3.UseVisualStyleBackColor = true;
            this.buttonArea3.Visible = false;
            this.buttonArea3.Click += new System.EventHandler(this.SelectArea);
            // 
            // buttonArea4
            // 
            this.buttonArea4.Location = new System.Drawing.Point(502, 515);
            this.buttonArea4.Margin = new System.Windows.Forms.Padding(4);
            this.buttonArea4.Name = "buttonArea4";
            this.buttonArea4.Size = new System.Drawing.Size(100, 28);
            this.buttonArea4.TabIndex = 9;
            this.buttonArea4.Tag = "Area4";
            this.buttonArea4.Text = "Кварц";
            this.buttonArea4.UseVisualStyleBackColor = true;
            this.buttonArea4.Visible = false;
            this.buttonArea4.Click += new System.EventHandler(this.SelectArea);
            // 
            // buttonArea5
            // 
            this.buttonArea5.Location = new System.Drawing.Point(417, 160);
            this.buttonArea5.Margin = new System.Windows.Forms.Padding(4);
            this.buttonArea5.Name = "buttonArea5";
            this.buttonArea5.Size = new System.Drawing.Size(253, 71);
            this.buttonArea5.TabIndex = 10;
            this.buttonArea5.Tag = "Area5";
            this.buttonArea5.Text = "Температура";
            this.buttonArea5.UseVisualStyleBackColor = true;
            this.buttonArea5.Visible = false;
            this.buttonArea5.Click += new System.EventHandler(this.SelectArea);
            // 
            // buttonArea6
            // 
            this.buttonArea6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonArea6.Location = new System.Drawing.Point(602, 272);
            this.buttonArea6.Margin = new System.Windows.Forms.Padding(4);
            this.buttonArea6.Name = "buttonArea6";
            this.buttonArea6.Size = new System.Drawing.Size(68, 34);
            this.buttonArea6.TabIndex = 11;
            this.buttonArea6.Tag = "Area6";
            this.buttonArea6.Text = "ОЗУ";
            this.buttonArea6.UseVisualStyleBackColor = false;
            this.buttonArea6.Visible = false;
            this.buttonArea6.Click += new System.EventHandler(this.SelectArea);
            // 
            // buttonArea7
            // 
            this.buttonArea7.Location = new System.Drawing.Point(743, 288);
            this.buttonArea7.Margin = new System.Windows.Forms.Padding(4);
            this.buttonArea7.Name = "buttonArea7";
            this.buttonArea7.Size = new System.Drawing.Size(57, 28);
            this.buttonArea7.TabIndex = 12;
            this.buttonArea7.Tag = "Area7";
            this.buttonArea7.Text = "5 В";
            this.buttonArea7.UseVisualStyleBackColor = true;
            this.buttonArea7.Visible = false;
            this.buttonArea7.Click += new System.EventHandler(this.SelectArea);
            // 
            // buttonArea8
            // 
            this.buttonArea8.Location = new System.Drawing.Point(743, 324);
            this.buttonArea8.Margin = new System.Windows.Forms.Padding(4);
            this.buttonArea8.Name = "buttonArea8";
            this.buttonArea8.Size = new System.Drawing.Size(55, 28);
            this.buttonArea8.TabIndex = 13;
            this.buttonArea8.Tag = "Area8";
            this.buttonArea8.Text = "12 В";
            this.buttonArea8.UseVisualStyleBackColor = true;
            this.buttonArea8.Visible = false;
            this.buttonArea8.Click += new System.EventHandler(this.SelectArea);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(13, 66);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1259, 742);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MotherBoardDiagnostic.Properties.Resources.mainboard;
            this.pictureBox1.Location = new System.Drawing.Point(13, 68);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(769, 722);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 827);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonArea8);
            this.Controls.Add(this.buttonArea7);
            this.Controls.Add(this.buttonVoltage);
            this.Controls.Add(this.buttonResistance);
            this.Controls.Add(this.buttonContinuity);
            this.Controls.Add(this.buttonSignals);
            this.Controls.Add(this.buttonTemperature);
            this.Controls.Add(this.buttonRAM);
            this.Controls.Add(this.buttonArea1);
            this.Controls.Add(this.buttonArea2);
            this.Controls.Add(this.buttonArea3);
            this.Controls.Add(this.buttonArea4);
            this.Controls.Add(this.buttonArea5);
            this.Controls.Add(this.buttonArea6);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Диагностика материнской платы";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

    }

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.PictureBox pictureBox2;
    }
}

