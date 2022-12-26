
namespace ConstructionObjects
{
    partial class FormInfoObject
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
            this.label1 = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.startDateBox = new System.Windows.Forms.DateTimePicker();
            this.endDateBox = new System.Windows.Forms.DateTimePicker();
            this.permissionBox = new System.Windows.Forms.TextBox();
            this.sectorBox = new System.Windows.Forms.ComboBox();
            this.floorsBox = new System.Windows.Forms.NumericUpDown();
            this.saveButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numberLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numberBuildingBox = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.areaBox = new System.Windows.Forms.NumericUpDown();
            this.faceBox = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.floorsBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBuildingBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Тип объекта:";
            // 
            // typeBox
            // 
            this.typeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.typeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Items.AddRange(new object[] {
            "Жилой",
            "Не жилой"});
            this.typeBox.Location = new System.Drawing.Point(316, 40);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(334, 28);
            this.typeBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Площадь:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "Этажность:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "Начало строительства:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 27);
            this.label5.TabIndex = 13;
            this.label5.Text = "Окончание строительства:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(293, 27);
            this.label6.TabIndex = 14;
            this.label6.Text = "Разрешение на строительство:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(223, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 27);
            this.label7.TabIndex = 15;
            this.label7.Text = "Участок:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(105, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 27);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ответственное лицо:";
            // 
            // startDateBox
            // 
            this.startDateBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.startDateBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startDateBox.Location = new System.Drawing.Point(316, 166);
            this.startDateBox.Name = "startDateBox";
            this.startDateBox.Size = new System.Drawing.Size(334, 26);
            this.startDateBox.TabIndex = 19;
            // 
            // endDateBox
            // 
            this.endDateBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.endDateBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.endDateBox.Location = new System.Drawing.Point(316, 210);
            this.endDateBox.Name = "endDateBox";
            this.endDateBox.Size = new System.Drawing.Size(334, 26);
            this.endDateBox.TabIndex = 20;
            // 
            // permissionBox
            // 
            this.permissionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.permissionBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.permissionBox.Location = new System.Drawing.Point(316, 254);
            this.permissionBox.Name = "permissionBox";
            this.permissionBox.Size = new System.Drawing.Size(334, 26);
            this.permissionBox.TabIndex = 21;
            // 
            // sectorBox
            // 
            this.sectorBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sectorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sectorBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sectorBox.FormattingEnabled = true;
            this.sectorBox.Items.AddRange(new object[] {
            "ул. Пушкина"});
            this.sectorBox.Location = new System.Drawing.Point(316, 341);
            this.sectorBox.Name = "sectorBox";
            this.sectorBox.Size = new System.Drawing.Size(334, 28);
            this.sectorBox.TabIndex = 22;
            // 
            // floorsBox
            // 
            this.floorsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.floorsBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.floorsBox.Location = new System.Drawing.Point(316, 125);
            this.floorsBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.floorsBox.Name = "floorsBox";
            this.floorsBox.Size = new System.Drawing.Size(334, 26);
            this.floorsBox.TabIndex = 24;
            this.floorsBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.saveButton.Location = new System.Drawing.Point(143, 53);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(127, 31);
            this.saveButton.TabIndex = 25;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(10, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 31);
            this.button2.TabIndex = 26;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(12, 9);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(111, 27);
            this.numberLabel.TabIndex = 27;
            this.numberLabel.Text = "Объект №1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.numberBuildingBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.areaBox);
            this.groupBox1.Controls.Add(this.faceBox);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.startDateBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.typeBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.floorsBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.sectorBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.permissionBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.endDateBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(10, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 433);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Общая информация";
            // 
            // numberBuildingBox
            // 
            this.numberBuildingBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numberBuildingBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberBuildingBox.Location = new System.Drawing.Point(316, 296);
            this.numberBuildingBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberBuildingBox.Name = "numberBuildingBox";
            this.numberBuildingBox.Size = new System.Drawing.Size(334, 26);
            this.numberBuildingBox.TabIndex = 29;
            this.numberBuildingBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(146, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 27);
            this.label9.TabIndex = 28;
            this.label9.Text = "Номер владения:";
            // 
            // areaBox
            // 
            this.areaBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.areaBox.DecimalPlaces = 2;
            this.areaBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.areaBox.Location = new System.Drawing.Point(316, 84);
            this.areaBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.areaBox.Name = "areaBox";
            this.areaBox.Size = new System.Drawing.Size(334, 26);
            this.areaBox.TabIndex = 27;
            this.areaBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // faceBox
            // 
            this.faceBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.faceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.faceBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.faceBox.FormattingEnabled = true;
            this.faceBox.Items.AddRange(new object[] {
            "ул. Пушкина"});
            this.faceBox.Location = new System.Drawing.Point(316, 385);
            this.faceBox.Name = "faceBox";
            this.faceBox.Size = new System.Drawing.Size(334, 28);
            this.faceBox.TabIndex = 26;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button5.Location = new System.Drawing.Point(656, 40);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 28);
            this.button5.TabIndex = 25;
            this.button5.Text = "+";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FormInfoObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(724, 546);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.saveButton);
            this.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MinimumSize = new System.Drawing.Size(740, 585);
            this.Name = "FormInfoObject";
            this.Text = "FormInfoObject";
            this.Load += new System.EventHandler(this.FormInfoObject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.floorsBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBuildingBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker startDateBox;
        private System.Windows.Forms.DateTimePicker endDateBox;
        private System.Windows.Forms.TextBox permissionBox;
        private System.Windows.Forms.ComboBox sectorBox;
        private System.Windows.Forms.NumericUpDown floorsBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.NumericUpDown areaBox;
        private System.Windows.Forms.ComboBox faceBox;
        private System.Windows.Forms.NumericUpDown numberBuildingBox;
        private System.Windows.Forms.Label label9;
    }
}