
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
            // TeacherPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_AddStudents);
            this.Controls.Add(this.label1);
            this.Name = "TeacherPanel";
            this.Text = "TeacherPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AddStudents;
        private System.Windows.Forms.Button button1;
    }
}