
namespace DeliveryAWP
{
    partial class Form1
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
            this.NewPackageButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.FILE = new System.Windows.Forms.ToolStripSplitButton();
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.CouriersBttn = new System.Windows.Forms.ToolStripStatusLabel();
            this.PackagesBTTN = new System.Windows.Forms.ToolStripStatusLabel();
            this.PCKGSGB = new System.Windows.Forms.GroupBox();
            this.Date = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.AddToCourier = new System.Windows.Forms.Button();
            this.PackagesDGW = new System.Windows.Forms.DataGridView();
            this.Sender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reciver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CouriersGB = new System.Windows.Forms.GroupBox();
            this.SendCourier = new System.Windows.Forms.Button();
            this.DeleteCourier = new System.Windows.Forms.Button();
            this.AddCourier = new System.Windows.Forms.Button();
            this.COURIERSDGW = new System.Windows.Forms.DataGridView();
            this.CourierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FreeVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PckgCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourierStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.FreeCouriers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenCouriers = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenPackages = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.PCKGSGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PackagesDGW)).BeginInit();
            this.CouriersGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.COURIERSDGW)).BeginInit();
            this.SuspendLayout();
            // 
            // NewPackageButton
            // 
            this.NewPackageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewPackageButton.Location = new System.Drawing.Point(6, 363);
            this.NewPackageButton.Name = "NewPackageButton";
            this.NewPackageButton.Size = new System.Drawing.Size(131, 31);
            this.NewPackageButton.TabIndex = 0;
            this.NewPackageButton.Text = "Новая посылка";
            this.NewPackageButton.UseVisualStyleBackColor = true;
            this.NewPackageButton.Click += new System.EventHandler(this.NewPackageButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FILE,
            this.CouriersBttn,
            this.PackagesBTTN});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(934, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FILE
            // 
            this.FILE.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FILE.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open,
            this.Save});
            this.FILE.Name = "FILE";
            this.FILE.Size = new System.Drawing.Size(64, 24);
            this.FILE.Text = "Файл";
            // 
            // Open
            // 
            this.Open.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenCouriers,
            this.OpenPackages});
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(224, 26);
            this.Open.Text = "Открыть";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(224, 26);
            this.Save.Text = "Сохранить";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // CouriersBttn
            // 
            this.CouriersBttn.Name = "CouriersBttn";
            this.CouriersBttn.Size = new System.Drawing.Size(70, 20);
            this.CouriersBttn.Text = "Курьеры";
            this.CouriersBttn.Click += new System.EventHandler(this.CouriersBttn_Click);
            // 
            // PackagesBTTN
            // 
            this.PackagesBTTN.Name = "PackagesBTTN";
            this.PackagesBTTN.Size = new System.Drawing.Size(57, 20);
            this.PackagesBTTN.Text = "Заявки";
            this.PackagesBTTN.Click += new System.EventHandler(this.PackagesBTTN_Click);
            // 
            // PCKGSGB
            // 
            this.PCKGSGB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PCKGSGB.Controls.Add(this.label1);
            this.PCKGSGB.Controls.Add(this.FreeCouriers);
            this.PCKGSGB.Controls.Add(this.Date);
            this.PCKGSGB.Controls.Add(this.Delete);
            this.PCKGSGB.Controls.Add(this.AddToCourier);
            this.PCKGSGB.Controls.Add(this.PackagesDGW);
            this.PCKGSGB.Controls.Add(this.NewPackageButton);
            this.PCKGSGB.Location = new System.Drawing.Point(0, 29);
            this.PCKGSGB.Name = "PCKGSGB";
            this.PCKGSGB.Size = new System.Drawing.Size(934, 400);
            this.PCKGSGB.TabIndex = 2;
            this.PCKGSGB.TabStop = false;
            this.PCKGSGB.Text = "Заявки";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(428, 34);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(0, 17);
            this.Date.TabIndex = 4;
            // 
            // Delete
            // 
            this.Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete.Location = new System.Drawing.Point(808, 363);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(120, 31);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // AddToCourier
            // 
            this.AddToCourier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddToCourier.Location = new System.Drawing.Point(149, 363);
            this.AddToCourier.Name = "AddToCourier";
            this.AddToCourier.Size = new System.Drawing.Size(146, 31);
            this.AddToCourier.TabIndex = 2;
            this.AddToCourier.Text = "Передать курьеру";
            this.AddToCourier.UseVisualStyleBackColor = true;
            this.AddToCourier.Click += new System.EventHandler(this.AddToCourier_Click);
            // 
            // PackagesDGW
            // 
            this.PackagesDGW.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PackagesDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PackagesDGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sender,
            this.Reciver,
            this.DateAndTime,
            this.Status});
            this.PackagesDGW.Location = new System.Drawing.Point(6, 58);
            this.PackagesDGW.Name = "PackagesDGW";
            this.PackagesDGW.ReadOnly = true;
            this.PackagesDGW.RowHeadersWidth = 51;
            this.PackagesDGW.RowTemplate.Height = 24;
            this.PackagesDGW.Size = new System.Drawing.Size(916, 291);
            this.PackagesDGW.TabIndex = 1;
            // 
            // Sender
            // 
            this.Sender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sender.HeaderText = "Отправитель";
            this.Sender.MinimumWidth = 6;
            this.Sender.Name = "Sender";
            this.Sender.ReadOnly = true;
            this.Sender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Reciver
            // 
            this.Reciver.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Reciver.HeaderText = "Получатель";
            this.Reciver.MinimumWidth = 6;
            this.Reciver.Name = "Reciver";
            this.Reciver.ReadOnly = true;
            this.Reciver.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DateAndTime
            // 
            this.DateAndTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateAndTime.HeaderText = "Создано";
            this.DateAndTime.MinimumWidth = 6;
            this.DateAndTime.Name = "DateAndTime";
            this.DateAndTime.ReadOnly = true;
            this.DateAndTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.HeaderText = "Статус";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CouriersGB
            // 
            this.CouriersGB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CouriersGB.Controls.Add(this.SendCourier);
            this.CouriersGB.Controls.Add(this.DeleteCourier);
            this.CouriersGB.Controls.Add(this.AddCourier);
            this.CouriersGB.Controls.Add(this.COURIERSDGW);
            this.CouriersGB.Location = new System.Drawing.Point(0, 29);
            this.CouriersGB.Name = "CouriersGB";
            this.CouriersGB.Size = new System.Drawing.Size(926, 400);
            this.CouriersGB.TabIndex = 3;
            this.CouriersGB.TabStop = false;
            this.CouriersGB.Text = "Курьеры";
            // 
            // SendCourier
            // 
            this.SendCourier.Location = new System.Drawing.Point(149, 25);
            this.SendCourier.Name = "SendCourier";
            this.SendCourier.Size = new System.Drawing.Size(125, 27);
            this.SendCourier.TabIndex = 3;
            this.SendCourier.Text = "Отправить";
            this.SendCourier.UseVisualStyleBackColor = true;
            this.SendCourier.Click += new System.EventHandler(this.SendCourier_Click);
            // 
            // DeleteCourier
            // 
            this.DeleteCourier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteCourier.Location = new System.Drawing.Point(795, 23);
            this.DeleteCourier.Name = "DeleteCourier";
            this.DeleteCourier.Size = new System.Drawing.Size(125, 27);
            this.DeleteCourier.TabIndex = 2;
            this.DeleteCourier.Text = "Удалить";
            this.DeleteCourier.UseVisualStyleBackColor = true;
            this.DeleteCourier.Click += new System.EventHandler(this.DeleteCourier_Click);
            // 
            // AddCourier
            // 
            this.AddCourier.Location = new System.Drawing.Point(12, 25);
            this.AddCourier.Name = "AddCourier";
            this.AddCourier.Size = new System.Drawing.Size(125, 27);
            this.AddCourier.TabIndex = 1;
            this.AddCourier.Text = "Добавить";
            this.AddCourier.UseVisualStyleBackColor = true;
            this.AddCourier.Click += new System.EventHandler(this.AddCourier_Click);
            // 
            // COURIERSDGW
            // 
            this.COURIERSDGW.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.COURIERSDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.COURIERSDGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourierName,
            this.MaxVolume,
            this.FreeVolume,
            this.TIME,
            this.PckgCount,
            this.Salary,
            this.CourierStatus});
            this.COURIERSDGW.Location = new System.Drawing.Point(12, 58);
            this.COURIERSDGW.Name = "COURIERSDGW";
            this.COURIERSDGW.RowHeadersWidth = 51;
            this.COURIERSDGW.RowTemplate.Height = 24;
            this.COURIERSDGW.Size = new System.Drawing.Size(908, 330);
            this.COURIERSDGW.TabIndex = 0;
            // 
            // CourierName
            // 
            this.CourierName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CourierName.HeaderText = "ФИО";
            this.CourierName.MinimumWidth = 6;
            this.CourierName.Name = "CourierName";
            this.CourierName.ReadOnly = true;
            this.CourierName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MaxVolume
            // 
            this.MaxVolume.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaxVolume.HeaderText = "Макс. нагрузка";
            this.MaxVolume.MinimumWidth = 6;
            this.MaxVolume.Name = "MaxVolume";
            this.MaxVolume.ReadOnly = true;
            this.MaxVolume.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FreeVolume
            // 
            this.FreeVolume.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FreeVolume.HeaderText = "Свободное место";
            this.FreeVolume.MinimumWidth = 6;
            this.FreeVolume.Name = "FreeVolume";
            this.FreeVolume.ReadOnly = true;
            this.FreeVolume.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TIME
            // 
            this.TIME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TIME.HeaderText = "Среднее время доставки";
            this.TIME.MinimumWidth = 6;
            this.TIME.Name = "TIME";
            this.TIME.ReadOnly = true;
            this.TIME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PckgCount
            // 
            this.PckgCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PckgCount.HeaderText = "Доставил заказов";
            this.PckgCount.MinimumWidth = 6;
            this.PckgCount.Name = "PckgCount";
            this.PckgCount.ReadOnly = true;
            this.PckgCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Salary
            // 
            this.Salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Salary.HeaderText = "Зар. плата";
            this.Salary.MinimumWidth = 6;
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            this.Salary.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CourierStatus
            // 
            this.CourierStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CourierStatus.HeaderText = "Статус";
            this.CourierStatus.MinimumWidth = 6;
            this.CourierStatus.Name = "CourierStatus";
            this.CourierStatus.ReadOnly = true;
            this.CourierStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FreeCouriers
            // 
            this.FreeCouriers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FreeCouriers.FormattingEnabled = true;
            this.FreeCouriers.Location = new System.Drawing.Point(68, 31);
            this.FreeCouriers.Name = "FreeCouriers";
            this.FreeCouriers.Size = new System.Drawing.Size(854, 24);
            this.FreeCouriers.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Курьер:";
            // 
            // OpenCouriers
            // 
            this.OpenCouriers.Name = "OpenCouriers";
            this.OpenCouriers.Size = new System.Drawing.Size(224, 26);
            this.OpenCouriers.Text = "Курьеры";
            this.OpenCouriers.Click += new System.EventHandler(this.OpenCouriers_Click);
            // 
            // OpenPackages
            // 
            this.OpenPackages.Name = "OpenPackages";
            this.OpenPackages.Size = new System.Drawing.Size(224, 26);
            this.OpenPackages.Text = "Заявки";
            this.OpenPackages.Click += new System.EventHandler(this.OpenPackages_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 429);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.PCKGSGB);
            this.Controls.Add(this.CouriersGB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.PCKGSGB.ResumeLayout(false);
            this.PCKGSGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PackagesDGW)).EndInit();
            this.CouriersGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.COURIERSDGW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewPackageButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel CouriersBttn;
        private System.Windows.Forms.ToolStripStatusLabel PackagesBTTN;
        private System.Windows.Forms.GroupBox PCKGSGB;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button AddToCourier;
        private System.Windows.Forms.DataGridView PackagesDGW;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.ToolStripSplitButton FILE;
        private System.Windows.Forms.ToolStripMenuItem Open;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reciver;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.GroupBox CouriersGB;
        private System.Windows.Forms.Button DeleteCourier;
        private System.Windows.Forms.Button AddCourier;
        private System.Windows.Forms.DataGridView COURIERSDGW;
        private System.Windows.Forms.Button SendCourier;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn FreeVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PckgCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourierStatus;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FreeCouriers;
        private System.Windows.Forms.ToolStripMenuItem OpenCouriers;
        private System.Windows.Forms.ToolStripMenuItem OpenPackages;
    }
}

