
namespace Equipment_maintenance
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.EquipmentDepartmentButton = new System.Windows.Forms.ToolStripButton();
            this.HistoryEquipmentUserButton = new System.Windows.Forms.ToolStripButton();
            this.DateOperationButton = new System.Windows.Forms.ToolStripButton();
            this.WorksOnEquipmentButton = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.создатьДокументToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.актВводаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.актПриемапередачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.служебнаяЗапискаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.актВыводаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.актСписанияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Location = new System.Drawing.Point(0, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(970, 433);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EquipmentDepartmentButton,
            this.HistoryEquipmentUserButton,
            this.DateOperationButton,
            this.WorksOnEquipmentButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(970, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // EquipmentDepartmentButton
            // 
            this.EquipmentDepartmentButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.EquipmentDepartmentButton.Image = ((System.Drawing.Image)(resources.GetObject("EquipmentDepartmentButton.Image")));
            this.EquipmentDepartmentButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EquipmentDepartmentButton.Name = "EquipmentDepartmentButton";
            this.EquipmentDepartmentButton.Size = new System.Drawing.Size(141, 22);
            this.EquipmentDepartmentButton.Text = "Оборудование в отделе";
            this.EquipmentDepartmentButton.ToolTipText = " ";
            this.EquipmentDepartmentButton.Click += new System.EventHandler(this.EquipmentDepartmentButton_Click);
            // 
            // HistoryEquipmentUserButton
            // 
            this.HistoryEquipmentUserButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.HistoryEquipmentUserButton.Image = ((System.Drawing.Image)(resources.GetObject("HistoryEquipmentUserButton.Image")));
            this.HistoryEquipmentUserButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HistoryEquipmentUserButton.Name = "HistoryEquipmentUserButton";
            this.HistoryEquipmentUserButton.Size = new System.Drawing.Size(136, 22);
            this.HistoryEquipmentUserButton.Text = "История пользователя";
            // 
            // DateOperationButton
            // 
            this.DateOperationButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DateOperationButton.Image = ((System.Drawing.Image)(resources.GetObject("DateOperationButton.Image")));
            this.DateOperationButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DateOperationButton.Name = "DateOperationButton";
            this.DateOperationButton.Size = new System.Drawing.Size(180, 22);
            this.DateOperationButton.Text = "Дата введения в эксплуатацию";
            // 
            // WorksOnEquipmentButton
            // 
            this.WorksOnEquipmentButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.WorksOnEquipmentButton.Image = ((System.Drawing.Image)(resources.GetObject("WorksOnEquipmentButton.Image")));
            this.WorksOnEquipmentButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.WorksOnEquipmentButton.Name = "WorksOnEquipmentButton";
            this.WorksOnEquipmentButton.Size = new System.Drawing.Size(155, 22);
            this.WorksOnEquipmentButton.Text = "Работы по оборудованию";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Движения оборудования";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(342, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Местоположение";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleDescription = "Местоположение";
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Image = global::Equipment_maintenance.Properties.Resources.icons8_местоположение_банкомата_32;
            this.pictureBox1.Location = new System.Drawing.Point(304, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Местоположение";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Equipment_maintenance.Properties.Resources.icons8_перемещение_запаса_30;
            this.pictureBox2.Location = new System.Drawing.Point(109, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.AccessibleDescription = "Местоположение";
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(461, 28);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "Местоположение";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьДокументToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(496, 34);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(127, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // создатьДокументToolStripMenuItem
            // 
            this.создатьДокументToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.создатьДокументToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.актВводаToolStripMenuItem,
            this.актПриемапередачиToolStripMenuItem,
            this.служебнаяЗапискаToolStripMenuItem,
            this.актВыводаToolStripMenuItem,
            this.актСписанияToolStripMenuItem});
            this.создатьДокументToolStripMenuItem.Name = "создатьДокументToolStripMenuItem";
            this.создатьДокументToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.создатьДокументToolStripMenuItem.Text = "Создать документ";
            // 
            // актВводаToolStripMenuItem
            // 
            this.актВводаToolStripMenuItem.Name = "актВводаToolStripMenuItem";
            this.актВводаToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.актВводаToolStripMenuItem.Text = "Акт ввода в эксплуатацию";
            this.актВводаToolStripMenuItem.Click += new System.EventHandler(this.актВводавэксплуатациюToolStripMenuItem_Click);
            // 
            // актПриемапередачиToolStripMenuItem
            // 
            this.актПриемапередачиToolStripMenuItem.Name = "актПриемапередачиToolStripMenuItem";
            this.актПриемапередачиToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.актПриемапередачиToolStripMenuItem.Text = "Акт приема-передачи";
            this.актПриемапередачиToolStripMenuItem.Click += new System.EventHandler(this.актПриемапередачиToolStripMenuItem_Click);
            // 
            // служебнаяЗапискаToolStripMenuItem
            // 
            this.служебнаяЗапискаToolStripMenuItem.Name = "служебнаяЗапискаToolStripMenuItem";
            this.служебнаяЗапискаToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.служебнаяЗапискаToolStripMenuItem.Text = "Служебная записка";
            this.служебнаяЗапискаToolStripMenuItem.Click += new System.EventHandler(this.служебнаяЗапискаToolStripMenuItem_Click);
            // 
            // актВыводаToolStripMenuItem
            // 
            this.актВыводаToolStripMenuItem.Name = "актВыводаToolStripMenuItem";
            this.актВыводаToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.актВыводаToolStripMenuItem.Text = "Акт технической экспертизы";
            this.актВыводаToolStripMenuItem.Click += new System.EventHandler(this.актВыводаToolStripMenuItem_Click);
            // 
            // актСписанияToolStripMenuItem
            // 
            this.актСписанияToolStripMenuItem.Name = "актСписанияToolStripMenuItem";
            this.актСписанияToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.актСписанияToolStripMenuItem.Text = "Акт списания";
            this.актСписанияToolStripMenuItem.Click += new System.EventHandler(this.актСписанияToolStripMenuItem_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 28);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.AccessibleDescription = "Местоположение";
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(926, 6);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "Местоположение";
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 499);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ведение оборудования";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton EquipmentDepartmentButton;
        private System.Windows.Forms.ToolStripButton HistoryEquipmentUserButton;
        private System.Windows.Forms.ToolStripButton DateOperationButton;
        private System.Windows.Forms.ToolStripButton WorksOnEquipmentButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem создатьДокументToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem актВводаToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ToolStripMenuItem актПриемапередачиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem служебнаяЗапискаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem актВыводаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem актСписанияToolStripMenuItem;
    }
}

