namespace GestionDeStock
{
    partial class TableauFournisseurs
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
            this.labelTypeConnexion = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonStocks = new System.Windows.Forms.Button();
            this.textBoxNomFournisseur = new System.Windows.Forms.TextBox();
            this.textBoxAdresseFournisseur = new System.Windows.Forms.TextBox();
            this.textBoxCPFournisseur = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVilleFournisseur = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTypeConnexion
            // 
            this.labelTypeConnexion.AutoSize = true;
            this.labelTypeConnexion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeConnexion.Location = new System.Drawing.Point(820, 14);
            this.labelTypeConnexion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTypeConnexion.Name = "labelTypeConnexion";
            this.labelTypeConnexion.Size = new System.Drawing.Size(223, 16);
            this.labelTypeConnexion.TabIndex = 82;
            this.labelTypeConnexion.Text = "Vous êtes connecté en tant que : ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Navy;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(13, 44);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(1129, 56);
            this.button2.TabIndex = 63;
            this.button2.Text = "Tableau Récapitulatif de Fournisseurs";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.BackColor = System.Drawing.Color.Green;
            this.buttonAjouter.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouter.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonAjouter.Location = new System.Drawing.Point(207, 430);
            this.buttonAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(199, 56);
            this.buttonAjouter.TabIndex = 4;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(840, 531);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 56);
            this.button1.TabIndex = 8;
            this.button1.Text = "Déconnexion";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // buttonModifier
            // 
            this.buttonModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonModifier.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifier.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonModifier.Location = new System.Drawing.Point(414, 430);
            this.buttonModifier.Margin = new System.Windows.Forms.Padding(4);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(199, 56);
            this.buttonModifier.TabIndex = 5;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = false;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.BackColor = System.Drawing.Color.Maroon;
            this.buttonSupprimer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimer.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonSupprimer.Location = new System.Drawing.Point(621, 430);
            this.buttonSupprimer.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(194, 56);
            this.buttonSupprimer.TabIndex = 6;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            // 
            // buttonStocks
            // 
            this.buttonStocks.BackColor = System.Drawing.Color.Navy;
            this.buttonStocks.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStocks.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonStocks.Location = new System.Drawing.Point(13, 531);
            this.buttonStocks.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStocks.Name = "buttonStocks";
            this.buttonStocks.Size = new System.Drawing.Size(196, 56);
            this.buttonStocks.TabIndex = 7;
            this.buttonStocks.Text = "Fournisseurs";
            this.buttonStocks.UseVisualStyleBackColor = false;
            // 
            // textBoxNomFournisseur
            // 
            this.textBoxNomFournisseur.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxNomFournisseur.Location = new System.Drawing.Point(138, 234);
            this.textBoxNomFournisseur.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNomFournisseur.MaxLength = 45;
            this.textBoxNomFournisseur.Name = "textBoxNomFournisseur";
            this.textBoxNomFournisseur.Size = new System.Drawing.Size(285, 23);
            this.textBoxNomFournisseur.TabIndex = 0;
            // 
            // textBoxAdresseFournisseur
            // 
            this.textBoxAdresseFournisseur.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdresseFournisseur.Location = new System.Drawing.Point(138, 284);
            this.textBoxAdresseFournisseur.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAdresseFournisseur.MaxLength = 45;
            this.textBoxAdresseFournisseur.Name = "textBoxAdresseFournisseur";
            this.textBoxAdresseFournisseur.Size = new System.Drawing.Size(537, 23);
            this.textBoxAdresseFournisseur.TabIndex = 1;
            // 
            // textBoxCPFournisseur
            // 
            this.textBoxCPFournisseur.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxCPFournisseur.Location = new System.Drawing.Point(138, 342);
            this.textBoxCPFournisseur.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCPFournisseur.MaxLength = 20;
            this.textBoxCPFournisseur.Name = "textBoxCPFournisseur";
            this.textBoxCPFournisseur.Size = new System.Drawing.Size(145, 23);
            this.textBoxCPFournisseur.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 393);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 87;
            this.label5.Text = "Ville";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 344);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 86;
            this.label4.Text = "Code Postal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 287);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 85;
            this.label3.Text = "Adresse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 238);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 84;
            this.label2.Text = "Nom";
            // 
            // textBoxVilleFournisseur
            // 
            this.textBoxVilleFournisseur.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxVilleFournisseur.Location = new System.Drawing.Point(138, 387);
            this.textBoxVilleFournisseur.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxVilleFournisseur.MaxLength = 45;
            this.textBoxVilleFournisseur.Name = "textBoxVilleFournisseur";
            this.textBoxVilleFournisseur.Size = new System.Drawing.Size(368, 23);
            this.textBoxVilleFournisseur.TabIndex = 3;
            // 
            // TableauFournisseurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 601);
            this.Controls.Add(this.textBoxNomFournisseur);
            this.Controls.Add(this.textBoxAdresseFournisseur);
            this.Controls.Add(this.textBoxCPFournisseur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxVilleFournisseur);
            this.Controls.Add(this.labelTypeConnexion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonStocks);
            this.Name = "TableauFournisseurs";
            this.Text = "Fournisseurs";
            this.Load += new System.EventHandler(this.TableauFournisseurs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTypeConnexion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonStocks;
        private System.Windows.Forms.TextBox textBoxNomFournisseur;
        private System.Windows.Forms.TextBox textBoxAdresseFournisseur;
        private System.Windows.Forms.TextBox textBoxCPFournisseur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxVilleFournisseur;
    }
}