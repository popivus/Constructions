
namespace ConstructionObjects
{
    partial class FormExport
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
            this.wordExportButton = new System.Windows.Forms.Button();
            this.pdfExportButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // wordExportButton
            // 
            this.wordExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.wordExportButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.wordExportButton.Image = global::ConstructionObjects.Properties.Resources.free_icon_word_888933__1_;
            this.wordExportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.wordExportButton.Location = new System.Drawing.Point(12, 12);
            this.wordExportButton.Name = "wordExportButton";
            this.wordExportButton.Padding = new System.Windows.Forms.Padding(5);
            this.wordExportButton.Size = new System.Drawing.Size(106, 42);
            this.wordExportButton.TabIndex = 48;
            this.wordExportButton.Text = "Word";
            this.wordExportButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.wordExportButton.UseVisualStyleBackColor = false;
            this.wordExportButton.Click += new System.EventHandler(this.wordExportButton_Click);
            // 
            // pdfExportButton
            // 
            this.pdfExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfExportButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pdfExportButton.Image = global::ConstructionObjects.Properties.Resources.free_icon_pdf_179483;
            this.pdfExportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pdfExportButton.Location = new System.Drawing.Point(12, 60);
            this.pdfExportButton.Name = "pdfExportButton";
            this.pdfExportButton.Padding = new System.Windows.Forms.Padding(5);
            this.pdfExportButton.Size = new System.Drawing.Size(106, 42);
            this.pdfExportButton.TabIndex = 49;
            this.pdfExportButton.Text = "PDF";
            this.pdfExportButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pdfExportButton.UseVisualStyleBackColor = false;
            this.pdfExportButton.Click += new System.EventHandler(this.pdfExportButton_Click);
            // 
            // FormExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(130, 112);
            this.Controls.Add(this.pdfExportButton);
            this.Controls.Add(this.wordExportButton);
            this.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MinimumSize = new System.Drawing.Size(146, 151);
            this.Name = "FormExport";
            this.Load += new System.EventHandler(this.FormExport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button wordExportButton;
        private System.Windows.Forms.Button pdfExportButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}