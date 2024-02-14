namespace UCL_2015
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
            Leagues_button = new Button();
            Leagues_disp = new DataGridView();
            Leagues_text = new TextBox();
            button2 = new Button();
            dataGridView2 = new DataGridView();
            SP_button = new Button();
            SP_disp = new DataGridView();
            label1 = new Label();
            SP_text = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)Leagues_disp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SP_disp).BeginInit();
            SuspendLayout();
            // 
            // Leagues_button
            // 
            Leagues_button.Location = new Point(346, 26);
            Leagues_button.Margin = new Padding(3, 2, 3, 2);
            Leagues_button.Name = "Leagues_button";
            Leagues_button.Size = new Size(92, 30);
            Leagues_button.TabIndex = 0;
            Leagues_button.Text = "button1";
            Leagues_button.UseVisualStyleBackColor = true;
            Leagues_button.Click += button1_Click;
            // 
            // Leagues_disp
            // 
            Leagues_disp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Leagues_disp.Location = new Point(12, 60);
            Leagues_disp.Margin = new Padding(3, 2, 3, 2);
            Leagues_disp.Name = "Leagues_disp";
            Leagues_disp.RowHeadersWidth = 51;
            Leagues_disp.RowTemplate.Height = 29;
            Leagues_disp.Size = new Size(426, 328);
            Leagues_disp.TabIndex = 1;
            // 
            // Leagues_text
            // 
            Leagues_text.Location = new Point(533, 65);
            Leagues_text.Margin = new Padding(3, 2, 3, 2);
            Leagues_text.Name = "Leagues_text";
            Leagues_text.Size = new Size(368, 23);
            Leagues_text.TabIndex = 4;
            Leagues_text.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(907, 65);
            button2.Name = "button2";
            button2.Size = new Size(82, 24);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(533, 93);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(456, 146);
            dataGridView2.TabIndex = 7;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // SP_button
            // 
            SP_button.Location = new Point(914, 299);
            SP_button.Name = "SP_button";
            SP_button.Size = new Size(75, 23);
            SP_button.TabIndex = 8;
            SP_button.Text = "button3";
            SP_button.UseVisualStyleBackColor = true;
            SP_button.Click += SP_button_Click;
            // 
            // SP_disp
            // 
            SP_disp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SP_disp.Location = new Point(533, 328);
            SP_disp.Name = "SP_disp";
            SP_disp.RowHeadersWidth = 51;
            SP_disp.RowTemplate.Height = 25;
            SP_disp.Size = new Size(456, 60);
            SP_disp.TabIndex = 10;
            SP_disp.CellContentClick += SP_disp_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(300, 21);
            label1.TabIndex = 11;
            label1.Text = "Press button 1 to display the Leagues :";
            label1.Click += label1_Click;
            // 
            // SP_text
            // 
            SP_text.Location = new Point(533, 299);
            SP_text.Name = "SP_text";
            SP_text.Size = new Size(345, 23);
            SP_text.TabIndex = 12;
            SP_text.TextChanged += SP_text_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(533, 9);
            label2.Name = "label2";
            label2.Size = new Size(348, 42);
            label2.TabIndex = 13;
            label2.Text = "Pick a league to display it's respective teams\r\nPress button 2\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(533, 254);
            label3.Name = "label3";
            label3.Size = new Size(211, 42);
            label3.TabIndex = 14;
            label3.Text = "Pick a Team (Team Name) \r\nPress button 3\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 411);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(SP_text);
            Controls.Add(label1);
            Controls.Add(SP_disp);
            Controls.Add(SP_button);
            Controls.Add(dataGridView2);
            Controls.Add(button2);
            Controls.Add(Leagues_text);
            Controls.Add(Leagues_disp);
            Controls.Add(Leagues_button);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Leagues_disp).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)SP_disp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Leagues_button;
        private DataGridView Leagues_disp;
        private TextBox Leagues_text;
        private Button button2;
        private DataGridView dataGridView2;
        private Button SP_button;
        private DataGridView SP_disp;
        private Label label1;
        private TextBox SP_text;
        private Label label2;
        private Label label3;
    }
}