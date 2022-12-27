
namespace GCR_Student
{
    partial class StudentChat
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
            this.txt_Msg = new System.Windows.Forms.TextBox();
            this.txt_Chat = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Msg
            // 
            this.txt_Msg.BackColor = System.Drawing.Color.MintCream;
            this.txt_Msg.Location = new System.Drawing.Point(10, 320);
            this.txt_Msg.Multiline = true;
            this.txt_Msg.Name = "txt_Msg";
            this.txt_Msg.Size = new System.Drawing.Size(222, 60);
            this.txt_Msg.TabIndex = 10;
            this.txt_Msg.Text = "Write A Message";
            // 
            // txt_Chat
            // 
            this.txt_Chat.BackColor = System.Drawing.Color.MintCream;
            this.txt_Chat.Location = new System.Drawing.Point(10, 77);
            this.txt_Chat.Multiline = true;
            this.txt_Chat.Name = "txt_Chat";
            this.txt_Chat.Size = new System.Drawing.Size(327, 237);
            this.txt_Chat.TabIndex = 7;
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.Color.Honeydew;
            this.btn_send.Location = new System.Drawing.Point(238, 320);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(99, 60);
            this.btn_send.TabIndex = 6;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Honeydew;
            this.btn_Back.Location = new System.Drawing.Point(238, 12);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(99, 60);
            this.btn_Back.TabIndex = 12;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.Honeydew;
            this.btn_Start.Location = new System.Drawing.Point(10, 11);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(99, 60);
            this.btn_Start.TabIndex = 13;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Chat Box";
            // 
            // StudentChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(349, 387);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.txt_Msg);
            this.Controls.Add(this.txt_Chat);
            this.Controls.Add(this.btn_send);
            this.Name = "StudentChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentChat";
            this.Load += new System.EventHandler(this.StudentChat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Msg;
        private System.Windows.Forms.TextBox txt_Chat;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label label1;
    }
}