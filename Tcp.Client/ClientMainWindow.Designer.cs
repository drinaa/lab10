﻿namespace SomeProject.TcpClient
{
    partial class ClientMainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sendMsgBtn = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.labelRes = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.sendFileBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sendMsgBtn
            // 
            this.sendMsgBtn.Location = new System.Drawing.Point(179, 322);
            this.sendMsgBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sendMsgBtn.Name = "sendMsgBtn";
            this.sendMsgBtn.Size = new System.Drawing.Size(165, 29);
            this.sendMsgBtn.TabIndex = 0;
            this.sendMsgBtn.Text = "Send Message";
            this.sendMsgBtn.UseVisualStyleBackColor = true;
            this.sendMsgBtn.Click += new System.EventHandler(this.OnMsgBtnClick);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(42, 15);
            this.textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(776, 240);
            this.textBox.TabIndex = 1;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Location = new System.Drawing.Point(42, 265);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(0, 20);
            this.labelRes.TabIndex = 2;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.OnTimerTick);
            // 
            // sendFileBtn
            // 
            this.sendFileBtn.Location = new System.Drawing.Point(464, 322);
            this.sendFileBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sendFileBtn.Name = "sendFileBtn";
            this.sendFileBtn.Size = new System.Drawing.Size(165, 29);
            this.sendFileBtn.TabIndex = 3;
            this.sendFileBtn.Text = "Send File";
            this.sendFileBtn.UseVisualStyleBackColor = true;
            this.sendFileBtn.Click += new System.EventHandler(this.OnFileBtnClick);
            // 
            // ClientMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 366);
            this.Controls.Add(this.sendFileBtn);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.sendMsgBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientMainWindow";
            this.Text = "Client application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendMsgBtn;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label labelRes;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button sendFileBtn;
    }
}

