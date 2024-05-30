namespace prjOefn13
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnLore = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnMute = new System.Windows.Forms.Button();
            this.btnUnmute = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnPatchNotes = new System.Windows.Forms.Button();
            this.btnSpelerInv = new System.Windows.Forms.Button();
            this.btnSpelerUitv = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(126, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(296, 42);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Gegroet Speler!";
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(175, 98);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(175, 57);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Vecht!";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Location = new System.Drawing.Point(175, 176);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(175, 57);
            this.btnInfo.TabIndex = 2;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnLore
            // 
            this.btnLore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLore.Location = new System.Drawing.Point(175, 264);
            this.btnLore.Name = "btnLore";
            this.btnLore.Size = new System.Drawing.Size(175, 57);
            this.btnLore.TabIndex = 3;
            this.btnLore.Text = "Lore";
            this.btnLore.UseVisualStyleBackColor = true;
            this.btnLore.Click += new System.EventHandler(this.btnLore_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(28, 51);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(471, 29);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Ben jij klaar voor een EPISCH GEVECHT?!\r\n";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(0, 346);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(519, 52);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = resources.GetString("lbl3.Text");
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(384, 288);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(124, 33);
            this.btnQuit.TabIndex = 6;
            this.btnQuit.Text = "Afsluiten";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnMute
            // 
            this.btnMute.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMute.Location = new System.Drawing.Point(12, 288);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(115, 33);
            this.btnMute.TabIndex = 7;
            this.btnMute.Text = "Mute";
            this.btnMute.UseVisualStyleBackColor = true;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // btnUnmute
            // 
            this.btnUnmute.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnmute.Location = new System.Drawing.Point(12, 249);
            this.btnUnmute.Name = "btnUnmute";
            this.btnUnmute.Size = new System.Drawing.Size(115, 33);
            this.btnUnmute.TabIndex = 8;
            this.btnUnmute.Text = "Unmute";
            this.btnUnmute.UseVisualStyleBackColor = true;
            this.btnUnmute.Click += new System.EventHandler(this.btnUnmute_Click);
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Location = new System.Drawing.Point(384, 249);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(124, 33);
            this.btnModify.TabIndex = 9;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnPatchNotes
            // 
            this.btnPatchNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatchNotes.Location = new System.Drawing.Point(12, 98);
            this.btnPatchNotes.Name = "btnPatchNotes";
            this.btnPatchNotes.Size = new System.Drawing.Size(115, 57);
            this.btnPatchNotes.TabIndex = 10;
            this.btnPatchNotes.Text = "Patch Notes";
            this.btnPatchNotes.UseVisualStyleBackColor = true;
            this.btnPatchNotes.Click += new System.EventHandler(this.btnPatchNotes_Click);
            // 
            // btnSpelerInv
            // 
            this.btnSpelerInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpelerInv.Location = new System.Drawing.Point(384, 115);
            this.btnSpelerInv.Name = "btnSpelerInv";
            this.btnSpelerInv.Size = new System.Drawing.Size(124, 57);
            this.btnSpelerInv.TabIndex = 11;
            this.btnSpelerInv.Text = "Speler Invoeren";
            this.btnSpelerInv.UseVisualStyleBackColor = true;
            this.btnSpelerInv.Click += new System.EventHandler(this.btnSpelerInv_Click);
            // 
            // btnSpelerUitv
            // 
            this.btnSpelerUitv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpelerUitv.Location = new System.Drawing.Point(384, 178);
            this.btnSpelerUitv.Name = "btnSpelerUitv";
            this.btnSpelerUitv.Size = new System.Drawing.Size(124, 57);
            this.btnSpelerUitv.TabIndex = 12;
            this.btnSpelerUitv.Text = "Speler weergeven";
            this.btnSpelerUitv.UseVisualStyleBackColor = true;
            this.btnSpelerUitv.Click += new System.EventHandler(this.btnSpelerUitv_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.Location = new System.Drawing.Point(12, 176);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(115, 57);
            this.btnInventory.TabIndex = 13;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 405);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnSpelerUitv);
            this.Controls.Add(this.btnSpelerInv);
            this.Controls.Add(this.btnPatchNotes);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnUnmute);
            this.Controls.Add(this.btnMute);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.btnLore);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lbl1);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnLore;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnMute;
        private System.Windows.Forms.Button btnUnmute;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnPatchNotes;
        private System.Windows.Forms.Button btnSpelerInv;
        private System.Windows.Forms.Button btnSpelerUitv;
        private System.Windows.Forms.Button btnInventory;
    }
}