
namespace ConstructionObjects
{
    partial class FormDocTechnics
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.sumBox = new System.Windows.Forms.NumericUpDown();
            this.technicsBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.counterpartyBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sumBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.numberLabel);
            this.groupBox1.Controls.Add(this.sumBox);
            this.groupBox1.Controls.Add(this.technicsBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.counterpartyBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(10, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 215);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Общая информация";
            // 
            // numberLabel
            // 
            this.numberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(215, 37);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(21, 27);
            this.numberLabel.TabIndex = 26;
            this.numberLabel.Text = "0";
            // 
            // sumBox
            // 
            this.sumBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sumBox.DecimalPlaces = 2;
            this.sumBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sumBox.Location = new System.Drawing.Point(215, 75);
            this.sumBox.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.sumBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sumBox.Name = "sumBox";
            this.sumBox.Size = new System.Drawing.Size(315, 26);
            this.sumBox.TabIndex = 25;
            this.sumBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // technicsBox
            // 
            this.technicsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.technicsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.technicsBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.technicsBox.FormattingEnabled = true;
            this.technicsBox.Items.AddRange(new object[] {
            "ул. Пушкина, 1"});
            this.technicsBox.Location = new System.Drawing.Point(215, 115);
            this.technicsBox.Name = "technicsBox";
            this.technicsBox.Size = new System.Drawing.Size(315, 28);
            this.technicsBox.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Номер договора:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "Поставщик:";
            // 
            // counterpartyBox
            // 
            this.counterpartyBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.counterpartyBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.counterpartyBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.counterpartyBox.FormattingEnabled = true;
            this.counterpartyBox.Items.AddRange(new object[] {
            "ООО \"ПИК\""});
            this.counterpartyBox.Location = new System.Drawing.Point(215, 158);
            this.counterpartyBox.Name = "counterpartyBox";
            this.counterpartyBox.Size = new System.Drawing.Size(315, 28);
            this.counterpartyBox.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 27);
            this.label5.TabIndex = 13;
            this.label5.Text = "Сумма:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 27);
            this.label6.TabIndex = 14;
            this.label6.Text = "Техника:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(246, 27);
            this.label9.TabIndex = 35;
            this.label9.Text = "Договор о заказе техники";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.Control;
            this.backButton.Location = new System.Drawing.Point(10, 53);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(127, 31);
            this.backButton.TabIndex = 34;
            this.backButton.Text = "Отмена";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.saveButton.Location = new System.Drawing.Point(143, 53);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(127, 31);
            this.saveButton.TabIndex = 33;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // FormDocTechnics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(576, 329);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.saveButton);
            this.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MinimumSize = new System.Drawing.Size(592, 368);
            this.Name = "FormDocTechnics";
            this.Text = "FormDocO";
            this.Load += new System.EventHandler(this.FormDocTechnics_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sumBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox counterpartyBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox technicsBox;
        private System.Windows.Forms.NumericUpDown sumBox;
        private System.Windows.Forms.Label numberLabel;
    }
}