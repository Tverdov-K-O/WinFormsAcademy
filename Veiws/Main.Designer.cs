
namespace WinFormsAcademy.Veiws
{
    partial class Main
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
            this.ListGroup = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inGroupName = new System.Windows.Forms.TextBox();
            this.tbnCreateGroup_Click = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ListStudents = new System.Windows.Forms.ListBox();
            this.inStudentName = new System.Windows.Forms.TextBox();
            this.btnCreateStudent_Click = new System.Windows.Forms.Button();
            this.groupBoxStudent = new System.Windows.Forms.GroupBox();
            this.btnDellStudent = new System.Windows.Forms.Button();
            this.ComboGroupNames = new System.Windows.Forms.ComboBox();
            this.btnSaveStudent = new System.Windows.Forms.Button();
            this.ChangeStudentName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListGroup
            // 
            this.ListGroup.FormattingEnabled = true;
            this.ListGroup.ItemHeight = 15;
            this.ListGroup.Location = new System.Drawing.Point(13, 66);
            this.ListGroup.Name = "ListGroup";
            this.ListGroup.Size = new System.Drawing.Size(152, 229);
            this.ListGroup.TabIndex = 0;
            this.ListGroup.SelectedIndexChanged += new System.EventHandler(this.ListGroup_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Группы";
            // 
            // inGroupName
            // 
            this.inGroupName.Location = new System.Drawing.Point(13, 317);
            this.inGroupName.Name = "inGroupName";
            this.inGroupName.Size = new System.Drawing.Size(153, 23);
            this.inGroupName.TabIndex = 2;
            // 
            // tbnCreateGroup_Click
            // 
            this.tbnCreateGroup_Click.Location = new System.Drawing.Point(46, 346);
            this.tbnCreateGroup_Click.Name = "tbnCreateGroup_Click";
            this.tbnCreateGroup_Click.Size = new System.Drawing.Size(75, 23);
            this.tbnCreateGroup_Click.TabIndex = 3;
            this.tbnCreateGroup_Click.Text = "Create";
            this.tbnCreateGroup_Click.UseVisualStyleBackColor = true;
            this.tbnCreateGroup_Click.Click += new System.EventHandler(this.tbnCreateGroup_Click_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Выделите группу: ";
            // 
            // ListStudents
            // 
            this.ListStudents.FormattingEnabled = true;
            this.ListStudents.ItemHeight = 15;
            this.ListStudents.Location = new System.Drawing.Point(222, 66);
            this.ListStudents.Name = "ListStudents";
            this.ListStudents.Size = new System.Drawing.Size(152, 229);
            this.ListStudents.TabIndex = 6;
            this.ListStudents.SelectedIndexChanged += new System.EventHandler(this.ListStudents_SelectedIndexChanged);
            // 
            // inStudentName
            // 
            this.inStudentName.Location = new System.Drawing.Point(221, 317);
            this.inStudentName.Name = "inStudentName";
            this.inStudentName.Size = new System.Drawing.Size(153, 23);
            this.inStudentName.TabIndex = 7;
            // 
            // btnCreateStudent_Click
            // 
            this.btnCreateStudent_Click.Location = new System.Drawing.Point(260, 346);
            this.btnCreateStudent_Click.Name = "btnCreateStudent_Click";
            this.btnCreateStudent_Click.Size = new System.Drawing.Size(75, 23);
            this.btnCreateStudent_Click.TabIndex = 8;
            this.btnCreateStudent_Click.Text = "Create";
            this.btnCreateStudent_Click.UseVisualStyleBackColor = true;
            this.btnCreateStudent_Click.Click += new System.EventHandler(this.btnCreateStudent_Click_Click);
            // 
            // groupBoxStudent
            // 
            this.groupBoxStudent.Controls.Add(this.btnDellStudent);
            this.groupBoxStudent.Controls.Add(this.ComboGroupNames);
            this.groupBoxStudent.Controls.Add(this.btnSaveStudent);
            this.groupBoxStudent.Controls.Add(this.ChangeStudentName);
            this.groupBoxStudent.Controls.Add(this.label4);
            this.groupBoxStudent.Location = new System.Drawing.Point(427, 66);
            this.groupBoxStudent.Name = "groupBoxStudent";
            this.groupBoxStudent.Size = new System.Drawing.Size(348, 229);
            this.groupBoxStudent.TabIndex = 9;
            this.groupBoxStudent.TabStop = false;
            this.groupBoxStudent.Text = "Выберите Студента";
            // 
            // btnDellStudent
            // 
            this.btnDellStudent.Location = new System.Drawing.Point(100, 126);
            this.btnDellStudent.Name = "btnDellStudent";
            this.btnDellStudent.Size = new System.Drawing.Size(66, 23);
            this.btnDellStudent.TabIndex = 4;
            this.btnDellStudent.Text = "Удалить";
            this.btnDellStudent.UseVisualStyleBackColor = true;
            this.btnDellStudent.Click += new System.EventHandler(this.btnDellStudent_Click);
            // 
            // ComboGroupNames
            // 
            this.ComboGroupNames.FormattingEnabled = true;
            this.ComboGroupNames.Location = new System.Drawing.Point(21, 86);
            this.ComboGroupNames.Name = "ComboGroupNames";
            this.ComboGroupNames.Size = new System.Drawing.Size(145, 23);
            this.ComboGroupNames.TabIndex = 3;
            // 
            // btnSaveStudent
            // 
            this.btnSaveStudent.Location = new System.Drawing.Point(21, 126);
            this.btnSaveStudent.Name = "btnSaveStudent";
            this.btnSaveStudent.Size = new System.Drawing.Size(64, 24);
            this.btnSaveStudent.TabIndex = 2;
            this.btnSaveStudent.Text = "Save";
            this.btnSaveStudent.UseVisualStyleBackColor = true;
            this.btnSaveStudent.Click += new System.EventHandler(this.btnSaveStudent_Click);
            // 
            // ChangeStudentName
            // 
            this.ChangeStudentName.Location = new System.Drawing.Point(66, 41);
            this.ChangeStudentName.Name = "ChangeStudentName";
            this.ChangeStudentName.Size = new System.Drawing.Size(100, 23);
            this.ChangeStudentName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxStudent);
            this.Controls.Add(this.btnCreateStudent_Click);
            this.Controls.Add(this.inStudentName);
            this.Controls.Add(this.ListStudents);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbnCreateGroup_Click);
            this.Controls.Add(this.inGroupName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListGroup);
            this.Name = "Main";
            this.Text = "Main";
            this.groupBoxStudent.ResumeLayout(false);
            this.groupBoxStudent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inGroupName;
        private System.Windows.Forms.Button tbnCreateGroup_Click;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ListStudents;
        private System.Windows.Forms.TextBox inStudentName;
        private System.Windows.Forms.Button btnCreateStudent_Click;
        private System.Windows.Forms.GroupBox groupBoxStudent;
        private System.Windows.Forms.ComboBox ComboGroupNames;
        private System.Windows.Forms.Button btnSaveStudent;
        private System.Windows.Forms.TextBox ChangeStudentName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDellStudent;
    }
}