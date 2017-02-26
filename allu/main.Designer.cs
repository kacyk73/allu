namespace allu
{
    partial class Main
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
            this.lbl_version = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.txt_global_x = new System.Windows.Forms.TextBox();
            this.lbl_global_x = new System.Windows.Forms.Label();
            this.lbl_global_y = new System.Windows.Forms.Label();
            this.txt_global_y = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Location = new System.Drawing.Point(208, 226);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(52, 13);
            this.lbl_version.TabIndex = 0;
            this.lbl_version.Text = "ver. 0.0.1";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(94, 122);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(97, 39);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // txt_global_x
            // 
            this.txt_global_x.Location = new System.Drawing.Point(62, 25);
            this.txt_global_x.Name = "txt_global_x";
            this.txt_global_x.Size = new System.Drawing.Size(100, 20);
            this.txt_global_x.TabIndex = 2;
            this.txt_global_x.Text = "60";
            this.txt_global_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_global_x.TextChanged += new System.EventHandler(this.txt_global_x_TextChanged);
            // 
            // lbl_global_x
            // 
            this.lbl_global_x.AutoSize = true;
            this.lbl_global_x.Location = new System.Drawing.Point(21, 25);
            this.lbl_global_x.Name = "lbl_global_x";
            this.lbl_global_x.Size = new System.Drawing.Size(14, 13);
            this.lbl_global_x.TabIndex = 3;
            this.lbl_global_x.Text = "X";
            // 
            // lbl_global_y
            // 
            this.lbl_global_y.AutoSize = true;
            this.lbl_global_y.Location = new System.Drawing.Point(21, 51);
            this.lbl_global_y.Name = "lbl_global_y";
            this.lbl_global_y.Size = new System.Drawing.Size(14, 13);
            this.lbl_global_y.TabIndex = 5;
            this.lbl_global_y.Text = "Y";
            // 
            // txt_global_y
            // 
            this.txt_global_y.Location = new System.Drawing.Point(62, 51);
            this.txt_global_y.Name = "txt_global_y";
            this.txt_global_y.Size = new System.Drawing.Size(100, 20);
            this.txt_global_y.TabIndex = 4;
            this.txt_global_y.Text = "40";
            this.txt_global_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbl_global_y);
            this.Controls.Add(this.txt_global_y);
            this.Controls.Add(this.lbl_global_x);
            this.Controls.Add(this.txt_global_x);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lbl_version);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox txt_global_x;
        private System.Windows.Forms.Label lbl_global_x;
        private System.Windows.Forms.Label lbl_global_y;
        private System.Windows.Forms.TextBox txt_global_y;
    }
}

