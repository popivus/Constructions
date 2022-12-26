
namespace ConstructionObjects
{
    partial class FormMenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuAdmin));
            this.backUpButton = new System.Windows.Forms.Button();
            this.usersButton = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.другаяИнформацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бригадыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.договорыОЗаказеМатериаловToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.договорыОЗаказеТехникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.договорыПродажToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контрагентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.материалыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.объектыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.техникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.участкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recoverButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backUpButton
            // 
            this.backUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.backUpButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.backUpButton.Location = new System.Drawing.Point(55, 167);
            this.backUpButton.Name = "backUpButton";
            this.backUpButton.Size = new System.Drawing.Size(306, 31);
            this.backUpButton.TabIndex = 33;
            this.backUpButton.Text = "Резервное копирование БД";
            this.backUpButton.UseVisualStyleBackColor = false;
            this.backUpButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // usersButton
            // 
            this.usersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.usersButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.usersButton.Location = new System.Drawing.Point(55, 105);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(306, 31);
            this.usersButton.TabIndex = 32;
            this.usersButton.Text = "Пользователи";
            this.usersButton.UseVisualStyleBackColor = false;
            this.usersButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Control;
            this.button7.Font = new System.Drawing.Font("Dubai", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(12, 36);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.button7.Size = new System.Drawing.Size(104, 25);
            this.button7.TabIndex = 31;
            this.button7.Text = "Выйти";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.другаяИнформацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(417, 24);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // другаяИнформацияToolStripMenuItem
            // 
            this.другаяИнформацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.бригадыToolStripMenuItem,
            this.договорыОЗаказеМатериаловToolStripMenuItem,
            this.договорыОЗаказеТехникиToolStripMenuItem,
            this.договорыПродажToolStripMenuItem,
            this.должностиToolStripMenuItem,
            this.контрагентыToolStripMenuItem,
            this.материалыToolStripMenuItem,
            this.объектыToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.техникаToolStripMenuItem,
            this.участкиToolStripMenuItem});
            this.другаяИнформацияToolStripMenuItem.Name = "другаяИнформацияToolStripMenuItem";
            this.другаяИнформацияToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.другаяИнформацияToolStripMenuItem.Text = "Все таблицы";
            // 
            // бригадыToolStripMenuItem
            // 
            this.бригадыToolStripMenuItem.Name = "бригадыToolStripMenuItem";
            this.бригадыToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.бригадыToolStripMenuItem.Text = "Бригады";
            this.бригадыToolStripMenuItem.Click += new System.EventHandler(this.бригадыToolStripMenuItem_Click);
            // 
            // договорыОЗаказеМатериаловToolStripMenuItem
            // 
            this.договорыОЗаказеМатериаловToolStripMenuItem.Name = "договорыОЗаказеМатериаловToolStripMenuItem";
            this.договорыОЗаказеМатериаловToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.договорыОЗаказеМатериаловToolStripMenuItem.Text = "Договоры о заказе материалов";
            this.договорыОЗаказеМатериаловToolStripMenuItem.Click += new System.EventHandler(this.договорыОЗаказеМатериаловToolStripMenuItem_Click);
            // 
            // договорыОЗаказеТехникиToolStripMenuItem
            // 
            this.договорыОЗаказеТехникиToolStripMenuItem.Name = "договорыОЗаказеТехникиToolStripMenuItem";
            this.договорыОЗаказеТехникиToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.договорыОЗаказеТехникиToolStripMenuItem.Text = "Договоры о заказе техники";
            this.договорыОЗаказеТехникиToolStripMenuItem.Click += new System.EventHandler(this.договорыОЗаказеТехникиToolStripMenuItem_Click);
            // 
            // договорыПродажToolStripMenuItem
            // 
            this.договорыПродажToolStripMenuItem.Name = "договорыПродажToolStripMenuItem";
            this.договорыПродажToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.договорыПродажToolStripMenuItem.Text = "Договоры продаж";
            this.договорыПродажToolStripMenuItem.Click += new System.EventHandler(this.договорыПродажToolStripMenuItem_Click);
            // 
            // должностиToolStripMenuItem
            // 
            this.должностиToolStripMenuItem.Name = "должностиToolStripMenuItem";
            this.должностиToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.должностиToolStripMenuItem.Text = "Должности";
            this.должностиToolStripMenuItem.Click += new System.EventHandler(this.должностиToolStripMenuItem_Click);
            // 
            // контрагентыToolStripMenuItem
            // 
            this.контрагентыToolStripMenuItem.Name = "контрагентыToolStripMenuItem";
            this.контрагентыToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.контрагентыToolStripMenuItem.Text = "Контрагенты";
            this.контрагентыToolStripMenuItem.Click += new System.EventHandler(this.контрагентыToolStripMenuItem_Click);
            // 
            // материалыToolStripMenuItem
            // 
            this.материалыToolStripMenuItem.Name = "материалыToolStripMenuItem";
            this.материалыToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.материалыToolStripMenuItem.Text = "Материалы";
            this.материалыToolStripMenuItem.Click += new System.EventHandler(this.материалыToolStripMenuItem_Click);
            // 
            // объектыToolStripMenuItem
            // 
            this.объектыToolStripMenuItem.Name = "объектыToolStripMenuItem";
            this.объектыToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.объектыToolStripMenuItem.Text = "Объекты";
            this.объектыToolStripMenuItem.Click += new System.EventHandler(this.объектыToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // техникаToolStripMenuItem
            // 
            this.техникаToolStripMenuItem.Name = "техникаToolStripMenuItem";
            this.техникаToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.техникаToolStripMenuItem.Text = "Техника";
            this.техникаToolStripMenuItem.Click += new System.EventHandler(this.техникаToolStripMenuItem_Click);
            // 
            // участкиToolStripMenuItem
            // 
            this.участкиToolStripMenuItem.Name = "участкиToolStripMenuItem";
            this.участкиToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.участкиToolStripMenuItem.Text = "Участки";
            this.участкиToolStripMenuItem.Click += new System.EventHandler(this.участкиToolStripMenuItem_Click);
            // 
            // recoverButton
            // 
            this.recoverButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.recoverButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.recoverButton.Location = new System.Drawing.Point(55, 204);
            this.recoverButton.Name = "recoverButton";
            this.recoverButton.Size = new System.Drawing.Size(306, 31);
            this.recoverButton.TabIndex = 35;
            this.recoverButton.Text = "Восстановление БД";
            this.recoverButton.UseVisualStyleBackColor = false;
            this.recoverButton.Click += new System.EventHandler(this.recoverButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(417, 312);
            this.Controls.Add(this.recoverButton);
            this.Controls.Add(this.backUpButton);
            this.Controls.Add(this.usersButton);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MinimumSize = new System.Drawing.Size(433, 351);
            this.Name = "FormMenuAdmin";
            this.Text = "Администратор";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMenuDocuments_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backUpButton;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem другаяИнформацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контрагентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem материалыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem техникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бригадыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem договорыОЗаказеМатериаловToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem договорыОЗаказеТехникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem договорыПродажToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem должностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem объектыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem участкиToolStripMenuItem;
        private System.Windows.Forms.Button recoverButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}