namespace GitTest
{
    partial class frmGitTest
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
            this.btnKlik = new System.Windows.Forms.Button();
            this.picFiguur = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFiguur)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKlik
            // 
            this.btnKlik.Location = new System.Drawing.Point(57, 55);
            this.btnKlik.Name = "btnKlik";
            this.btnKlik.Size = new System.Drawing.Size(108, 72);
            this.btnKlik.TabIndex = 0;
            this.btnKlik.Text = "KLIK MIJ!";
            this.btnKlik.UseVisualStyleBackColor = true;
            this.btnKlik.Click += new System.EventHandler(this.btnKlik_Click);
            // 
            // picFiguur
            // 
            this.picFiguur.Image = global::GitTest.Properties.Resources.Figuur;
            this.picFiguur.Location = new System.Drawing.Point(0, -4);
            this.picFiguur.Name = "picFiguur";
            this.picFiguur.Size = new System.Drawing.Size(223, 196);
            this.picFiguur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFiguur.TabIndex = 1;
            this.picFiguur.TabStop = false;
            this.picFiguur.Visible = false;
            this.picFiguur.Click += new System.EventHandler(this.picFiguur_Click);
            // 
            // frmGitTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 191);
            this.Controls.Add(this.picFiguur);
            this.Controls.Add(this.btnKlik);
            this.Name = "frmGitTest";
            this.Text = "Git Test";
            ((System.ComponentModel.ISupportInitialize)(this.picFiguur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKlik;
        private System.Windows.Forms.PictureBox picFiguur;
    }
}

