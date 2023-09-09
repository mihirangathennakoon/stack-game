
namespace Stakc_data_Game
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
            this.lblwelcome = new System.Windows.Forms.Label();
            this.picBoxYellow = new System.Windows.Forms.PictureBox();
            this.picBoxRed = new System.Windows.Forms.PictureBox();
            this.picBoxGreen = new System.Windows.Forms.PictureBox();
            this.picBoxBlue = new System.Windows.Forms.PictureBox();
            this.picBoxPurpul = new System.Windows.Forms.PictureBox();
            this.picBoxOrange = new System.Windows.Forms.PictureBox();
            this.btnpop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPurpul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOrange)).BeginInit();
            this.SuspendLayout();
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcome.Location = new System.Drawing.Point(110, 18);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(989, 46);
            this.lblwelcome.TabIndex = 0;
            this.lblwelcome.Text = "Simple idea of how Stack Data Structure is working ";
            this.lblwelcome.Click += new System.EventHandler(this.lblwelcome_Click);
            // 
            // picBoxYellow
            // 
            this.picBoxYellow.BackColor = System.Drawing.Color.Yellow;
            this.picBoxYellow.Location = new System.Drawing.Point(583, 204);
            this.picBoxYellow.Name = "picBoxYellow";
            this.picBoxYellow.Size = new System.Drawing.Size(79, 73);
            this.picBoxYellow.TabIndex = 1;
            this.picBoxYellow.TabStop = false;
            this.picBoxYellow.Click += new System.EventHandler(this.picBoxYellow_Click);
            // 
            // picBoxRed
            // 
            this.picBoxRed.BackColor = System.Drawing.Color.Red;
            this.picBoxRed.Location = new System.Drawing.Point(583, 304);
            this.picBoxRed.Name = "picBoxRed";
            this.picBoxRed.Size = new System.Drawing.Size(79, 73);
            this.picBoxRed.TabIndex = 2;
            this.picBoxRed.TabStop = false;
            this.picBoxRed.Click += new System.EventHandler(this.picBoxRed_Click);
            // 
            // picBoxGreen
            // 
            this.picBoxGreen.BackColor = System.Drawing.Color.Lime;
            this.picBoxGreen.Location = new System.Drawing.Point(583, 404);
            this.picBoxGreen.Name = "picBoxGreen";
            this.picBoxGreen.Size = new System.Drawing.Size(79, 73);
            this.picBoxGreen.TabIndex = 3;
            this.picBoxGreen.TabStop = false;
            this.picBoxGreen.Click += new System.EventHandler(this.picBoxGreen_Click);
            // 
            // picBoxBlue
            // 
            this.picBoxBlue.BackColor = System.Drawing.Color.Blue;
            this.picBoxBlue.Location = new System.Drawing.Point(472, 204);
            this.picBoxBlue.Name = "picBoxBlue";
            this.picBoxBlue.Size = new System.Drawing.Size(79, 73);
            this.picBoxBlue.TabIndex = 4;
            this.picBoxBlue.TabStop = false;
            this.picBoxBlue.Click += new System.EventHandler(this.picBoxBlue_Click);
            // 
            // picBoxPurpul
            // 
            this.picBoxPurpul.BackColor = System.Drawing.Color.Purple;
            this.picBoxPurpul.Location = new System.Drawing.Point(472, 304);
            this.picBoxPurpul.Name = "picBoxPurpul";
            this.picBoxPurpul.Size = new System.Drawing.Size(79, 73);
            this.picBoxPurpul.TabIndex = 5;
            this.picBoxPurpul.TabStop = false;
            this.picBoxPurpul.Click += new System.EventHandler(this.picBoxPurpul_Click);
            // 
            // picBoxOrange
            // 
            this.picBoxOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.picBoxOrange.Location = new System.Drawing.Point(472, 404);
            this.picBoxOrange.Name = "picBoxOrange";
            this.picBoxOrange.Size = new System.Drawing.Size(79, 73);
            this.picBoxOrange.TabIndex = 6;
            this.picBoxOrange.TabStop = false;
            this.picBoxOrange.Click += new System.EventHandler(this.picBoxOrange_Click);
            // 
            // btnpop
            // 
            this.btnpop.Location = new System.Drawing.Point(495, 597);
            this.btnpop.Name = "btnpop";
            this.btnpop.Size = new System.Drawing.Size(152, 54);
            this.btnpop.TabIndex = 7;
            this.btnpop.Text = "Pop The Color";
            this.btnpop.UseVisualStyleBackColor = true;
            this.btnpop.Click += new System.EventHandler(this.btnpop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Click the color you want to Push";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(503, 536);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Last in First out";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 714);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnpop);
            this.Controls.Add(this.picBoxOrange);
            this.Controls.Add(this.picBoxPurpul);
            this.Controls.Add(this.picBoxBlue);
            this.Controls.Add(this.picBoxGreen);
            this.Controls.Add(this.picBoxRed);
            this.Controls.Add(this.picBoxYellow);
            this.Controls.Add(this.lblwelcome);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPurpul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOrange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.PictureBox picBoxYellow;
        private System.Windows.Forms.PictureBox picBoxRed;
        private System.Windows.Forms.PictureBox picBoxGreen;
        private System.Windows.Forms.PictureBox picBoxBlue;
        private System.Windows.Forms.PictureBox picBoxPurpul;
        private System.Windows.Forms.PictureBox picBoxOrange;
        private System.Windows.Forms.Button btnpop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

