
namespace ConstructionObjects
{
    partial class FormEmployeesEdit
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
            this.backButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.positionBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.firedCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.middlenameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.birthdayDateBox = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.INNBox = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SNILSBox = new System.Windows.Forms.MaskedTextBox();
            this.numberPassportBox = new System.Windows.Forms.MaskedTextBox();
            this.seriaBox = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.photoButton = new System.Windows.Forms.Button();
            this.scanPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scanPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.Control;
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(127, 31);
            this.backButton.TabIndex = 42;
            this.backButton.Text = "Отмена";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.saveButton.Location = new System.Drawing.Point(145, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(127, 31);
            this.saveButton.TabIndex = 41;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.positionBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.firedCheckBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.middlenameBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.surnameBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 249);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Общая информация";
            // 
            // positionBox
            // 
            this.positionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.positionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.positionBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.positionBox.FormattingEnabled = true;
            this.positionBox.Location = new System.Drawing.Point(215, 163);
            this.positionBox.Name = "positionBox";
            this.positionBox.Size = new System.Drawing.Size(255, 28);
            this.positionBox.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 27);
            this.label5.TabIndex = 31;
            this.label5.Text = "Уволен:";
            // 
            // firedCheckBox
            // 
            this.firedCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.firedCheckBox.AutoSize = true;
            this.firedCheckBox.Location = new System.Drawing.Point(215, 212);
            this.firedCheckBox.Name = "firedCheckBox";
            this.firedCheckBox.Size = new System.Drawing.Size(15, 14);
            this.firedCheckBox.TabIndex = 30;
            this.firedCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 27);
            this.label4.TabIndex = 28;
            this.label4.Text = "Должность:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 27);
            this.label3.TabIndex = 26;
            this.label3.Text = "Отчество:";
            // 
            // middlenameBox
            // 
            this.middlenameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.middlenameBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.middlenameBox.Location = new System.Drawing.Point(215, 119);
            this.middlenameBox.Name = "middlenameBox";
            this.middlenameBox.Size = new System.Drawing.Size(255, 26);
            this.middlenameBox.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 27);
            this.label1.TabIndex = 24;
            this.label1.Text = "Имя:";
            // 
            // nameBox
            // 
            this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nameBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameBox.Location = new System.Drawing.Point(215, 76);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(255, 26);
            this.nameBox.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 27);
            this.label2.TabIndex = 22;
            this.label2.Text = "Фамилия:";
            // 
            // surnameBox
            // 
            this.surnameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.surnameBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.surnameBox.Location = new System.Drawing.Point(215, 33);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(255, 26);
            this.surnameBox.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.birthdayDateBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.INNBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.SNILSBox);
            this.groupBox2.Controls.Add(this.numberPassportBox);
            this.groupBox2.Controls.Add(this.seriaBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(530, 260);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дополнительная информация";
            // 
            // birthdayDateBox
            // 
            this.birthdayDateBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.birthdayDateBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.birthdayDateBox.Location = new System.Drawing.Point(216, 211);
            this.birthdayDateBox.MaxDate = new System.DateTime(2105, 11, 20, 0, 0, 0, 0);
            this.birthdayDateBox.Name = "birthdayDateBox";
            this.birthdayDateBox.Size = new System.Drawing.Size(244, 26);
            this.birthdayDateBox.TabIndex = 40;
            this.birthdayDateBox.Value = new System.DateTime(2021, 11, 13, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(55, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 27);
            this.label10.TabIndex = 39;
            this.label10.Text = "Дата рождения:";
            // 
            // INNBox
            // 
            this.INNBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.INNBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.INNBox.Location = new System.Drawing.Point(216, 166);
            this.INNBox.Mask = "000000000000";
            this.INNBox.Name = "INNBox";
            this.INNBox.Size = new System.Drawing.Size(244, 26);
            this.INNBox.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(155, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 27);
            this.label9.TabIndex = 37;
            this.label9.Text = "ИНН:";
            // 
            // SNILSBox
            // 
            this.SNILSBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SNILSBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SNILSBox.Location = new System.Drawing.Point(216, 125);
            this.SNILSBox.Mask = "00000000000";
            this.SNILSBox.Name = "SNILSBox";
            this.SNILSBox.Size = new System.Drawing.Size(244, 26);
            this.SNILSBox.TabIndex = 36;
            // 
            // numberPassportBox
            // 
            this.numberPassportBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numberPassportBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberPassportBox.Location = new System.Drawing.Point(216, 82);
            this.numberPassportBox.Mask = "000000";
            this.numberPassportBox.Name = "numberPassportBox";
            this.numberPassportBox.Size = new System.Drawing.Size(244, 26);
            this.numberPassportBox.TabIndex = 35;
            // 
            // seriaBox
            // 
            this.seriaBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.seriaBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.seriaBox.Location = new System.Drawing.Point(216, 40);
            this.seriaBox.Mask = "0000";
            this.seriaBox.Name = "seriaBox";
            this.seriaBox.Size = new System.Drawing.Size(244, 26);
            this.seriaBox.TabIndex = 34;
            this.seriaBox.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 27);
            this.label6.TabIndex = 32;
            this.label6.Text = "СНИЛС:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 27);
            this.label7.TabIndex = 30;
            this.label7.Text = "Номер паспорта:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 27);
            this.label8.TabIndex = 28;
            this.label8.Text = "Серия паспорта:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.photoButton);
            this.groupBox3.Controls.Add(this.scanPictureBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 580);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(530, 287);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Скан паспорта";
            // 
            // photoButton
            // 
            this.photoButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.photoButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.photoButton.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.photoButton.Location = new System.Drawing.Point(17, 244);
            this.photoButton.Name = "photoButton";
            this.photoButton.Size = new System.Drawing.Size(497, 31);
            this.photoButton.TabIndex = 42;
            this.photoButton.Text = "Прикрепить фото";
            this.photoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.photoButton.UseVisualStyleBackColor = false;
            this.photoButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // scanPictureBox
            // 
            this.scanPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scanPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scanPictureBox.Location = new System.Drawing.Point(17, 34);
            this.scanPictureBox.Name = "scanPictureBox";
            this.scanPictureBox.Size = new System.Drawing.Size(497, 204);
            this.scanPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.scanPictureBox.TabIndex = 0;
            this.scanPictureBox.TabStop = false;
            // 
            // FormEmployeesEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(555, 875);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.saveButton);
            this.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MinimumSize = new System.Drawing.Size(571, 812);
            this.Name = "FormEmployeesEdit";
            this.Text = "FormEmployeesEdit";
            this.Load += new System.EventHandler(this.FormEmployeesEdit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scanPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox positionBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox firedCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox middlenameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker birthdayDateBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox INNBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox SNILSBox;
        private System.Windows.Forms.MaskedTextBox numberPassportBox;
        private System.Windows.Forms.MaskedTextBox seriaBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button photoButton;
        private System.Windows.Forms.PictureBox scanPictureBox;
    }
}