
namespace ConstructionObjects
{
    partial class FormInfoObjectStorage
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.removeTechnicsButton = new System.Windows.Forms.Button();
            this.addTechnicsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.technicsAllGrid = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.technicsObjectGrid = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.countResBox = new System.Windows.Forms.NumericUpDown();
            this.removeResButton = new System.Windows.Forms.Button();
            this.addResButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.resAllGrid = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.resObjectGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numberBuildingLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.areaLabel = new System.Windows.Forms.Label();
            this.floorsLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.permissionLabel = new System.Windows.Forms.Label();
            this.sectorLabel = new System.Windows.Forms.Label();
            this.faceLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.technicsAllGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicsObjectGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countResBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resAllGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resObjectGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.removeTechnicsButton);
            this.groupBox3.Controls.Add(this.addTechnicsButton);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.technicsAllGrid);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.technicsObjectGrid);
            this.groupBox3.Location = new System.Drawing.Point(994, 102);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 425);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Техника";
            // 
            // removeTechnicsButton
            // 
            this.removeTechnicsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.removeTechnicsButton.Location = new System.Drawing.Point(194, 218);
            this.removeTechnicsButton.Name = "removeTechnicsButton";
            this.removeTechnicsButton.Size = new System.Drawing.Size(30, 30);
            this.removeTechnicsButton.TabIndex = 9;
            this.removeTechnicsButton.Text = "↓";
            this.removeTechnicsButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.removeTechnicsButton.UseVisualStyleBackColor = true;
            this.removeTechnicsButton.Click += new System.EventHandler(this.removeTechnicsButton_Click);
            // 
            // addTechnicsButton
            // 
            this.addTechnicsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addTechnicsButton.Location = new System.Drawing.Point(161, 218);
            this.addTechnicsButton.Name = "addTechnicsButton";
            this.addTechnicsButton.Size = new System.Drawing.Size(30, 30);
            this.addTechnicsButton.TabIndex = 8;
            this.addTechnicsButton.Text = "↑";
            this.addTechnicsButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addTechnicsButton.UseVisualStyleBackColor = true;
            this.addTechnicsButton.Click += new System.EventHandler(this.addTechnicsButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "всего:";
            // 
            // technicsAllGrid
            // 
            this.technicsAllGrid.AllowUserToAddRows = false;
            this.technicsAllGrid.AllowUserToDeleteRows = false;
            this.technicsAllGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.technicsAllGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.technicsAllGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.technicsAllGrid.ColumnHeadersVisible = false;
            this.technicsAllGrid.Location = new System.Drawing.Point(19, 251);
            this.technicsAllGrid.MultiSelect = false;
            this.technicsAllGrid.Name = "technicsAllGrid";
            this.technicsAllGrid.ReadOnly = true;
            this.technicsAllGrid.RowHeadersVisible = false;
            this.technicsAllGrid.RowTemplate.Height = 25;
            this.technicsAllGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.technicsAllGrid.Size = new System.Drawing.Size(205, 156);
            this.technicsAllGrid.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(19, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 22);
            this.label12.TabIndex = 5;
            this.label12.Text = "на объекте:";
            // 
            // technicsObjectGrid
            // 
            this.technicsObjectGrid.AllowUserToAddRows = false;
            this.technicsObjectGrid.AllowUserToDeleteRows = false;
            this.technicsObjectGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.technicsObjectGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.technicsObjectGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.technicsObjectGrid.ColumnHeadersVisible = false;
            this.technicsObjectGrid.Location = new System.Drawing.Point(19, 56);
            this.technicsObjectGrid.MultiSelect = false;
            this.technicsObjectGrid.Name = "technicsObjectGrid";
            this.technicsObjectGrid.ReadOnly = true;
            this.technicsObjectGrid.RowHeadersVisible = false;
            this.technicsObjectGrid.RowTemplate.Height = 25;
            this.technicsObjectGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.technicsObjectGrid.Size = new System.Drawing.Size(205, 156);
            this.technicsObjectGrid.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.countResBox);
            this.groupBox2.Controls.Add(this.removeResButton);
            this.groupBox2.Controls.Add(this.addResButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.resAllGrid);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.resObjectGrid);
            this.groupBox2.Location = new System.Drawing.Point(739, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 425);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ресурсы";
            // 
            // countResBox
            // 
            this.countResBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.countResBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countResBox.Location = new System.Drawing.Point(171, 220);
            this.countResBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.countResBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countResBox.Name = "countResBox";
            this.countResBox.Size = new System.Drawing.Size(58, 26);
            this.countResBox.TabIndex = 30;
            this.countResBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // removeResButton
            // 
            this.removeResButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.removeResButton.Location = new System.Drawing.Point(135, 218);
            this.removeResButton.Name = "removeResButton";
            this.removeResButton.Size = new System.Drawing.Size(30, 30);
            this.removeResButton.TabIndex = 11;
            this.removeResButton.Text = "↓";
            this.removeResButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.removeResButton.UseVisualStyleBackColor = true;
            this.removeResButton.Click += new System.EventHandler(this.removeResButton_Click);
            // 
            // addResButton
            // 
            this.addResButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addResButton.Location = new System.Drawing.Point(102, 218);
            this.addResButton.Name = "addResButton";
            this.addResButton.Size = new System.Drawing.Size(30, 30);
            this.addResButton.TabIndex = 10;
            this.addResButton.Text = "↑";
            this.addResButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addResButton.UseVisualStyleBackColor = true;
            this.addResButton.Click += new System.EventHandler(this.addResButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "всего:";
            // 
            // resAllGrid
            // 
            this.resAllGrid.AllowUserToAddRows = false;
            this.resAllGrid.AllowUserToDeleteRows = false;
            this.resAllGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resAllGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resAllGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resAllGrid.ColumnHeadersVisible = false;
            this.resAllGrid.Location = new System.Drawing.Point(24, 251);
            this.resAllGrid.MultiSelect = false;
            this.resAllGrid.Name = "resAllGrid";
            this.resAllGrid.ReadOnly = true;
            this.resAllGrid.RowHeadersVisible = false;
            this.resAllGrid.RowTemplate.Height = 25;
            this.resAllGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resAllGrid.Size = new System.Drawing.Size(205, 156);
            this.resAllGrid.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(24, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 22);
            this.label11.TabIndex = 3;
            this.label11.Text = "на объекте:";
            // 
            // resObjectGrid
            // 
            this.resObjectGrid.AllowUserToAddRows = false;
            this.resObjectGrid.AllowUserToDeleteRows = false;
            this.resObjectGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resObjectGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resObjectGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resObjectGrid.ColumnHeadersVisible = false;
            this.resObjectGrid.Location = new System.Drawing.Point(24, 56);
            this.resObjectGrid.MultiSelect = false;
            this.resObjectGrid.Name = "resObjectGrid";
            this.resObjectGrid.ReadOnly = true;
            this.resObjectGrid.RowHeadersVisible = false;
            this.resObjectGrid.RowTemplate.Height = 25;
            this.resObjectGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resObjectGrid.Size = new System.Drawing.Size(205, 156);
            this.resObjectGrid.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.numberBuildingLabel);
            this.groupBox1.Controls.Add(this.typeLabel);
            this.groupBox1.Controls.Add(this.areaLabel);
            this.groupBox1.Controls.Add(this.floorsLabel);
            this.groupBox1.Controls.Add(this.startDateLabel);
            this.groupBox1.Controls.Add(this.endDateLabel);
            this.groupBox1.Controls.Add(this.permissionLabel);
            this.groupBox1.Controls.Add(this.sectorLabel);
            this.groupBox1.Controls.Add(this.faceLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 425);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Общая информация";
            // 
            // numberBuildingLabel
            // 
            this.numberBuildingLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numberBuildingLabel.AutoSize = true;
            this.numberBuildingLabel.Location = new System.Drawing.Point(200, 295);
            this.numberBuildingLabel.Name = "numberBuildingLabel";
            this.numberBuildingLabel.Size = new System.Drawing.Size(177, 27);
            this.numberBuildingLabel.TabIndex = 17;
            this.numberBuildingLabel.Text = "Номер владения: 1";
            // 
            // typeLabel
            // 
            this.typeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(237, 41);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(189, 27);
            this.typeLabel.TabIndex = 8;
            this.typeLabel.Text = "Тип объекта: Жилой";
            // 
            // areaLabel
            // 
            this.areaLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.areaLabel.AutoSize = true;
            this.areaLabel.Location = new System.Drawing.Point(268, 84);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(139, 27);
            this.areaLabel.TabIndex = 10;
            this.areaLabel.Text = "Площадь: 503м";
            // 
            // floorsLabel
            // 
            this.floorsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.floorsLabel.AutoSize = true;
            this.floorsLabel.Location = new System.Drawing.Point(248, 125);
            this.floorsLabel.Name = "floorsLabel";
            this.floorsLabel.Size = new System.Drawing.Size(128, 27);
            this.floorsLabel.TabIndex = 11;
            this.floorsLabel.Text = "Этажность: 6";
            // 
            // startDateLabel
            // 
            this.startDateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(144, 167);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(301, 27);
            this.startDateLabel.TabIndex = 12;
            this.startDateLabel.Text = "Начало строительства: 12.01.2020";
            // 
            // endDateLabel
            // 
            this.endDateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(109, 211);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(336, 27);
            this.endDateLabel.TabIndex = 13;
            this.endDateLabel.Text = "Окончание строительства: 25.03.2022";
            // 
            // permissionLabel
            // 
            this.permissionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.permissionLabel.AutoSize = true;
            this.permissionLabel.Location = new System.Drawing.Point(70, 255);
            this.permissionLabel.Name = "permissionLabel";
            this.permissionLabel.Size = new System.Drawing.Size(388, 27);
            this.permissionLabel.TabIndex = 14;
            this.permissionLabel.Text = "Разрешение на строительство: M-43453262";
            // 
            // sectorLabel
            // 
            this.sectorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sectorLabel.AutoSize = true;
            this.sectorLabel.Location = new System.Drawing.Point(276, 335);
            this.sectorLabel.Name = "sectorLabel";
            this.sectorLabel.Size = new System.Drawing.Size(194, 27);
            this.sectorLabel.TabIndex = 15;
            this.sectorLabel.Text = "Участок: ул. Пушкина";
            // 
            // faceLabel
            // 
            this.faceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.faceLabel.AutoSize = true;
            this.faceLabel.Location = new System.Drawing.Point(158, 378);
            this.faceLabel.Name = "faceLabel";
            this.faceLabel.Size = new System.Drawing.Size(292, 27);
            this.faceLabel.TabIndex = 16;
            this.faceLabel.Text = "Ответственное лицо: Лило А.М.";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(12, 9);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(111, 27);
            this.numberLabel.TabIndex = 36;
            this.numberLabel.Text = "Объект №1";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(12, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 31);
            this.button2.TabIndex = 37;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormInfoObjectStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1249, 539);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FormInfoObjectStorage";
            this.Text = "FormInfoObjectBrigadir";
            this.Load += new System.EventHandler(this.FormInfoObjectBrigadir_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.technicsAllGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicsObjectGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countResBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resAllGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resObjectGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView technicsObjectGrid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView resObjectGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.Label floorsLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label permissionLabel;
        private System.Windows.Forms.Label sectorLabel;
        private System.Windows.Forms.Label faceLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label numberBuildingLabel;
        private System.Windows.Forms.Button removeTechnicsButton;
        private System.Windows.Forms.Button addTechnicsButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView technicsAllGrid;
        private System.Windows.Forms.Button removeResButton;
        private System.Windows.Forms.Button addResButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView resAllGrid;
        private System.Windows.Forms.NumericUpDown countResBox;
    }
}