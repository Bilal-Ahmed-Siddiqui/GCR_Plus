
namespace GCR_Student
{
    partial class TeacherPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddStudents = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.lbl_Datetime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teaher panel";
            // 
            // btn_AddStudents
            // 
            this.btn_AddStudents.Location = new System.Drawing.Point(664, 17);
            this.btn_AddStudents.Name = "btn_AddStudents";
            this.btn_AddStudents.Size = new System.Drawing.Size(124, 55);
            this.btn_AddStudents.TabIndex = 9;
            this.btn_AddStudents.Text = "Add Students";
            this.btn_AddStudents.UseVisualStyleBackColor = true;
            this.btn_AddStudents.Click += new System.EventHandler(this.btn_AddStudents_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(664, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 55);
            this.button1.TabIndex = 10;
            this.button1.Text = "Make Annoucement";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(182, 165);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(27, 13);
            this.lbl_Title.TabIndex = 11;
            this.lbl_Title.Text = "Title";
            this.lbl_Title.Click += new System.EventHandler(this.lbl_Title_Click);
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Location = new System.Drawing.Point(182, 178);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(60, 13);
            this.lbl_Description.TabIndex = 12;
            this.lbl_Description.Text = "Description";
            this.lbl_Description.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_Datetime
            // 
            this.lbl_Datetime.AutoSize = true;
            this.lbl_Datetime.Location = new System.Drawing.Point(182, 191);
            this.lbl_Datetime.Name = "lbl_Datetime";
            this.lbl_Datetime.Size = new System.Drawing.Size(50, 13);
            this.lbl_Datetime.TabIndex = 13;
            this.lbl_Datetime.Text = "date time";
            this.lbl_Datetime.Click += new System.EventHandler(this.lbl_Datetime_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Title";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Description";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "date time";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(238, 235);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(124, 55);
            this.btn_Next.TabIndex = 17;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.Location = new System.Drawing.Point(49, 235);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(124, 55);
            this.btn_previous.TabIndex = 18;
            this.btn_previous.Text = "Previous";
            this.btn_previous.UseVisualStyleBackColor = true;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // TeacherPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_Datetime);
            this.Controls.Add(this.btn_AddStudents);
            this.Controls.Add(this.label1);
            this.Name = "TeacherPanel";
            this.Text = "TeacherPanel";
            this.Load += new System.EventHandler(this.TeacherPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AddStudents;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Label lbl_Datetime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_previous;
    }
}