
namespace DeliveryAWP
{
    partial class AddNewPckg
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
            this.Sender = new System.Windows.Forms.TextBox();
            this.Reciver = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DateAndTimeMTB = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Sender
            // 
            this.Sender.Location = new System.Drawing.Point(12, 40);
            this.Sender.Name = "Sender";
            this.Sender.Size = new System.Drawing.Size(455, 22);
            this.Sender.TabIndex = 0;
            // 
            // Reciver
            // 
            this.Reciver.Location = new System.Drawing.Point(13, 83);
            this.Reciver.Name = "Reciver";
            this.Reciver.Size = new System.Drawing.Size(455, 22);
            this.Reciver.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Отправитель(Фио и адрес)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Получатель(Фио и адрес)";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(16, 176);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(95, 37);
            this.Add.TabIndex = 6;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(373, 176);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(95, 37);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Дата и время поступления";
            // 
            // DateAndTimeMTB
            // 
            this.DateAndTimeMTB.Location = new System.Drawing.Point(13, 139);
            this.DateAndTimeMTB.Mask = "00/00/0000 90:00";
            this.DateAndTimeMTB.Name = "DateAndTimeMTB";
            this.DateAndTimeMTB.Size = new System.Drawing.Size(162, 22);
            this.DateAndTimeMTB.TabIndex = 9;
            this.DateAndTimeMTB.ValidatingType = typeof(System.DateTime);
            // 
            // AddNewPckg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 227);
            this.Controls.Add(this.DateAndTimeMTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Reciver);
            this.Controls.Add(this.Sender);
            this.MinimumSize = new System.Drawing.Size(501, 226);
            this.Name = "AddNewPckg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление заказа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Sender;
        private System.Windows.Forms.TextBox Reciver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox DateAndTimeMTB;
    }
}