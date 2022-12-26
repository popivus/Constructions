
namespace ConstructionObjects
{
    partial class FormObjects
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
            this.label1 = new System.Windows.Forms.Label();
            this.objectsGrid = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.recoverButton = new System.Windows.Forms.Button();
            this.logDeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.objectsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Объекты строительства";
            // 
            // objectsGrid
            // 
            this.objectsGrid.AllowUserToAddRows = false;
            this.objectsGrid.AllowUserToDeleteRows = false;
            this.objectsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.objectsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.objectsGrid.Location = new System.Drawing.Point(12, 135);
            this.objectsGrid.MultiSelect = false;
            this.objectsGrid.Name = "objectsGrid";
            this.objectsGrid.ReadOnly = true;
            this.objectsGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.objectsGrid.RowHeadersVisible = false;
            this.objectsGrid.RowTemplate.Height = 25;
            this.objectsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.objectsGrid.Size = new System.Drawing.Size(1272, 476);
            this.objectsGrid.TabIndex = 1;
            this.objectsGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.objectsGrid_CellDoubleClick);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addButton.Font = new System.Drawing.Font("Dubai", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.Location = new System.Drawing.Point(12, 98);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(110, 31);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Создать";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteButton.Font = new System.Drawing.Font("Dubai", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Location = new System.Drawing.Point(360, 98);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(110, 31);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(711, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Номер объекта:";
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Location = new System.Drawing.Point(868, 94);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(277, 35);
            this.searchBox.TabIndex = 7;
            this.searchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchBox_KeyUp);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.searchButton.Image = global::ConstructionObjects.Properties.Resources.search;
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchButton.Location = new System.Drawing.Point(1151, 94);
            this.searchButton.Name = "searchButton";
            this.searchButton.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.searchButton.Size = new System.Drawing.Size(133, 35);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Поиск";
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.Control;
            this.backButton.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(12, 39);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(127, 31);
            this.backButton.TabIndex = 47;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // recoverButton
            // 
            this.recoverButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.recoverButton.Font = new System.Drawing.Font("Dubai", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recoverButton.Location = new System.Drawing.Point(244, 98);
            this.recoverButton.Name = "recoverButton";
            this.recoverButton.Size = new System.Drawing.Size(110, 31);
            this.recoverButton.TabIndex = 63;
            this.recoverButton.Text = "Восстановить";
            this.recoverButton.UseVisualStyleBackColor = false;
            this.recoverButton.Click += new System.EventHandler(this.recoverButton_Click);
            // 
            // logDeleteButton
            // 
            this.logDeleteButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.logDeleteButton.Font = new System.Drawing.Font("Dubai", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logDeleteButton.Location = new System.Drawing.Point(128, 98);
            this.logDeleteButton.Name = "logDeleteButton";
            this.logDeleteButton.Size = new System.Drawing.Size(110, 31);
            this.logDeleteButton.TabIndex = 62;
            this.logDeleteButton.Text = "В корзину";
            this.logDeleteButton.UseVisualStyleBackColor = false;
            this.logDeleteButton.Click += new System.EventHandler(this.logDeleteButton_Click);
            // 
            // FormObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1296, 623);
            this.Controls.Add(this.recoverButton);
            this.Controls.Add(this.logDeleteButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.objectsGrid);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MinimumSize = new System.Drawing.Size(1168, 662);
            this.Name = "FormObjects";
            this.Text = "Объекты";
            this.Load += new System.EventHandler(this.FormObjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objectsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button backButton;
        public System.Windows.Forms.DataGridView objectsGrid;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button recoverButton;
        private System.Windows.Forms.Button logDeleteButton;
    }
}