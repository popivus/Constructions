
namespace ConstructionObjects
{
    partial class FormBrigadesEdit
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
            this.label9 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.objectsBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.brigadeEmployeesGrid = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.allEmployeesGrid = new System.Windows.Forms.DataGridView();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.removeEmployeeButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brigadeEmployeesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allEmployeesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 27);
            this.label9.TabIndex = 44;
            this.label9.Text = "Бригада";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.Control;
            this.backButton.Location = new System.Drawing.Point(10, 53);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(127, 31);
            this.backButton.TabIndex = 43;
            this.backButton.Text = "Отмена";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.saveButton.Location = new System.Drawing.Point(143, 53);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(127, 31);
            this.saveButton.TabIndex = 42;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.objectsBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 161);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Общая информация";
            // 
            // nameBox
            // 
            this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nameBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameBox.Location = new System.Drawing.Point(170, 53);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(526, 26);
            this.nameBox.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 27);
            this.label2.TabIndex = 43;
            this.label2.Text = "Наименование:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 27);
            this.label3.TabIndex = 44;
            this.label3.Text = "Объект №:";
            // 
            // objectsBox
            // 
            this.objectsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.objectsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.objectsBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.objectsBox.FormattingEnabled = true;
            this.objectsBox.Items.AddRange(new object[] {
            "ООО \"ПИК\""});
            this.objectsBox.Location = new System.Drawing.Point(170, 100);
            this.objectsBox.Name = "objectsBox";
            this.objectsBox.Size = new System.Drawing.Size(526, 28);
            this.objectsBox.TabIndex = 45;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.removeEmployeeButton);
            this.groupBox2.Controls.Add(this.addEmployeeButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.allEmployeesGrid);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.brigadeEmployeesGrid);
            this.groupBox2.Location = new System.Drawing.Point(12, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(763, 230);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Состав бригады";
            // 
            // brigadeEmployeesGrid
            // 
            this.brigadeEmployeesGrid.AllowUserToAddRows = false;
            this.brigadeEmployeesGrid.AllowUserToDeleteRows = false;
            this.brigadeEmployeesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.brigadeEmployeesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.brigadeEmployeesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.brigadeEmployeesGrid.ColumnHeadersVisible = false;
            this.brigadeEmployeesGrid.Location = new System.Drawing.Point(27, 56);
            this.brigadeEmployeesGrid.MultiSelect = false;
            this.brigadeEmployeesGrid.Name = "brigadeEmployeesGrid";
            this.brigadeEmployeesGrid.ReadOnly = true;
            this.brigadeEmployeesGrid.RowHeadersVisible = false;
            this.brigadeEmployeesGrid.RowTemplate.Height = 25;
            this.brigadeEmployeesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.brigadeEmployeesGrid.Size = new System.Drawing.Size(337, 152);
            this.brigadeEmployeesGrid.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(27, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 22);
            this.label11.TabIndex = 4;
            this.label11.Text = "в бригаде:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(405, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "всего:";
            // 
            // allEmployeesGrid
            // 
            this.allEmployeesGrid.AllowUserToAddRows = false;
            this.allEmployeesGrid.AllowUserToDeleteRows = false;
            this.allEmployeesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.allEmployeesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allEmployeesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allEmployeesGrid.ColumnHeadersVisible = false;
            this.allEmployeesGrid.Location = new System.Drawing.Point(405, 56);
            this.allEmployeesGrid.MultiSelect = false;
            this.allEmployeesGrid.Name = "allEmployeesGrid";
            this.allEmployeesGrid.ReadOnly = true;
            this.allEmployeesGrid.RowHeadersVisible = false;
            this.allEmployeesGrid.RowTemplate.Height = 25;
            this.allEmployeesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allEmployeesGrid.Size = new System.Drawing.Size(337, 152);
            this.allEmployeesGrid.TabIndex = 5;
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addEmployeeButton.Location = new System.Drawing.Point(371, 99);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(28, 28);
            this.addEmployeeButton.TabIndex = 7;
            this.addEmployeeButton.Text = "←";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // removeEmployeeButton
            // 
            this.removeEmployeeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.removeEmployeeButton.Location = new System.Drawing.Point(371, 133);
            this.removeEmployeeButton.Name = "removeEmployeeButton";
            this.removeEmployeeButton.Size = new System.Drawing.Size(28, 28);
            this.removeEmployeeButton.TabIndex = 8;
            this.removeEmployeeButton.Text = "→";
            this.removeEmployeeButton.UseVisualStyleBackColor = true;
            this.removeEmployeeButton.Click += new System.EventHandler(this.removeEmployeeButton_Click);
            // 
            // FormBrigadesEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(787, 499);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.saveButton);
            this.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MinimumSize = new System.Drawing.Size(803, 538);
            this.Name = "FormBrigadesEdit";
            this.Text = "FormBrigadesEdit";
            this.Load += new System.EventHandler(this.FormBrigadesEdit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brigadeEmployeesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allEmployeesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox objectsBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView brigadeEmployeesGrid;
        private System.Windows.Forms.Button removeEmployeeButton;
        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView allEmployeesGrid;
        private System.Windows.Forms.Label label11;
    }
}