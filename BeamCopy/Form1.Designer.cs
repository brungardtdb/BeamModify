namespace BeamCopy
{
    partial class frmBeamCopy
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
            this.btnModifySelected = new System.Windows.Forms.Button();
            this.btnModifyPick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModifySelected
            // 
            this.btnModifySelected.Location = new System.Drawing.Point(12, 12);
            this.btnModifySelected.Name = "btnModifySelected";
            this.btnModifySelected.Size = new System.Drawing.Size(137, 23);
            this.btnModifySelected.TabIndex = 0;
            this.btnModifySelected.Text = "Modify Selected";
            this.btnModifySelected.UseVisualStyleBackColor = true;
            this.btnModifySelected.Click += new System.EventHandler(this.btnModifySelected_Click);
            // 
            // btnModifyPick
            // 
            this.btnModifyPick.Location = new System.Drawing.Point(12, 41);
            this.btnModifyPick.Name = "btnModifyPick";
            this.btnModifyPick.Size = new System.Drawing.Size(137, 23);
            this.btnModifyPick.TabIndex = 1;
            this.btnModifyPick.Text = "Modify by Pick";
            this.btnModifyPick.UseVisualStyleBackColor = true;
            this.btnModifyPick.Click += new System.EventHandler(this.btnModifyPick_Click);
            // 
            // frmBeamCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 103);
            this.Controls.Add(this.btnModifyPick);
            this.Controls.Add(this.btnModifySelected);
            this.Name = "frmBeamCopy";
            this.Text = "Beam Copy";
            this.Load += new System.EventHandler(this.frmBeamCopy_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModifySelected;
        private System.Windows.Forms.Button btnModifyPick;
    }
}

