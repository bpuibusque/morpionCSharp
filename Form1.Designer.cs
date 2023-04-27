namespace Morpion
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.case0 = new System.Windows.Forms.Label();
            this.case1 = new System.Windows.Forms.Label();
            this.case2 = new System.Windows.Forms.Label();
            this.case3 = new System.Windows.Forms.Label();
            this.case4 = new System.Windows.Forms.Label();
            this.case5 = new System.Windows.Forms.Label();
            this.case6 = new System.Windows.Forms.Label();
            this.case7 = new System.Windows.Forms.Label();
            this.case8 = new System.Windows.Forms.Label();
            this.replay = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nombreVictoire = new System.Windows.Forms.Label();
            this.nombreDefaite = new System.Windows.Forms.Label();
            this.nombreEgalite = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // case0
            // 
            this.case0.BackColor = System.Drawing.Color.Red;
            this.case0.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.case0.Location = new System.Drawing.Point(12, 9);
            this.case0.Name = "case0";
            this.case0.Size = new System.Drawing.Size(128, 128);
            this.case0.TabIndex = 0;
            this.case0.Text = "-";
            this.case0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.case0.Click += new System.EventHandler(this.case_click);
            // 
            // case1
            // 
            this.case1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.case1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.case1.Location = new System.Drawing.Point(146, 9);
            this.case1.Name = "case1";
            this.case1.Size = new System.Drawing.Size(128, 128);
            this.case1.TabIndex = 1;
            this.case1.Text = "-";
            this.case1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.case1.Click += new System.EventHandler(this.case_click);
            // 
            // case2
            // 
            this.case2.BackColor = System.Drawing.Color.Yellow;
            this.case2.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.case2.Location = new System.Drawing.Point(280, 9);
            this.case2.Name = "case2";
            this.case2.Size = new System.Drawing.Size(128, 128);
            this.case2.TabIndex = 2;
            this.case2.Text = "-";
            this.case2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.case2.Click += new System.EventHandler(this.case_click);
            // 
            // case3
            // 
            this.case3.BackColor = System.Drawing.Color.Lime;
            this.case3.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.case3.Location = new System.Drawing.Point(12, 146);
            this.case3.Name = "case3";
            this.case3.Size = new System.Drawing.Size(128, 128);
            this.case3.TabIndex = 3;
            this.case3.Text = "-";
            this.case3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.case3.Click += new System.EventHandler(this.case_click);
            // 
            // case4
            // 
            this.case4.BackColor = System.Drawing.Color.Cyan;
            this.case4.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.case4.Location = new System.Drawing.Point(146, 146);
            this.case4.Name = "case4";
            this.case4.Size = new System.Drawing.Size(128, 128);
            this.case4.TabIndex = 4;
            this.case4.Text = "-";
            this.case4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.case4.Click += new System.EventHandler(this.case_click);
            // 
            // case5
            // 
            this.case5.BackColor = System.Drawing.Color.Blue;
            this.case5.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.case5.Location = new System.Drawing.Point(280, 146);
            this.case5.Name = "case5";
            this.case5.Size = new System.Drawing.Size(128, 128);
            this.case5.TabIndex = 5;
            this.case5.Text = "-";
            this.case5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.case5.Click += new System.EventHandler(this.case_click);
            // 
            // case6
            // 
            this.case6.BackColor = System.Drawing.Color.Gray;
            this.case6.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.case6.ForeColor = System.Drawing.Color.White;
            this.case6.Location = new System.Drawing.Point(12, 284);
            this.case6.Name = "case6";
            this.case6.Size = new System.Drawing.Size(128, 128);
            this.case6.TabIndex = 6;
            this.case6.Text = "-";
            this.case6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.case6.Click += new System.EventHandler(this.case_click);
            // 
            // case7
            // 
            this.case7.BackColor = System.Drawing.Color.White;
            this.case7.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.case7.Location = new System.Drawing.Point(146, 284);
            this.case7.Name = "case7";
            this.case7.Size = new System.Drawing.Size(128, 128);
            this.case7.TabIndex = 7;
            this.case7.Text = "-";
            this.case7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.case7.Click += new System.EventHandler(this.case_click);
            // 
            // case8
            // 
            this.case8.BackColor = System.Drawing.Color.Gray;
            this.case8.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.case8.Location = new System.Drawing.Point(280, 284);
            this.case8.Name = "case8";
            this.case8.Size = new System.Drawing.Size(128, 128);
            this.case8.TabIndex = 8;
            this.case8.Text = "-";
            this.case8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.case8.Click += new System.EventHandler(this.case_click);
            // 
            // replay
            // 
            this.replay.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replay.Location = new System.Drawing.Point(467, 50);
            this.replay.Name = "replay";
            this.replay.Size = new System.Drawing.Size(107, 42);
            this.replay.TabIndex = 9;
            this.replay.Text = "Replay";
            this.replay.UseVisualStyleBackColor = true;
            this.replay.Click += new System.EventHandler(this.replay_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(414, 368);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(188, 51);
            this.errorLabel.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(436, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nbre Victoire :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(436, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nbre Defaite :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(436, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 35);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nbre Egalité";
            // 
            // nombreVictoire
            // 
            this.nombreVictoire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreVictoire.Location = new System.Drawing.Point(551, 126);
            this.nombreVictoire.Name = "nombreVictoire";
            this.nombreVictoire.Size = new System.Drawing.Size(51, 32);
            this.nombreVictoire.TabIndex = 14;
            this.nombreVictoire.Text = "0";
            // 
            // nombreDefaite
            // 
            this.nombreDefaite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreDefaite.Location = new System.Drawing.Point(551, 158);
            this.nombreDefaite.Name = "nombreDefaite";
            this.nombreDefaite.Size = new System.Drawing.Size(51, 32);
            this.nombreDefaite.TabIndex = 15;
            this.nombreDefaite.Text = "0";
            // 
            // nombreEgalite
            // 
            this.nombreEgalite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreEgalite.Location = new System.Drawing.Point(551, 190);
            this.nombreEgalite.Name = "nombreEgalite";
            this.nombreEgalite.Size = new System.Drawing.Size(51, 32);
            this.nombreEgalite.TabIndex = 16;
            this.nombreEgalite.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 428);
            this.Controls.Add(this.nombreEgalite);
            this.Controls.Add(this.nombreDefaite);
            this.Controls.Add(this.nombreVictoire);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.replay);
            this.Controls.Add(this.case8);
            this.Controls.Add(this.case7);
            this.Controls.Add(this.case6);
            this.Controls.Add(this.case5);
            this.Controls.Add(this.case4);
            this.Controls.Add(this.case3);
            this.Controls.Add(this.case2);
            this.Controls.Add(this.case1);
            this.Controls.Add(this.case0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label case0;
        private System.Windows.Forms.Label case1;
        private System.Windows.Forms.Label case2;
        private System.Windows.Forms.Label case3;
        private System.Windows.Forms.Label case4;
        private System.Windows.Forms.Label case5;
        private System.Windows.Forms.Label case6;
        private System.Windows.Forms.Label case7;
        private System.Windows.Forms.Label case8;
        private System.Windows.Forms.Button replay;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nombreVictoire;
        private System.Windows.Forms.Label nombreDefaite;
        private System.Windows.Forms.Label nombreEgalite;
    }
}

