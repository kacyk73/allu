﻿namespace allu
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
            this.labely = new System.Windows.Forms.Label();
            this.lblFriendFoe = new System.Windows.Forms.Label();
            this.lbl_memory = new System.Windows.Forms.Label();
            this.lbl_population = new System.Windows.Forms.Label();
            this.lbl_army_type = new System.Windows.Forms.Label();
            this.lbl_game_state = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            // labely
            // 
            this.labely.AutoSize = true;
            this.labely.Location = new System.Drawing.Point(1244, 310);
            this.labely.Name = "labely";
            this.labely.Size = new System.Drawing.Size(34, 13);
            this.labely.TabIndex = 2;
            this.labely.Text = "labely";
            // 
            // lblFriendFoe
            // 
            this.lblFriendFoe.AutoSize = true;
            this.lblFriendFoe.Location = new System.Drawing.Point(1253, 52);
            this.lblFriendFoe.Name = "lblFriendFoe";
            this.lblFriendFoe.Size = new System.Drawing.Size(54, 13);
            this.lblFriendFoe.TabIndex = 3;
            this.lblFriendFoe.Text = "FriendFoe";
            // 
            // lbl_memory
            // 
            this.lbl_memory.AutoSize = true;
            this.lbl_memory.Location = new System.Drawing.Point(1276, 128);
            this.lbl_memory.Name = "lbl_memory";
            this.lbl_memory.Size = new System.Drawing.Size(75, 13);
            this.lbl_memory.TabIndex = 4;
            this.lbl_memory.Text = "memory_stack";
            // 
            // lbl_population
            // 
            this.lbl_population.AutoSize = true;
            this.lbl_population.Location = new System.Drawing.Point(1253, 78);
            this.lbl_population.Name = "lbl_population";
            this.lbl_population.Size = new System.Drawing.Size(56, 13);
            this.lbl_population.TabIndex = 5;
            this.lbl_population.Text = "population";
            // 
            // lbl_army_type
            // 
            this.lbl_army_type.AutoSize = true;
            this.lbl_army_type.Location = new System.Drawing.Point(1253, 103);
            this.lbl_army_type.Name = "lbl_army_type";
            this.lbl_army_type.Size = new System.Drawing.Size(55, 13);
            this.lbl_army_type.TabIndex = 6;
            this.lbl_army_type.Text = "army_type";
            // 
            // lbl_game_state
            // 
            this.lbl_game_state.AutoSize = true;
            this.lbl_game_state.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_game_state.Location = new System.Drawing.Point(1306, 9);
            this.lbl_game_state.Name = "lbl_game_state";
            this.lbl_game_state.Size = new System.Drawing.Size(62, 13);
            this.lbl_game_state.TabIndex = 7;
            this.lbl_game_state.Text = "game_state";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1275, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "State";
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 647);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_game_state);
            this.Controls.Add(this.lbl_army_type);
            this.Controls.Add(this.lbl_population);
            this.Controls.Add(this.lbl_memory);
            this.Controls.Add(this.lblFriendFoe);
            this.Controls.Add(this.labely);
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
        private System.Windows.Forms.Label labely;
        private System.Windows.Forms.Label lblFriendFoe;
        private System.Windows.Forms.Label lbl_memory;
        private System.Windows.Forms.Label lbl_population;
        private System.Windows.Forms.Label lbl_army_type;
        private System.Windows.Forms.Label lbl_game_state;
        private System.Windows.Forms.Label label1;
    }
}