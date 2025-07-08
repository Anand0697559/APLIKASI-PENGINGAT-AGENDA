namespace Pengingat_Agenda_App
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listBox1 = new ListBox();
            label4 = new Label();
            textBox1 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left;
            button1.BackColor = Color.Black;
            button1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.LightSteelBlue;
            button1.Location = new Point(390, 335);
            button1.Name = "button1";
            button1.Size = new Size(163, 34);
            button1.TabIndex = 0;
            button1.Text = "Tambah Jadwal";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Left;
            button2.BackColor = Color.Black;
            button2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.LightSteelBlue;
            button2.Location = new Point(390, 569);
            button2.Name = "button2";
            button2.Size = new Size(163, 34);
            button2.TabIndex = 1;
            button2.Text = "Hapus Jadwal";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.LightSlateGray;
            label1.Font = new Font("Trebuchet MS", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(139, 35);
            label1.Name = "label1";
            label1.Size = new Size(554, 55);
            label1.TabIndex = 2;
            label1.Text = "Aplikasi Pengingat Agenda";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.LightSteelBlue;
            label2.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(87, 176);
            label2.Name = "label2";
            label2.Size = new Size(139, 26);
            label2.TabIndex = 3;
            label2.Text = "Nama Agenda";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.LightSteelBlue;
            label3.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(87, 266);
            label3.Name = "label3";
            label3.Size = new Size(157, 26);
            label3.TabIndex = 4;
            label3.Text = "Tanggal Agenda";
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.Font = new Font("Trebuchet MS", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 26;
            listBox1.Location = new Point(278, 423);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(391, 82);
            listBox1.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.LightSteelBlue;
            label4.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(87, 423);
            label4.Name = "label4";
            label4.Size = new Size(154, 26);
            label4.TabIndex = 6;
            label4.Text = "Jadwal Agenda";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Trebuchet MS", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(278, 171);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(391, 31);
            textBox1.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.Location = new Point(278, 261);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(391, 31);
            dateTimePicker1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(799, 649);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Pengingat Agenda App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox listBox1;
        private Label label4;
        private TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private DateTimePicker dateTimePicker1;
    }
}
