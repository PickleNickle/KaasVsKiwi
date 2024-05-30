namespace prjOefn13
{
    partial class MainGame
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
            this.TimerMAIN = new System.Windows.Forms.Timer(this.components);
            this.picKaasSnuiver = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.picGET = new System.Windows.Forms.PictureBox();
            this.prbBossHealth = new System.Windows.Forms.ProgressBar();
            this.TimerTime = new System.Windows.Forms.Timer(this.components);
            this.lblBossTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picKaasSnuiver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGET)).BeginInit();
            this.SuspendLayout();
            // 
            // TimerMAIN
            // 
            this.TimerMAIN.Interval = 1;
            this.TimerMAIN.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picKaasSnuiver
            // 
            this.picKaasSnuiver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picKaasSnuiver.Image = global::prjOefn13.Properties.Resources.download;
            this.picKaasSnuiver.Location = new System.Drawing.Point(403, 202);
            this.picKaasSnuiver.Name = "picKaasSnuiver";
            this.picKaasSnuiver.Size = new System.Drawing.Size(135, 98);
            this.picKaasSnuiver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picKaasSnuiver.TabIndex = 0;
            this.picKaasSnuiver.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Location = new System.Drawing.Point(12, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 13);
            this.lblInfo.TabIndex = 1;
            // 
            // picGET
            // 
            this.picGET.Image = global::prjOefn13.Properties.Resources.Is_Kiwifruit_Good_for_Your_Skin_;
            this.picGET.Location = new System.Drawing.Point(1166, 534);
            this.picGET.Name = "picGET";
            this.picGET.Size = new System.Drawing.Size(53, 29);
            this.picGET.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGET.TabIndex = 2;
            this.picGET.TabStop = false;
            // 
            // prbBossHealth
            // 
            this.prbBossHealth.BackColor = System.Drawing.Color.Red;
            this.prbBossHealth.ForeColor = System.Drawing.Color.Red;
            this.prbBossHealth.Location = new System.Drawing.Point(104, 34);
            this.prbBossHealth.Name = "prbBossHealth";
            this.prbBossHealth.Size = new System.Drawing.Size(1047, 23);
            this.prbBossHealth.TabIndex = 3;
            // 
            // TimerTime
            // 
            this.TimerTime.Interval = 1000;
            this.TimerTime.Tick += new System.EventHandler(this.TimerTime_Tick);
            // 
            // lblBossTitle
            // 
            this.lblBossTitle.AutoSize = true;
            this.lblBossTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBossTitle.Location = new System.Drawing.Point(489, 9);
            this.lblBossTitle.Name = "lblBossTitle";
            this.lblBossTitle.Size = new System.Drawing.Size(76, 25);
            this.lblBossTitle.TabIndex = 4;
            this.lblBossTitle.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 575);
            this.Controls.Add(this.lblBossTitle);
            this.Controls.Add(this.prbBossHealth);
            this.Controls.Add(this.picGET);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.picKaasSnuiver);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picKaasSnuiver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGET)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picKaasSnuiver;
        private System.Windows.Forms.Timer TimerMAIN;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox picGET;
        public System.Windows.Forms.ProgressBar prbBossHealth;
        private System.Windows.Forms.Timer TimerTime;
        private System.Windows.Forms.Label lblBossTitle;
    }
}

