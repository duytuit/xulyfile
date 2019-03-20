using System.Windows.Forms;

namespace XoaTepTinTheoSoDong
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDeleteLine = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.soluongview3 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.soluongdelete = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.soluongview4 = new System.Windows.Forms.Label();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.Soluongview1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Soluongview2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtVitrixoa = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDenvitri = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(37, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(269, 199);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Chọn Tệp";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeleteLine
            // 
            this.btnDeleteLine.Enabled = false;
            this.btnDeleteLine.Location = new System.Drawing.Point(321, 194);
            this.btnDeleteLine.Name = "btnDeleteLine";
            this.btnDeleteLine.Size = new System.Drawing.Size(113, 23);
            this.btnDeleteLine.TabIndex = 4;
            this.btnDeleteLine.Text = "Thực Thi";
            this.btnDeleteLine.UseVisualStyleBackColor = true;
            this.btnDeleteLine.Click += new System.EventHandler(this.btnDeleteLine_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(446, 46);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(289, 199);
            this.listBox2.TabIndex = 7;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // txtValue
            // 
            this.txtValue.Enabled = false;
            this.txtValue.Location = new System.Drawing.Point(321, 68);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(113, 20);
            this.txtValue.TabIndex = 16;
            this.txtValue.Text = "%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Xóa từ vị trí 0 đến:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.soluongview3);
            this.groupBox2.Controls.Add(this.listBox3);
            this.groupBox2.Location = new System.Drawing.Point(37, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 288);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dữ liệu cũ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số lượng:";
            // 
            // soluongview3
            // 
            this.soluongview3.AutoSize = true;
            this.soluongview3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soluongview3.ForeColor = System.Drawing.Color.Red;
            this.soluongview3.Location = new System.Drawing.Point(286, 10);
            this.soluongview3.Name = "soluongview3";
            this.soluongview3.Size = new System.Drawing.Size(0, 20);
            this.soluongview3.TabIndex = 1;
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.Color.White;
            this.listBox3.ForeColor = System.Drawing.Color.Black;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(6, 33);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(326, 251);
            this.listBox3.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.soluongdelete);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.soluongview4);
            this.groupBox3.Controls.Add(this.listBox4);
            this.groupBox3.Location = new System.Drawing.Point(381, 249);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 288);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dữ liệu mới";
            // 
            // soluongdelete
            // 
            this.soluongdelete.AutoSize = true;
            this.soluongdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soluongdelete.ForeColor = System.Drawing.Color.Red;
            this.soluongdelete.Location = new System.Drawing.Point(163, 10);
            this.soluongdelete.Name = "soluongdelete";
            this.soluongdelete.Size = new System.Drawing.Size(0, 20);
            this.soluongdelete.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Dòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Xóa :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số lượng:";
            // 
            // soluongview4
            // 
            this.soluongview4.AutoSize = true;
            this.soluongview4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soluongview4.ForeColor = System.Drawing.Color.Red;
            this.soluongview4.Location = new System.Drawing.Point(297, 10);
            this.soluongview4.Name = "soluongview4";
            this.soluongview4.Size = new System.Drawing.Size(0, 20);
            this.soluongview4.TabIndex = 2;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(6, 32);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(342, 251);
            this.listBox4.TabIndex = 1;
            this.listBox4.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // Soluongview1
            // 
            this.Soluongview1.AutoSize = true;
            this.Soluongview1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Soluongview1.ForeColor = System.Drawing.Color.Red;
            this.Soluongview1.Location = new System.Drawing.Point(187, 19);
            this.Soluongview1.Name = "Soluongview1";
            this.Soluongview1.Size = new System.Drawing.Size(0, 20);
            this.Soluongview1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Số lượng 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Số lượng 2:";
            // 
            // Soluongview2
            // 
            this.Soluongview2.AutoSize = true;
            this.Soluongview2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Soluongview2.ForeColor = System.Drawing.Color.Red;
            this.Soluongview2.Location = new System.Drawing.Point(515, 19);
            this.Soluongview2.Name = "Soluongview2";
            this.Soluongview2.Size = new System.Drawing.Size(0, 20);
            this.Soluongview2.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(321, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Làm mới";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtVitrixoa
            // 
            this.txtVitrixoa.Location = new System.Drawing.Point(60, 19);
            this.txtVitrixoa.Name = "txtVitrixoa";
            this.txtVitrixoa.Size = new System.Drawing.Size(41, 20);
            this.txtVitrixoa.TabIndex = 26;
            this.txtVitrixoa.TextChanged += new System.EventHandler(this.txtVitrixoa_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtDenvitri);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtVitrixoa);
            this.groupBox1.Location = new System.Drawing.Point(321, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 94);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xóa tấm T3 - B3";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Từ vị trí :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Đến vị trí :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtDenvitri
            // 
            this.txtDenvitri.Location = new System.Drawing.Point(60, 45);
            this.txtDenvitri.Name = "txtDenvitri";
            this.txtDenvitri.Size = new System.Drawing.Size(41, 20);
            this.txtDenvitri.TabIndex = 28;
            this.txtDenvitri.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(18, 71);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 17);
            this.checkBox1.TabIndex = 30;
            this.checkBox1.Text = "Xác nhận xóa";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(774, 559);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Soluongview2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Soluongview1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnDeleteLine);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XuLyFile_v1.0 Factory: Meiko Viet Nam";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDeleteLine;
        private System.Windows.Forms.ListBox listBox2;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox txtValue;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ListBox listBox3;
        private ListBox listBox4;
        private Label Soluongview1;
        private Label label2;
        private Label label3;
        private Label Soluongview2;
        private Label label4;
        private Label soluongview3;
        private Label label5;
        private Label soluongview4;
        private Label soluongdelete;
        private Label label7;
        private Label label6;
        private Button button2;
        private TextBox txtVitrixoa;
        private GroupBox groupBox1;
        private Label label8;
        private Label label9;
        private TextBox txtDenvitri;
        private CheckBox checkBox1;
    }
   

}

