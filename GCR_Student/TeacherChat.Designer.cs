
namespace GCR_Student
{
    partial class TeacherChat
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
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Msg = new System.Windows.Forms.TextBox();
            this.txt_Chat = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.cmbx_StudentList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(12, 12);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(99, 60);
            this.btn_Start.TabIndex = 19;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(238, 12);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(99, 60);
            this.btn_Back.TabIndex = 18;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Chat With Student";
            // 
            // txt_Msg
            // 
            this.txt_Msg.Location = new System.Drawing.Point(12, 321);
            this.txt_Msg.Multiline = true;
            this.txt_Msg.Name = "txt_Msg";
            this.txt_Msg.Size = new System.Drawing.Size(222, 60);
            this.txt_Msg.TabIndex = 16;
            this.txt_Msg.Text = "Write A Message";
            // 
            // txt_Chat
            // 
            this.txt_Chat.Location = new System.Drawing.Point(12, 78);
            this.txt_Chat.Multiline = true;
            this.txt_Chat.Name = "txt_Chat";
            this.txt_Chat.Size = new System.Drawing.Size(222, 237);
            this.txt_Chat.TabIndex = 15;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(240, 321);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(99, 60);
            this.btn_send.TabIndex = 14;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // cmbx_StudentList
            // 
            this.cmbx_StudentList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_StudentList.FormattingEnabled = true;
            this.cmbx_StudentList.Location = new System.Drawing.Point(240, 103);
            this.cmbx_StudentList.Name = "cmbx_StudentList";
            this.cmbx_StudentList.Size = new System.Drawing.Size(99, 21);
            this.cmbx_StudentList.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Student list";
            // 
            // TeacherChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 391);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbx_StudentList);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Msg);
            this.Controls.Add(this.txt_Chat);
            this.Controls.Add(this.btn_send);
            this.Name = "TeacherChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherChat";
            this.Load += new System.EventHandler(this.TeacherChat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Msg;
        private System.Windows.Forms.TextBox txt_Chat;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.ComboBox cmbx_StudentList;
        private System.Windows.Forms.Label label2;
    }
}