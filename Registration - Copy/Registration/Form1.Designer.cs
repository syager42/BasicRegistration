namespace Registration
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
            this.buttonNewStudent = new System.Windows.Forms.Button();
            this.buttonEditStudent = new System.Windows.Forms.Button();
            this.buttonDrop = new System.Windows.Forms.Button();
            this.textBoxShowStudent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearchStudent = new System.Windows.Forms.Button();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelErrorStudent = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxClasses = new System.Windows.Forms.ComboBox();
            this.buttonAddClass = new System.Windows.Forms.Button();
            this.labelErrorClass = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonClearAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNewStudent
            // 
            this.buttonNewStudent.Location = new System.Drawing.Point(28, 285);
            this.buttonNewStudent.Name = "buttonNewStudent";
            this.buttonNewStudent.Size = new System.Drawing.Size(91, 23);
            this.buttonNewStudent.TabIndex = 0;
            this.buttonNewStudent.Text = "New Student";
            this.toolTip1.SetToolTip(this.buttonNewStudent, "Add a new student to system");
            this.buttonNewStudent.UseVisualStyleBackColor = true;
            this.buttonNewStudent.Click += new System.EventHandler(this.buttonNewStudent_Click);
            // 
            // buttonEditStudent
            // 
            this.buttonEditStudent.Enabled = false;
            this.buttonEditStudent.Location = new System.Drawing.Point(146, 285);
            this.buttonEditStudent.Name = "buttonEditStudent";
            this.buttonEditStudent.Size = new System.Drawing.Size(91, 23);
            this.buttonEditStudent.TabIndex = 1;
            this.buttonEditStudent.Text = "Edit Information";
            this.toolTip1.SetToolTip(this.buttonEditStudent, "Update your contact information");
            this.buttonEditStudent.UseVisualStyleBackColor = true;
            this.buttonEditStudent.Click += new System.EventHandler(this.buttonEditStudent_Click);
            // 
            // buttonDrop
            // 
            this.buttonDrop.Location = new System.Drawing.Point(834, 285);
            this.buttonDrop.Name = "buttonDrop";
            this.buttonDrop.Size = new System.Drawing.Size(91, 23);
            this.buttonDrop.TabIndex = 3;
            this.buttonDrop.Text = "Drop Class";
            this.toolTip1.SetToolTip(this.buttonDrop, "Immediately drop selected class");
            this.buttonDrop.UseVisualStyleBackColor = true;
            this.buttonDrop.Click += new System.EventHandler(this.buttonDrop_Click);
            // 
            // textBoxShowStudent
            // 
            this.textBoxShowStudent.Location = new System.Drawing.Point(101, 51);
            this.textBoxShowStudent.Name = "textBoxShowStudent";
            this.textBoxShowStudent.Size = new System.Drawing.Size(100, 20);
            this.textBoxShowStudent.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Student ID:";
            // 
            // buttonSearchStudent
            // 
            this.buttonSearchStudent.Location = new System.Drawing.Point(207, 49);
            this.buttonSearchStudent.Name = "buttonSearchStudent";
            this.buttonSearchStudent.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchStudent.TabIndex = 6;
            this.buttonSearchStudent.Text = "Search";
            this.buttonSearchStudent.UseVisualStyleBackColor = true;
            this.buttonSearchStudent.Click += new System.EventHandler(this.buttonSearchStudent_Click);
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(102, 113);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.ReadOnly = true;
            this.textBoxFName.Size = new System.Drawing.Size(135, 20);
            this.textBoxFName.TabIndex = 7;
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(102, 151);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.ReadOnly = true;
            this.textBoxLName.Size = new System.Drawing.Size(135, 20);
            this.textBoxLName.TabIndex = 8;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(102, 188);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(135, 20);
            this.textBoxEmail.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "First Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Last Name: ";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(102, 224);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.ReadOnly = true;
            this.textBoxPhone.Size = new System.Drawing.Size(135, 20);
            this.textBoxPhone.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Phone: ";
            // 
            // labelErrorStudent
            // 
            this.labelErrorStudent.AutoSize = true;
            this.labelErrorStudent.ForeColor = System.Drawing.Color.Red;
            this.labelErrorStudent.Location = new System.Drawing.Point(98, 74);
            this.labelErrorStudent.Name = "labelErrorStudent";
            this.labelErrorStudent.Size = new System.Drawing.Size(76, 13);
            this.labelErrorStudent.TabIndex = 15;
            this.labelErrorStudent.Text = "not found error";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(324, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(612, 195);
            this.dataGridView1.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(324, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Your classes:";
            // 
            // comboBoxClasses
            // 
            this.comboBoxClasses.FormattingEnabled = true;
            this.comboBoxClasses.Location = new System.Drawing.Point(323, 285);
            this.comboBoxClasses.Name = "comboBoxClasses";
            this.comboBoxClasses.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClasses.TabIndex = 18;
            // 
            // buttonAddClass
            // 
            this.buttonAddClass.Location = new System.Drawing.Point(451, 285);
            this.buttonAddClass.Name = "buttonAddClass";
            this.buttonAddClass.Size = new System.Drawing.Size(75, 23);
            this.buttonAddClass.TabIndex = 19;
            this.buttonAddClass.Text = "Add Class";
            this.toolTip1.SetToolTip(this.buttonAddClass, "Immediately register for selected class");
            this.buttonAddClass.UseVisualStyleBackColor = true;
            this.buttonAddClass.Click += new System.EventHandler(this.buttonAddClass_Click);
            // 
            // labelErrorClass
            // 
            this.labelErrorClass.AutoSize = true;
            this.labelErrorClass.ForeColor = System.Drawing.Color.Red;
            this.labelErrorClass.Location = new System.Drawing.Point(323, 313);
            this.labelErrorClass.Name = "labelErrorClass";
            this.labelErrorClass.Size = new System.Drawing.Size(103, 13);
            this.labelErrorClass.TabIndex = 20;
            this.labelErrorClass.Text = "already in class error";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(834, 356);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(92, 23);
            this.buttonExit.TabIndex = 21;
            this.buttonExit.Text = "Exit Registration";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Location = new System.Drawing.Point(28, 355);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(75, 23);
            this.buttonClearAll.TabIndex = 22;
            this.buttonClearAll.Text = "Clear All";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 394);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelErrorClass);
            this.Controls.Add(this.buttonAddClass);
            this.Controls.Add(this.comboBoxClasses);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelErrorStudent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.textBoxFName);
            this.Controls.Add(this.buttonSearchStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxShowStudent);
            this.Controls.Add(this.buttonDrop);
            this.Controls.Add(this.buttonEditStudent);
            this.Controls.Add(this.buttonNewStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNewStudent;
        private System.Windows.Forms.Button buttonEditStudent;
        private System.Windows.Forms.Button buttonDrop;
        private System.Windows.Forms.TextBox textBoxShowStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearchStudent;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelErrorStudent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxClasses;
        private System.Windows.Forms.Button buttonAddClass;
        private System.Windows.Forms.Label labelErrorClass;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonClearAll;
    }
}

