
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.актВводавэксплуатацию = new System.Windows.Forms.ToolStripMenuItem();
            this.актПриемапередачи = new System.Windows.Forms.ToolStripMenuItem();
            this.служебнаяЗаписка = new System.Windows.Forms.ToolStripMenuItem();
            this.актВывода = new System.Windows.Forms.ToolStripMenuItem();
            this.актСписания = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетОРаботе = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьДокументToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.актВводаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.актПриемапередачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.служебнаяЗапискаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.актВыводаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.актСписанияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетОРаботеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оборудованиеВОтделеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.историяПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.датаВведенияВЭксплуатациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работыПоОборудованиюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Location = new System.Drawing.Point(0, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1096, 449);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Движения оборудования";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(342, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Местоположение";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleDescription = "Местоположение";
            this.pictureBox1.Image = global::Equipment_maintenance.Properties.Resources.icons8_местоположение_банкомата_32;
            this.pictureBox1.Location = new System.Drawing.Point(304, 12);
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
            this.pictureBox2.Location = new System.Drawing.Point(109, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.AccessibleDescription = "Местоположение";
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(461, 12);
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
            this.toolStripMenuItem1,
            this.создатьДокументToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(496, 18);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(127, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.актВводавэксплуатацию,
            this.актПриемапередачи,
            this.служебнаяЗаписка,
            this.актВывода,
            this.актСписания,
            this.отчетОРаботе});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(117, 20);
            this.toolStripMenuItem1.Text = "Создать документ";
            // 
            // актВводавэксплуатацию
            // 
            this.актВводавэксплуатацию.Name = "актВводавэксплуатацию";
            this.актВводавэксплуатацию.Size = new System.Drawing.Size(233, 22);
            this.актВводавэксплуатацию.Text = "Акт ввода в эксплуатацию";
            this.актВводавэксплуатацию.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // актПриемапередачи
            // 
            this.актПриемапередачи.Name = "актПриемапередачи";
            this.актПриемапередачи.Size = new System.Drawing.Size(233, 22);
            this.актПриемапередачи.Text = "Акт приема-передачи";
            this.актПриемапередачи.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // служебнаяЗаписка
            // 
            this.служебнаяЗаписка.Name = "служебнаяЗаписка";
            this.служебнаяЗаписка.Size = new System.Drawing.Size(233, 22);
            this.служебнаяЗаписка.Text = "Служебная записка";
            this.служебнаяЗаписка.Click += new System.EventHandler(this.служебнаяЗаписка_Click);
            // 
            // актВывода
            // 
            this.актВывода.Name = "актВывода";
            this.актВывода.Size = new System.Drawing.Size(233, 22);
            this.актВывода.Text = "Акт технической экспертизы";
            this.актВывода.Click += new System.EventHandler(this.актВывода_Click);
            // 
            // актСписания
            // 
            this.актСписания.Name = "актСписания";
            this.актСписания.Size = new System.Drawing.Size(233, 22);
            this.актСписания.Text = "Акт списания";
            this.актСписания.Click += new System.EventHandler(this.актСписания_Click);
            // 
            // отчетОРаботе
            // 
            this.отчетОРаботе.Name = "отчетОРаботе";
            this.отчетОРаботе.Size = new System.Drawing.Size(233, 22);
            this.отчетОРаботе.Text = "Отчет о работе";
            this.отчетОРаботе.Click += new System.EventHandler(this.отчетОРаботе_Click);
            // 
            // создатьДокументToolStripMenuItem
            // 
            this.создатьДокументToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.создатьДокументToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.актВводаToolStripMenuItem,
            this.актПриемапередачиToolStripMenuItem,
            this.служебнаяЗапискаToolStripMenuItem,
            this.актВыводаToolStripMenuItem,
            this.актСписанияToolStripMenuItem,
            this.отчетОРаботеToolStripMenuItem});
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
            // отчетОРаботеToolStripMenuItem
            // 
            this.отчетОРаботеToolStripMenuItem.Name = "отчетОРаботеToolStripMenuItem";
            this.отчетОРаботеToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.отчетОРаботеToolStripMenuItem.Text = "Отчет о работе";
            this.отчетОРаботеToolStripMenuItem.Click += new System.EventHandler(this.отчетОРаботеToolStripMenuItem_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 12);
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
            this.pictureBox5.Location = new System.Drawing.Point(1052, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "Местоположение";
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.AccessibleDescription = "Местоположение";
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(626, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "Местоположение";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запросыToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(661, 19);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(68, 24);
            this.menuStrip2.TabIndex = 11;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.запросыToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.запросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оборудованиеВОтделеToolStripMenuItem,
            this.историяПользователяToolStripMenuItem,
            this.датаВведенияВЭксплуатациюToolStripMenuItem,
            this.работыПоОборудованиюToolStripMenuItem});
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.запросыToolStripMenuItem.Text = "Отчеты";
            // 
            // оборудованиеВОтделеToolStripMenuItem
            // 
            this.оборудованиеВОтделеToolStripMenuItem.Name = "оборудованиеВОтделеToolStripMenuItem";
            this.оборудованиеВОтделеToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.оборудованиеВОтделеToolStripMenuItem.Text = "Оборудование в отделе";
            this.оборудованиеВОтделеToolStripMenuItem.Click += new System.EventHandler(this.оборудованиеВОтделеToolStripMenuItem_Click);
            // 
            // историяПользователяToolStripMenuItem
            // 
            this.историяПользователяToolStripMenuItem.Name = "историяПользователяToolStripMenuItem";
            this.историяПользователяToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.историяПользователяToolStripMenuItem.Text = "История пользователя";
            this.историяПользователяToolStripMenuItem.Click += new System.EventHandler(this.историяПользователяToolStripMenuItem_Click);
            // 
            // датаВведенияВЭксплуатациюToolStripMenuItem
            // 
            this.датаВведенияВЭксплуатациюToolStripMenuItem.Name = "датаВведенияВЭксплуатациюToolStripMenuItem";
            this.датаВведенияВЭксплуатациюToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.датаВведенияВЭксплуатациюToolStripMenuItem.Text = "Дата введения в эксплуатацию";
            this.датаВведенияВЭксплуатациюToolStripMenuItem.Click += new System.EventHandler(this.датаВведенияВЭксплуатациюToolStripMenuItem_Click);
            // 
            // работыПоОборудованиюToolStripMenuItem
            // 
            this.работыПоОборудованиюToolStripMenuItem.Name = "работыПоОборудованиюToolStripMenuItem";
            this.работыПоОборудованиюToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.работыПоОборудованиюToolStripMenuItem.Text = "Работы по оборудованию";
            this.работыПоОборудованиюToolStripMenuItem.Click += new System.EventHandler(this.работыПоОборудованиюToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1096, 499);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ведение оборудования";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem создатьДокументToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem актВводаToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ToolStripMenuItem актПриемапередачиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem служебнаяЗапискаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem актВыводаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem актСписанияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетОРаботеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem актВводавэксплуатацию;
        private System.Windows.Forms.ToolStripMenuItem актПриемапередачи;
        private System.Windows.Forms.ToolStripMenuItem служебнаяЗаписка;
        private System.Windows.Forms.ToolStripMenuItem актВывода;
        private System.Windows.Forms.ToolStripMenuItem актСписания;
        private System.Windows.Forms.ToolStripMenuItem отчетОРаботе;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оборудованиеВОтделеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem историяПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem датаВведенияВЭксплуатациюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работыПоОборудованиюToolStripMenuItem;
    }
}

