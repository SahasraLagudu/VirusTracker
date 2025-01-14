namespace VirusTracker
{
    partial class Form2
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
            this.Title = new System.Windows.Forms.Label();
            this.csvupload = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.viewdatabase = new System.Windows.Forms.Button();
            this.instructional = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(87, 28);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(348, 54);
            this.Title.TabIndex = 0;
            this.Title.Text = "File Conversion";
            // 
            // csvupload
            // 
            this.csvupload.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csvupload.Location = new System.Drawing.Point(49, 143);
            this.csvupload.Name = "csvupload";
            this.csvupload.Size = new System.Drawing.Size(182, 56);
            this.csvupload.TabIndex = 1;
            this.csvupload.Text = "Upload .csv";
            this.csvupload.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(49, 219);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(161, 15);
            this.progressBar1.TabIndex = 2;
            // 
            // viewdatabase
            // 
            this.viewdatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewdatabase.Location = new System.Drawing.Point(158, 297);
            this.viewdatabase.Name = "viewdatabase";
            this.viewdatabase.Size = new System.Drawing.Size(246, 77);
            this.viewdatabase.TabIndex = 3;
            this.viewdatabase.Text = "View Database";
            this.viewdatabase.UseVisualStyleBackColor = true;
            // 
            // instructional
            // 
            this.instructional.AutoSize = true;
            this.instructional.Location = new System.Drawing.Point(190, 387);
            this.instructional.Name = "instructional";
            this.instructional.Size = new System.Drawing.Size(182, 13);
            this.instructional.TabIndex = 4;
            this.instructional.Text = "(Click when file upload is 100% done)";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(50, 248);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(35, 13);
            this.Status.TabIndex = 5;
            this.Status.Text = "label3";
            this.Status.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 429);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.instructional);
            this.Controls.Add(this.viewdatabase);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.csvupload);
            this.Controls.Add(this.Title);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button csvupload;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button viewdatabase;
        private System.Windows.Forms.Label instructional;
        private System.Windows.Forms.Label Status;
    }
}