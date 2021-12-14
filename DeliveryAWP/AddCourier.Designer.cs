
namespace DeliveryAWP
{
    partial class AddCourier
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
            this.CourierType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CourierNameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.VolumeTB = new System.Windows.Forms.MaskedTextBox();
            this.TimeMTB = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SalaryMTB = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SaveCourier = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.TransportTB = new System.Windows.Forms.TextBox();
            this.Transport = new System.Windows.Forms.Label();
            this.Fuel = new System.Windows.Forms.Label();
            this.FuelTB = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // CourierType
            // 
            this.CourierType.FormattingEnabled = true;
            this.CourierType.Items.AddRange(new object[] {
            "Пеший курьер",
            "Вело-курьер",
            "Авто-курьер"});
            this.CourierType.Location = new System.Drawing.Point(109, 31);
            this.CourierType.Name = "CourierType";
            this.CourierType.Size = new System.Drawing.Size(146, 24);
            this.CourierType.TabIndex = 0;
            this.CourierType.SelectedIndexChanged += new System.EventHandler(this.CourierType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тип курьера";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "ФИО: ";
            // 
            // CourierNameTB
            // 
            this.CourierNameTB.Location = new System.Drawing.Point(69, 66);
            this.CourierNameTB.Name = "CourierNameTB";
            this.CourierNameTB.Size = new System.Drawing.Size(357, 22);
            this.CourierNameTB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Вместимость";
            // 
            // VolumeTB
            // 
            this.VolumeTB.Location = new System.Drawing.Point(377, 31);
            this.VolumeTB.Mask = "00";
            this.VolumeTB.Name = "VolumeTB";
            this.VolumeTB.Size = new System.Drawing.Size(50, 22);
            this.VolumeTB.TabIndex = 1;
            // 
            // TimeMTB
            // 
            this.TimeMTB.Location = new System.Drawing.Point(192, 95);
            this.TimeMTB.Mask = "00";
            this.TimeMTB.Name = "TimeMTB";
            this.TimeMTB.Size = new System.Drawing.Size(36, 22);
            this.TimeMTB.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Среднее время доставки";
            // 
            // SalaryMTB
            // 
            this.SalaryMTB.Location = new System.Drawing.Point(392, 95);
            this.SalaryMTB.Mask = "000";
            this.SalaryMTB.Name = "SalaryMTB";
            this.SalaryMTB.Size = new System.Drawing.Size(34, 22);
            this.SalaryMTB.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Зарплата за 1 заказ: ";
            // 
            // SaveCourier
            // 
            this.SaveCourier.Location = new System.Drawing.Point(12, 211);
            this.SaveCourier.Name = "SaveCourier";
            this.SaveCourier.Size = new System.Drawing.Size(138, 33);
            this.SaveCourier.TabIndex = 7;
            this.SaveCourier.Text = "Сохранить";
            this.SaveCourier.UseVisualStyleBackColor = true;
            this.SaveCourier.Click += new System.EventHandler(this.SaveCourier_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(288, 209);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(138, 33);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // TransportTB
            // 
            this.TransportTB.Location = new System.Drawing.Point(16, 153);
            this.TransportTB.Name = "TransportTB";
            this.TransportTB.Size = new System.Drawing.Size(134, 22);
            this.TransportTB.TabIndex = 5;
            // 
            // Transport
            // 
            this.Transport.AutoSize = true;
            this.Transport.Location = new System.Drawing.Point(13, 133);
            this.Transport.Name = "Transport";
            this.Transport.Size = new System.Drawing.Size(0, 17);
            this.Transport.TabIndex = 12;
            // 
            // Fuel
            // 
            this.Fuel.AutoSize = true;
            this.Fuel.Location = new System.Drawing.Point(189, 133);
            this.Fuel.Name = "Fuel";
            this.Fuel.Size = new System.Drawing.Size(112, 17);
            this.Fuel.TabIndex = 14;
            this.Fuel.Text = "Расход топлива";
            // 
            // FuelTB
            // 
            this.FuelTB.Location = new System.Drawing.Point(192, 153);
            this.FuelTB.Mask = "00.00";
            this.FuelTB.Name = "FuelTB";
            this.FuelTB.Size = new System.Drawing.Size(100, 22);
            this.FuelTB.TabIndex = 6;
            // 
            // AddCourier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 254);
            this.Controls.Add(this.FuelTB);
            this.Controls.Add(this.Fuel);
            this.Controls.Add(this.TransportTB);
            this.Controls.Add(this.Transport);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.SaveCourier);
            this.Controls.Add(this.SalaryMTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TimeMTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VolumeTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CourierNameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CourierType);
            this.Name = "AddCourier";
            this.Text = "AddCourier";
            this.Load += new System.EventHandler(this.AddCourier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CourierType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CourierNameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox VolumeTB;
        private System.Windows.Forms.MaskedTextBox TimeMTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox SalaryMTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SaveCourier;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox TransportTB;
        private System.Windows.Forms.Label Transport;
        private System.Windows.Forms.Label Fuel;
        private System.Windows.Forms.MaskedTextBox FuelTB;
    }
}