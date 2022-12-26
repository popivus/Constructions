
namespace ConstructionObjects
{
    partial class FormMenuObjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuObjects));
            this.brigadesButton = new System.Windows.Forms.Button();
            this.objectsButton = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.другаяИнформацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контрагентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sectorsButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // brigadesButton
            // 
            this.brigadesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.brigadesButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.brigadesButton.Location = new System.Drawing.Point(58, 160);
            this.brigadesButton.Name = "brigadesButton";
            this.brigadesButton.Size = new System.Drawing.Size(306, 31);
            this.brigadesButton.TabIndex = 37;
            this.brigadesButton.Text = "Бригады";
            this.brigadesButton.UseVisualStyleBackColor = false;
            this.brigadesButton.Click += new System.EventHandler(this.brigadesButton_Click);
            // 
            // objectsButton
            // 
            this.objectsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.objectsButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.objectsButton.Location = new System.Drawing.Point(58, 111);
            this.objectsButton.Name = "objectsButton";
            this.objectsButton.Size = new System.Drawing.Size(306, 31);
            this.objectsButton.TabIndex = 36;
            this.objectsButton.Text = "Объекты";
            this.objectsButton.UseVisualStyleBackColor = false;
            this.objectsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Control;
            this.button7.Font = new System.Drawing.Font("Dubai", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(12, 37);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.button7.Size = new System.Drawing.Size(104, 25);
            this.button7.TabIndex = 35;
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
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // другаяИнформацияToolStripMenuItem
            // 
            this.другаяИнформацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.контрагентыToolStripMenuItem});
            this.другаяИнформацияToolStripMenuItem.Name = "другаяИнформацияToolStripMenuItem";
            this.другаяИнформацияToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.другаяИнформацияToolStripMenuItem.Text = "Другая информация";
            // 
            // контрагентыToolStripMenuItem
            // 
            this.контрагентыToolStripMenuItem.Name = "контрагентыToolStripMenuItem";
            this.контрагентыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.контрагентыToolStripMenuItem.Text = "Контрагенты";
            this.контрагентыToolStripMenuItem.Click += new System.EventHandler(this.контрагентыToolStripMenuItem_Click);
            // 
            // sectorsButton
            // 
            this.sectorsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sectorsButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.sectorsButton.Location = new System.Drawing.Point(58, 210);
            this.sectorsButton.Name = "sectorsButton";
            this.sectorsButton.Size = new System.Drawing.Size(306, 31);
            this.sectorsButton.TabIndex = 39;
            this.sectorsButton.Text = "Участки";
            this.sectorsButton.UseVisualStyleBackColor = false;
            this.sectorsButton.Click += new System.EventHandler(this.sectorsButton_Click);
            // 
            // FormMenuObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(417, 312);
            this.Controls.Add(this.sectorsButton);
            this.Controls.Add(this.brigadesButton);
            this.Controls.Add(this.objectsButton);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MinimumSize = new System.Drawing.Size(433, 351);
            this.Name = "FormMenuObjects";
            this.Text = "Ведение объектов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMenuObjects_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button brigadesButton;
        private System.Windows.Forms.Button objectsButton;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem другаяИнформацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контрагентыToolStripMenuItem;
        private System.Windows.Forms.Button sectorsButton;
    }
}