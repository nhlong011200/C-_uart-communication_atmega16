namespace TBNV_KTGN_GK
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listcom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listbaudrate = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.den = new System.Windows.Forms.Button();
            this.quat = new System.Windows.Forms.Button();
            this.imgquat = new System.Windows.Forms.PictureBox();
            this.imgden = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.nhietdo = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgquat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgden)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // listcom
            // 
            this.listcom.FormattingEnabled = true;
            this.listcom.Location = new System.Drawing.Point(137, 19);
            this.listcom.Name = "listcom";
            this.listcom.Size = new System.Drawing.Size(136, 27);
            this.listcom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "BAUDRATE";
            // 
            // listbaudrate
            // 
            this.listbaudrate.FormattingEnabled = true;
            this.listbaudrate.Location = new System.Drawing.Point(137, 94);
            this.listbaudrate.Name = "listbaudrate";
            this.listbaudrate.Size = new System.Drawing.Size(136, 27);
            this.listbaudrate.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(287, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listcom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listbaudrate);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 147);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(480, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 146);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "THÔNG TIN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "N18DCDT030";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nguyễn Hoàng Long";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.den);
            this.groupBox3.Controls.Add(this.quat);
            this.groupBox3.Controls.Add(this.imgquat);
            this.groupBox3.Controls.Add(this.imgden);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(401, 215);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "THIẾT BỊ";
            // 
            // den
            // 
            this.den.Location = new System.Drawing.Point(45, 167);
            this.den.Name = "den";
            this.den.Size = new System.Drawing.Size(98, 42);
            this.den.TabIndex = 16;
            this.den.Text = "ON";
            this.den.UseVisualStyleBackColor = true;
            this.den.Click += new System.EventHandler(this.den_Click);
            // 
            // quat
            // 
            this.quat.Location = new System.Drawing.Point(254, 167);
            this.quat.Name = "quat";
            this.quat.Size = new System.Drawing.Size(98, 42);
            this.quat.TabIndex = 15;
            this.quat.Text = "ON";
            this.quat.UseVisualStyleBackColor = true;
            this.quat.Click += new System.EventHandler(this.quat_Click);
            // 
            // imgquat
            // 
            this.imgquat.Image = global::TBNV_KTGN_GK.Properties.Resources.quaton;
            this.imgquat.Location = new System.Drawing.Point(220, 31);
            this.imgquat.Name = "imgquat";
            this.imgquat.Size = new System.Drawing.Size(160, 118);
            this.imgquat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgquat.TabIndex = 14;
            this.imgquat.TabStop = false;
            // 
            // imgden
            // 
            this.imgden.Image = global::TBNV_KTGN_GK.Properties.Resources.denon;
            this.imgden.Location = new System.Drawing.Point(31, 31);
            this.imgden.Name = "imgden";
            this.imgden.Size = new System.Drawing.Size(145, 118);
            this.imgden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgden.TabIndex = 13;
            this.imgden.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.nhietdo);
            this.groupBox4.Controls.Add(this.pictureBox3);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(480, 191);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(346, 215);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CẢM BIẾN";
            // 
            // nhietdo
            // 
            this.nhietdo.Location = new System.Drawing.Point(155, 167);
            this.nhietdo.Name = "nhietdo";
            this.nhietdo.Size = new System.Drawing.Size(98, 42);
            this.nhietdo.TabIndex = 16;
            this.nhietdo.Text = "0 ";
            this.nhietdo.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TBNV_KTGN_GK.Properties.Resources.nhietdoon;
            this.pictureBox3.Location = new System.Drawing.Point(131, 23);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(146, 138);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "D18CQKD01-N";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgquat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgden)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox listcom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox listbaudrate;
        private System.Windows.Forms.Button button1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox imgquat;
        private System.Windows.Forms.PictureBox imgden;
        private System.Windows.Forms.Button den;
        private System.Windows.Forms.Button quat;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button nhietdo;
        private System.Windows.Forms.Label label5;
    }
}

