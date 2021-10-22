
namespace WFAFlappyBird
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
            this.components = new System.ComponentModel.Container();
            this.pbBird = new System.Windows.Forms.PictureBox();
            this.pbPipe1 = new System.Windows.Forms.PictureBox();
            this.pbPipe2 = new System.Windows.Forms.PictureBox();
            this.pbPipe3 = new System.Windows.Forms.PictureBox();
            this.pbPipe4 = new System.Windows.Forms.PictureBox();
            this.pbGround = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBird
            // 
            this.pbBird.Image = global::WFAFlappyBird.Properties.Resources.birdnew;
            this.pbBird.Location = new System.Drawing.Point(12, 150);
            this.pbBird.Name = "pbBird";
            this.pbBird.Size = new System.Drawing.Size(41, 50);
            this.pbBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBird.TabIndex = 0;
            this.pbBird.TabStop = false;
            // 
            // pbPipe1
            // 
            this.pbPipe1.Image = global::WFAFlappyBird.Properties.Resources.pipe;
            this.pbPipe1.Location = new System.Drawing.Point(169, 268);
            this.pbPipe1.Name = "pbPipe1";
            this.pbPipe1.Size = new System.Drawing.Size(46, 136);
            this.pbPipe1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipe1.TabIndex = 1;
            this.pbPipe1.TabStop = false;
            // 
            // pbPipe2
            // 
            this.pbPipe2.Image = global::WFAFlappyBird.Properties.Resources.pipedown;
            this.pbPipe2.Location = new System.Drawing.Point(299, 2);
            this.pbPipe2.Name = "pbPipe2";
            this.pbPipe2.Size = new System.Drawing.Size(42, 89);
            this.pbPipe2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipe2.TabIndex = 2;
            this.pbPipe2.TabStop = false;
            // 
            // pbPipe3
            // 
            this.pbPipe3.Image = global::WFAFlappyBird.Properties.Resources.pipe;
            this.pbPipe3.Location = new System.Drawing.Point(399, 304);
            this.pbPipe3.Name = "pbPipe3";
            this.pbPipe3.Size = new System.Drawing.Size(42, 100);
            this.pbPipe3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipe3.TabIndex = 3;
            this.pbPipe3.TabStop = false;
            // 
            // pbPipe4
            // 
            this.pbPipe4.Image = global::WFAFlappyBird.Properties.Resources.pipedown;
            this.pbPipe4.Location = new System.Drawing.Point(532, 2);
            this.pbPipe4.Name = "pbPipe4";
            this.pbPipe4.Size = new System.Drawing.Size(44, 136);
            this.pbPipe4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipe4.TabIndex = 4;
            this.pbPipe4.TabStop = false;
            // 
            // pbGround
            // 
            this.pbGround.Image = global::WFAFlappyBird.Properties.Resources.ground;
            this.pbGround.Location = new System.Drawing.Point(1, 400);
            this.pbGround.Name = "pbGround";
            this.pbGround.Size = new System.Drawing.Size(669, 50);
            this.pbGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGround.TabIndex = 5;
            this.pbGround.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScore.Location = new System.Drawing.Point(7, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(82, 25);
            this.lblScore.TabIndex = 10;
            this.lblScore.Text = "Score: ";
            // 
            // tmrGame
            // 
            this.tmrGame.Enabled = true;
            this.tmrGame.Interval = 20;
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbGround);
            this.Controls.Add(this.pbPipe4);
            this.Controls.Add(this.pbPipe3);
            this.Controls.Add(this.pbPipe2);
            this.Controls.Add(this.pbPipe1);
            this.Controls.Add(this.pbBird);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBird;
        private System.Windows.Forms.PictureBox pbPipe2;
        private System.Windows.Forms.PictureBox pbPipe3;
        private System.Windows.Forms.PictureBox pbPipe4;
        private System.Windows.Forms.PictureBox pbGround;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pbPipe1;
        private System.Windows.Forms.Timer tmrGame;
    }
}

