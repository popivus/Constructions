
namespace ConstructionObjects
{
    partial class FormTechnicsEdit
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
            this.countryAdd = new System.Windows.Forms.Button();
            this.typeAdd = new System.Windows.Forms.Button();
            this.countryBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.countryAdd);
            this.groupBox1.Controls.Add(this.typeAdd);
            this.groupBox1.Controls.Add(this.countryBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.typeBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.Location = new System.Drawing.Point(10, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 194);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Общая информация";
            // 
            // countryAdd
            // 
            this.countryAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.countryAdd.Location = new System.Drawing.Point(544, 131);
            this.countryAdd.Name = "countryAdd";
            this.countryAdd.Size = new System.Drawing.Size(30, 28);
            this.countryAdd.TabIndex = 26;
            this.countryAdd.Text = "+";
            this.countryAdd.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.countryAdd.UseVisualStyleBackColor = true;
            this.countryAdd.Click += new System.EventHandler(this.countryAdd_Click);
            // 
            // typeAdd
            // 
            this.typeAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.typeAdd.Location = new System.Drawing.Point(544, 90);
            this.typeAdd.Name = "typeAdd";
            this.typeAdd.Size = new System.Drawing.Size(30, 28);
            this.typeAdd.TabIndex = 25;
            this.typeAdd.Text = "+";
            this.typeAdd.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.typeAdd.UseVisualStyleBackColor = true;
            this.typeAdd.Click += new System.EventHandler(this.typeAdd_Click);
            // 
            // countryBox
            // 
            this.countryBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.countryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countryBox.FormattingEnabled = true;
            this.countryBox.Items.AddRange(new object[] {
            "Строитель"});
            this.countryBox.Location = new System.Drawing.Point(222, 131);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(315, 28);
            this.countryBox.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 27);
            this.label1.TabIndex = 23;
            this.label1.Text = "Страна:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Наименование:";
            // 
            // typeBox
            // 
            this.typeBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.typeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Items.AddRange(new object[] {
            "Строитель"});
            this.typeBox.Location = new System.Drawing.Point(222, 90);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(315, 28);
            this.typeBox.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 27);
            this.label6.TabIndex = 14;
            this.label6.Text = "Тип техники:";
            // 
            // nameBox
            // 
            this.nameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameBox.Location = new System.Drawing.Point(222, 49);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(315, 26);
            this.nameBox.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(10, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 31);
            this.button2.TabIndex = 34;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Location = new System.Drawing.Point(143, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 31);
            this.button1.TabIndex = 33;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormTechnicsEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(614, 266);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MinimumSize = new System.Drawing.Size(630, 305);
            this.Name = "FormTechnicsEdit";
            this.Text = "FormTechnicsEdit";
            this.Load += new System.EventHandler(this.FormTechnicsEdit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox countryBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button countryAdd;
        private System.Windows.Forms.Button typeAdd;
    }
}