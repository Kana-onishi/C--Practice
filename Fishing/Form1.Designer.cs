namespace Fishing
{
    partial class FormGame
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxIwashi = new System.Windows.Forms.PictureBox();
            this.pictureBoxUtsubo = new System.Windows.Forms.PictureBox();
            this.pictureBoxAnkou = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelRemaining = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.pictureBoxEsaS = new System.Windows.Forms.PictureBox();
            this.pictureBoxEsaM = new System.Windows.Forms.PictureBox();
            this.pictureBoxEsaL = new System.Windows.Forms.PictureBox();
            this.pictureBoxHitode = new System.Windows.Forms.PictureBox();
            this.pictureBoxIso = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIwashi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUtsubo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnkou)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEsaS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEsaM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEsaL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHitode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIso)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBoxIwashi
            // 
            this.pictureBoxIwashi.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIwashi.Image")));
            this.pictureBoxIwashi.Location = new System.Drawing.Point(0, 45);
            this.pictureBoxIwashi.Name = "pictureBoxIwashi";
            this.pictureBoxIwashi.Size = new System.Drawing.Size(100, 59);
            this.pictureBoxIwashi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIwashi.TabIndex = 0;
            this.pictureBoxIwashi.TabStop = false;
            // 
            // pictureBoxUtsubo
            // 
            this.pictureBoxUtsubo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUtsubo.Image")));
            this.pictureBoxUtsubo.Location = new System.Drawing.Point(0, 140);
            this.pictureBoxUtsubo.Name = "pictureBoxUtsubo";
            this.pictureBoxUtsubo.Size = new System.Drawing.Size(215, 116);
            this.pictureBoxUtsubo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUtsubo.TabIndex = 1;
            this.pictureBoxUtsubo.TabStop = false;
            // 
            // pictureBoxAnkou
            // 
            this.pictureBoxAnkou.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAnkou.Image")));
            this.pictureBoxAnkou.Location = new System.Drawing.Point(0, 295);
            this.pictureBoxAnkou.Name = "pictureBoxAnkou";
            this.pictureBoxAnkou.Size = new System.Drawing.Size(180, 148);
            this.pictureBoxAnkou.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAnkou.TabIndex = 2;
            this.pictureBoxAnkou.TabStop = false;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(61, 19);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "スタート";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelRemaining
            // 
            this.labelRemaining.AutoSize = true;
            this.labelRemaining.Location = new System.Drawing.Point(96, 15);
            this.labelRemaining.Name = "labelRemaining";
            this.labelRemaining.Size = new System.Drawing.Size(79, 12);
            this.labelRemaining.TabIndex = 4;
            this.labelRemaining.Text = "残り時間：60秒";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(190, 15);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(35, 12);
            this.labelScore.TabIndex = 5;
            this.labelScore.Text = "得点：";
            // 
            // pictureBoxEsaS
            // 
            this.pictureBoxEsaS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEsaS.Image")));
            this.pictureBoxEsaS.Location = new System.Drawing.Point(250, 55);
            this.pictureBoxEsaS.Name = "pictureBoxEsaS";
            this.pictureBoxEsaS.Size = new System.Drawing.Size(18, 38);
            this.pictureBoxEsaS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEsaS.TabIndex = 6;
            this.pictureBoxEsaS.TabStop = false;
            // 
            // pictureBoxEsaM
            // 
            this.pictureBoxEsaM.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEsaM.Image")));
            this.pictureBoxEsaM.Location = new System.Drawing.Point(426, 155);
            this.pictureBoxEsaM.Name = "pictureBoxEsaM";
            this.pictureBoxEsaM.Size = new System.Drawing.Size(31, 75);
            this.pictureBoxEsaM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxEsaM.TabIndex = 7;
            this.pictureBoxEsaM.TabStop = false;
            // 
            // pictureBoxEsaL
            // 
            this.pictureBoxEsaL.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEsaL.Image")));
            this.pictureBoxEsaL.Location = new System.Drawing.Point(698, 338);
            this.pictureBoxEsaL.Name = "pictureBoxEsaL";
            this.pictureBoxEsaL.Size = new System.Drawing.Size(35, 100);
            this.pictureBoxEsaL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEsaL.TabIndex = 8;
            this.pictureBoxEsaL.TabStop = false;
            // 
            // pictureBoxHitode
            // 
            this.pictureBoxHitode.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHitode.Image")));
            this.pictureBoxHitode.Location = new System.Drawing.Point(325, 397);
            this.pictureBoxHitode.Name = "pictureBoxHitode";
            this.pictureBoxHitode.Size = new System.Drawing.Size(46, 46);
            this.pictureBoxHitode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHitode.TabIndex = 9;
            this.pictureBoxHitode.TabStop = false;
            // 
            // pictureBoxIso
            // 
            this.pictureBoxIso.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIso.Image")));
            this.pictureBoxIso.Location = new System.Drawing.Point(459, 381);
            this.pictureBoxIso.Name = "pictureBoxIso";
            this.pictureBoxIso.Size = new System.Drawing.Size(59, 62);
            this.pictureBoxIso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIso.TabIndex = 10;
            this.pictureBoxIso.TabStop = false;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxIso);
            this.Controls.Add(this.pictureBoxHitode);
            this.Controls.Add(this.pictureBoxEsaL);
            this.Controls.Add(this.pictureBoxEsaM);
            this.Controls.Add(this.pictureBoxEsaS);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelRemaining);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.pictureBoxAnkou);
            this.Controls.Add(this.pictureBoxUtsubo);
            this.Controls.Add(this.pictureBoxIwashi);
            this.KeyPreview = true;
            this.Name = "FormGame";
            this.Text = "釣りゲーム";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormGame_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIwashi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUtsubo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnkou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEsaS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEsaM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEsaL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHitode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxIwashi;
        private System.Windows.Forms.PictureBox pictureBoxUtsubo;
        private System.Windows.Forms.PictureBox pictureBoxAnkou;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelRemaining;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.PictureBox pictureBoxEsaS;
        private System.Windows.Forms.PictureBox pictureBoxEsaM;
        private System.Windows.Forms.PictureBox pictureBoxEsaL;
        private System.Windows.Forms.PictureBox pictureBoxHitode;
        private System.Windows.Forms.PictureBox pictureBoxIso;
    }
}

