namespace КП
{
    partial class Staff
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.фильтрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьТолькоАдминистраторовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьТолькоПользователейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сброситьФильтрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(206, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(746, 368);
            this.dataGridView1.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "№";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Фамилия";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Имя";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Отчество ";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Пароль";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Должность";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Группа";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Статус";
            this.Column8.Name = "Column8";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 328);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 49);
            this.button4.TabIndex = 16;
            this.button4.Text = "Назад";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 221);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(175, 49);
            this.button5.TabIndex = 15;
            this.button5.Text = "Удалить";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 166);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(175, 49);
            this.button6.TabIndex = 14;
            this.button6.Text = "Редактировать";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 111);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(175, 49);
            this.button7.TabIndex = 13;
            this.button7.Text = "Добавить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фильтрToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(956, 33);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // фильтрToolStripMenuItem
            // 
            this.фильтрToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьТолькоАдминистраторовToolStripMenuItem,
            this.показатьТолькоПользователейToolStripMenuItem,
            this.сброситьФильтрToolStripMenuItem});
            this.фильтрToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.фильтрToolStripMenuItem.Name = "фильтрToolStripMenuItem";
            this.фильтрToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.фильтрToolStripMenuItem.Text = "Фильтр";
            // 
            // показатьТолькоАдминистраторовToolStripMenuItem
            // 
            this.показатьТолькоАдминистраторовToolStripMenuItem.Name = "показатьТолькоАдминистраторовToolStripMenuItem";
            this.показатьТолькоАдминистраторовToolStripMenuItem.Size = new System.Drawing.Size(388, 30);
            this.показатьТолькоАдминистраторовToolStripMenuItem.Text = "Показать только администраторов";
            this.показатьТолькоАдминистраторовToolStripMenuItem.Click += new System.EventHandler(this.показатьТолькоАдминистраторовToolStripMenuItem_Click);
            // 
            // показатьТолькоПользователейToolStripMenuItem
            // 
            this.показатьТолькоПользователейToolStripMenuItem.Name = "показатьТолькоПользователейToolStripMenuItem";
            this.показатьТолькоПользователейToolStripMenuItem.Size = new System.Drawing.Size(388, 30);
            this.показатьТолькоПользователейToolStripMenuItem.Text = "Показать только пользователей";
            this.показатьТолькоПользователейToolStripMenuItem.Click += new System.EventHandler(this.показатьТолькоПользователейToolStripMenuItem_Click);
            // 
            // сброситьФильтрToolStripMenuItem
            // 
            this.сброситьФильтрToolStripMenuItem.Name = "сброситьФильтрToolStripMenuItem";
            this.сброситьФильтрToolStripMenuItem.Size = new System.Drawing.Size(388, 30);
            this.сброситьФильтрToolStripMenuItem.Text = "Сбросить фильтр";
            this.сброситьФильтрToolStripMenuItem.Click += new System.EventHandler(this.сброситьФильтрToolStripMenuItem_Click);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 403);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Staff";
            this.Text = "Персонал";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem фильтрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьТолькоАдминистраторовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьТолькоПользователейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сброситьФильтрToolStripMenuItem;
    }
}