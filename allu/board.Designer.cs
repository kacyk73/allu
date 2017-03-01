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
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1244, 283);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "1";
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 647);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_start2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Board";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "the allu game";
            this.Load += new System.EventHandler(this.Board_Load);
            this.DoubleClick += new System.EventHandler(this.Board_DoubleClick);
            this.MouseHover += new System.EventHandler(this.Board_MouseHover);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Board_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start2;
        private System.Windows.Forms.TextBox textBox1;
    }
}