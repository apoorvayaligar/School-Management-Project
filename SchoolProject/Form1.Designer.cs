
namespace SchoolProject
{
    partial class Form1
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
            this.btn_FeeDetail = new System.Windows.Forms.Button();
            this.btn_Show = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_FeeDetail
            // 
            this.btn_FeeDetail.Location = new System.Drawing.Point(241, 106);
            this.btn_FeeDetail.Name = "btn_FeeDetail";
            this.btn_FeeDetail.Size = new System.Drawing.Size(122, 23);
            this.btn_FeeDetail.TabIndex = 0;
            this.btn_FeeDetail.Text = "Create FeeDetail";
            this.btn_FeeDetail.UseVisualStyleBackColor = true;
            this.btn_FeeDetail.Click += new System.EventHandler(this.btn_FeeDetail_Click);
            // 
            // btn_Show
            // 
            this.btn_Show.Location = new System.Drawing.Point(241, 204);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(122, 23);
            this.btn_Show.TabIndex = 1;
            this.btn_Show.Text = "Show Phone Numbers";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(604, 367);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.btn_FeeDetail);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button btn_FeeDetail;
        private System.Windows.Forms.Button btn_Show;
    }
}

