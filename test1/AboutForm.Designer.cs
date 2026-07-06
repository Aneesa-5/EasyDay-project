namespace EasyDay_SignUp
{
    partial class AboutForm
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
            txtAboutContent = new RichTextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtAboutContent
            // 
            txtAboutContent.BorderStyle = BorderStyle.None;
            txtAboutContent.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtAboutContent.Location = new Point(20, 20);
            txtAboutContent.Name = "txtAboutContent";
            txtAboutContent.ReadOnly = true;
            txtAboutContent.ScrollBars = RichTextBoxScrollBars.Vertical;
            txtAboutContent.Size = new Size(460, 500);
            txtAboutContent.TabIndex = 0;
            txtAboutContent.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(174, 31);
            label1.TabIndex = 1;
            label1.Text = "About EasyDay";
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 553);
            Controls.Add(label1);
            Controls.Add(txtAboutContent);
            Name = "AboutForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AboutForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtAboutContent;
        private Label label1;
    }
}