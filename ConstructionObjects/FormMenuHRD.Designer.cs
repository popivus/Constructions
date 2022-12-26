
namespace ConstructionObjects
{
    partial class FormMenuHRD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuHRD));
            this.button7 = new System.Windows.Forms.Button();
            this.employeeButton = new System.Windows.Forms.Button();
            this.positionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Control;
            this.button7.Font = new System.Drawing.Font("Dubai", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(12, 12);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.button7.Size = new System.Drawing.Size(104, 25);
            this.button7.TabIndex = 12;
            this.button7.Text = "Выйти";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // employeeButton
            // 
            this.employeeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.employeeButton.Location = new System.Drawing.Point(82, 106);
            this.employeeButton.Name = "employeeButton";
            this.employeeButton.Size = new System.Drawing.Size(255, 31);
            this.employeeButton.TabIndex = 28;
            this.employeeButton.Text = "Сотрудники";
            this.employeeButton.UseVisualStyleBackColor = false;
            this.employeeButton.Click += new System.EventHandler(this.employeeButton_Click);
            // 
            // positionButton
            // 
            this.positionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.positionButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.positionButton.Location = new System.Drawing.Point(82, 155);
            this.positionButton.Name = "positionButton";
            this.positionButton.Size = new System.Drawing.Size(255, 31);
            this.positionButton.TabIndex = 29;
            this.positionButton.Text = "Должности";
            this.positionButton.UseVisualStyleBackColor = false;
            this.positionButton.Click += new System.EventHandler(this.positionButton_Click);
            // 
            // FormMenuHRD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(423, 275);
            this.Controls.Add(this.positionButton);
            this.Controls.Add(this.employeeButton);
            this.Controls.Add(this.button7);
            this.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MinimumSize = new System.Drawing.Size(439, 314);
            this.Name = "FormMenuHRD";
            this.Text = "Отдел кадров";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMenuHRD_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button employeeButton;
        private System.Windows.Forms.Button positionButton;
    }
}