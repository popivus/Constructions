
namespace ConstructionObjects
{
    partial class FormBrigades
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
            this.components = new System.ComponentModel.Container();
            this.backButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.brigadesGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.logDeleteButton = new System.Windows.Forms.Button();
            this.recoverButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.brigadesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.Control;
            this.backButton.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(14, 41);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(127, 31);
            this.backButton.TabIndex = 54;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.searchButton.Image = global::ConstructionObjects.Properties.Resources.search;
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchButton.Location = new System.Drawing.Point(682, 135);
            this.searchButton.Name = "searchButton";
            this.searchButton.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.searchButton.Size = new System.Drawing.Size(133, 35);
            this.searchButton.TabIndex = 53;
            this.searchButton.Text = "Поиск";
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Location = new System.Drawing.Point(468, 135);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(208, 35);
            this.searchBox.TabIndex = 52;
            this.searchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchBox_KeyUp);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 27);
            this.label2.TabIndex = 51;
            this.label2.Text = "Наименование:";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteButton.Font = new System.Drawing.Font("Dubai", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Location = new System.Drawing.Point(130, 139);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(110, 31);
            this.deleteButton.TabIndex = 50;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addButton.Font = new System.Drawing.Font("Dubai", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.Location = new System.Drawing.Point(14, 102);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(110, 31);
            this.addButton.TabIndex = 49;
            this.addButton.Text = "Создать";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // brigadesGrid
            // 
            this.brigadesGrid.AllowUserToAddRows = false;
            this.brigadesGrid.AllowUserToDeleteRows = false;
            this.brigadesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.brigadesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.brigadesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.brigadesGrid.Location = new System.Drawing.Point(14, 176);
            this.brigadesGrid.MultiSelect = false;
            this.brigadesGrid.Name = "brigadesGrid";
            this.brigadesGrid.ReadOnly = true;
            this.brigadesGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.brigadesGrid.RowHeadersVisible = false;
            this.brigadesGrid.RowTemplate.Height = 25;
            this.brigadesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.brigadesGrid.Size = new System.Drawing.Size(801, 466);
            this.brigadesGrid.TabIndex = 48;
            this.brigadesGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.brigadesGrid_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 27);
            this.label1.TabIndex = 47;
            this.label1.Text = "Бригады";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // logDeleteButton
            // 
            this.logDeleteButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.logDeleteButton.Font = new System.Drawing.Font("Dubai", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logDeleteButton.Location = new System.Drawing.Point(130, 102);
            this.logDeleteButton.Name = "logDeleteButton";
            this.logDeleteButton.Size = new System.Drawing.Size(110, 31);
            this.logDeleteButton.TabIndex = 55;
            this.logDeleteButton.Text = "В корзину";
            this.logDeleteButton.UseVisualStyleBackColor = false;
            this.logDeleteButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // recoverButton
            // 
            this.recoverButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.recoverButton.Font = new System.Drawing.Font("Dubai", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recoverButton.Location = new System.Drawing.Point(14, 139);
            this.recoverButton.Name = "recoverButton";
            this.recoverButton.Size = new System.Drawing.Size(110, 31);
            this.recoverButton.TabIndex = 56;
            this.recoverButton.Text = "Восстановить";
            this.recoverButton.UseVisualStyleBackColor = false;
            this.recoverButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormBrigades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(825, 652);
            this.Controls.Add(this.recoverButton);
            this.Controls.Add(this.logDeleteButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.brigadesGrid);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MinimumSize = new System.Drawing.Size(841, 691);
            this.Name = "FormBrigades";
            this.Text = "Бригады";
            this.Load += new System.EventHandler(this.FormBrigades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brigadesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        public System.Windows.Forms.DataGridView brigadesGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button logDeleteButton;
        private System.Windows.Forms.Button recoverButton;
    }
}