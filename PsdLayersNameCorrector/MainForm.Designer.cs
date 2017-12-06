namespace PsdLayersNameCorrector
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.b_select_dir = new System.Windows.Forms.Button();
            this.tb_logs = new System.Windows.Forms.TextBox();
            this.l_dir_name = new System.Windows.Forms.Label();
            this.pb_load = new System.Windows.Forms.ProgressBar();
            this.fbd_open_dir = new System.Windows.Forms.FolderBrowserDialog();
            this.b_start = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // b_select_dir
            // 
            this.b_select_dir.Location = new System.Drawing.Point(12, 12);
            this.b_select_dir.Name = "b_select_dir";
            this.b_select_dir.Size = new System.Drawing.Size(116, 28);
            this.b_select_dir.TabIndex = 0;
            this.b_select_dir.Text = "Выбрать папку";
            this.b_select_dir.UseVisualStyleBackColor = true;
            this.b_select_dir.Click += new System.EventHandler(this.b_select_dir_Click);
            // 
            // tb_logs
            // 
            this.tb_logs.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_logs.Location = new System.Drawing.Point(12, 111);
            this.tb_logs.Multiline = true;
            this.tb_logs.Name = "tb_logs";
            this.tb_logs.ReadOnly = true;
            this.tb_logs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_logs.Size = new System.Drawing.Size(438, 267);
            this.tb_logs.TabIndex = 1;
            // 
            // l_dir_name
            // 
            this.l_dir_name.AutoSize = true;
            this.l_dir_name.Location = new System.Drawing.Point(134, 20);
            this.l_dir_name.Name = "l_dir_name";
            this.l_dir_name.Size = new System.Drawing.Size(101, 13);
            this.l_dir_name.TabIndex = 2;
            this.l_dir_name.Text = "Папкен не выбран";
            // 
            // pb_load
            // 
            this.pb_load.Location = new System.Drawing.Point(12, 80);
            this.pb_load.Name = "pb_load";
            this.pb_load.Size = new System.Drawing.Size(438, 25);
            this.pb_load.TabIndex = 3;
            // 
            // fbd_open_dir
            // 
            this.fbd_open_dir.ShowNewFolderButton = false;
            // 
            // b_start
            // 
            this.b_start.Location = new System.Drawing.Point(12, 46);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(116, 28);
            this.b_start.TabIndex = 4;
            this.b_start.Text = "Начать";
            this.b_start.UseVisualStyleBackColor = true;
            this.b_start.Click += new System.EventHandler(this.b_start_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(456, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(422, 366);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(891, 390);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.b_start);
            this.Controls.Add(this.pb_load);
            this.Controls.Add(this.l_dir_name);
            this.Controls.Add(this.tb_logs);
            this.Controls.Add(this.b_select_dir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PLANACO - PSD Layers Name Corrector";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_select_dir;
        private System.Windows.Forms.TextBox tb_logs;
        private System.Windows.Forms.Label l_dir_name;
        private System.Windows.Forms.ProgressBar pb_load;
        private System.Windows.Forms.FolderBrowserDialog fbd_open_dir;
        private System.Windows.Forms.Button b_start;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

