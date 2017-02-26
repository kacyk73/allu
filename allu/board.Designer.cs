namespace allu
{
    partial class Board
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
            this.btn_start2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_start2
            // 
            this.btn_start2.Location = new System.Drawing.Point(110, 90);
            this.btn_start2.Name = "btn_start2";
            this.btn_start2.Size = new System.Drawing.Size(75, 23);
            this.btn_start2.TabIndex = 0;
            this.btn_start2.Text = "start";
            this.btn_start2.UseVisualStyleBackColor = true;
            this.btn_start2.Click += new System.EventHandler(this.btn_start2_Click);
            // 
            // board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 647);
            this.Controls.Add(this.btn_start2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "board";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "the allu game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_start2;
    }
}