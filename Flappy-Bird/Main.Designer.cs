namespace Flappy_Bird
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
            this.components = new System.ComponentModel.Container();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.PipeBottom = new System.Windows.Forms.Panel();
            this.PipeTop = new System.Windows.Forms.Panel();
            this.Ground = new System.Windows.Forms.Panel();
            this.BirdPb = new System.Windows.Forms.PictureBox();
            this.Top = new System.Windows.Forms.Panel();
            this.GameDelay = new System.Windows.Forms.Timer(this.components);
            this.SpaceLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.BirdPb)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 15;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // PipeBottom
            // 
            this.PipeBottom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PipeBottom.BackgroundImage = global::Flappy_Bird.Properties.Resources.pipe;
            this.PipeBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PipeBottom.Location = new System.Drawing.Point(1010, 347);
            this.PipeBottom.Name = "PipeBottom";
            this.PipeBottom.Size = new System.Drawing.Size(102, 137);
            this.PipeBottom.TabIndex = 3;
            this.PipeBottom.Visible = false;
            // 
            // PipeTop
            // 
            this.PipeTop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PipeTop.BackgroundImage = global::Flappy_Bird.Properties.Resources.pipedown;
            this.PipeTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PipeTop.Location = new System.Drawing.Point(1010, 1);
            this.PipeTop.Name = "PipeTop";
            this.PipeTop.Size = new System.Drawing.Size(102, 138);
            this.PipeTop.TabIndex = 2;
            this.PipeTop.Visible = false;
            // 
            // Ground
            // 
            this.Ground.BackgroundImage = global::Flappy_Bird.Properties.Resources.ground;
            this.Ground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ground.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Ground.Location = new System.Drawing.Point(0, 484);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(1112, 139);
            this.Ground.TabIndex = 1;
            // 
            // BirdPb
            // 
            this.BirdPb.Image = global::Flappy_Bird.Properties.Resources.bird;
            this.BirdPb.Location = new System.Drawing.Point(108, 145);
            this.BirdPb.Name = "BirdPb";
            this.BirdPb.Size = new System.Drawing.Size(74, 57);
            this.BirdPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BirdPb.TabIndex = 0;
            this.BirdPb.TabStop = false;
            this.BirdPb.Visible = false;
            // 
            // Top
            // 
            this.Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top.Location = new System.Drawing.Point(0, 0);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(1112, 1);
            this.Top.TabIndex = 4;
            // 
            // GameDelay
            // 
            this.GameDelay.Interval = 15;
            this.GameDelay.Tick += new System.EventHandler(this.GameDelay_Tick);
            // 
            // SpaceLabel
            // 
            this.SpaceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpaceLabel.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpaceLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.SpaceLabel.Location = new System.Drawing.Point(0, 0);
            this.SpaceLabel.Name = "SpaceLabel";
            this.SpaceLabel.Size = new System.Drawing.Size(1112, 196);
            this.SpaceLabel.TabIndex = 5;
            this.SpaceLabel.Text = "Press Space To Start";
            this.SpaceLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SpaceLabel);
            this.panel1.Location = new System.Drawing.Point(0, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 196);
            this.panel1.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1112, 623);
            this.Controls.Add(this.Top);
            this.Controls.Add(this.PipeBottom);
            this.Controls.Add(this.PipeTop);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.BirdPb);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Flappy Bird - by Richard Jacobs";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Main_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.BirdPb)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BirdPb;
        private System.Windows.Forms.Panel Ground;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Panel PipeTop;
        private System.Windows.Forms.Panel PipeBottom;
        private System.Windows.Forms.Panel Top;
        private System.Windows.Forms.Timer GameDelay;
        private System.Windows.Forms.Label SpaceLabel;
        private System.Windows.Forms.Panel panel1;
    }
}

