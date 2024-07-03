namespace ITI.Presentation
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
            btn_add = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cb_dept = new ComboBox();
            nud_age = new NumericUpDown();
            txt_address = new TextBox();
            txt_name = new TextBox();
            dgv_students = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nud_age).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_students).BeginInit();
            SuspendLayout();
            // 
            // btn_add
            // 
            btn_add.Location = new Point(636, 19);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 20;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(308, 89);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 19;
            label4.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(320, 19);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 18;
            label3.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 92);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 17;
            label2.Text = "Age";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 17);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 16;
            label1.Text = "Name";
            // 
            // cb_dept
            // 
            cb_dept.FormattingEnabled = true;
            cb_dept.Location = new Point(393, 81);
            cb_dept.Name = "cb_dept";
            cb_dept.Size = new Size(193, 23);
            cb_dept.TabIndex = 15;
            // 
            // nud_age
            // 
            nud_age.Location = new Point(120, 84);
            nud_age.Name = "nud_age";
            nud_age.Size = new Size(165, 23);
            nud_age.TabIndex = 14;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(384, 17);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(193, 23);
            txt_address.TabIndex = 13;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(120, 17);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(165, 23);
            txt_name.TabIndex = 12;
            // 
            // dgv_students
            // 
            dgv_students.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_students.Dock = DockStyle.Bottom;
            dgv_students.Location = new Point(0, 159);
            dgv_students.Name = "dgv_students";
            dgv_students.Size = new Size(733, 240);
            dgv_students.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 399);
            Controls.Add(btn_add);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cb_dept);
            Controls.Add(nud_age);
            Controls.Add(txt_address);
            Controls.Add(txt_name);
            Controls.Add(dgv_students);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nud_age).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_students).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_add;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cb_dept;
        private NumericUpDown nud_age;
        private TextBox txt_address;
        private TextBox txt_name;
        private DataGridView dgv_students;
    }
}
