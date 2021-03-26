namespace GestionDeStock
{
    partial class TableauStock
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
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonFournisseurs = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxReferenceSociete = new System.Windows.Forms.TextBox();
            this.textBoxReferenceFournisseur = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelReferenceSociete = new System.Windows.Forms.Label();
            this.textBoxNomArticle = new System.Windows.Forms.TextBox();
            this.textBoxDecriptionArticle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNomArticle = new System.Windows.Forms.Label();
            this.textBoxEmplacement = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNomFournisseur = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxStockMini = new System.Windows.Forms.TextBox();
            this.textBoxStockMaxi = new System.Windows.Forms.TextBox();
            this.textBoxQuantite = new System.Windows.Forms.TextBox();
            this.labelTypeConnexion = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonModifier
            // 
            this.buttonModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonModifier.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifier.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonModifier.Location = new System.Drawing.Point(430, 495);
            this.buttonModifier.Margin = new System.Windows.Forms.Padding(4);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(199, 56);
            this.buttonModifier.TabIndex = 33;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = false;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.BackColor = System.Drawing.Color.Maroon;
            this.buttonSupprimer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimer.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonSupprimer.Location = new System.Drawing.Point(637, 495);
            this.buttonSupprimer.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(194, 56);
            this.buttonSupprimer.TabIndex = 32;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            // 
            // buttonFournisseurs
            // 
            this.buttonFournisseurs.BackColor = System.Drawing.Color.Navy;
            this.buttonFournisseurs.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFournisseurs.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonFournisseurs.Location = new System.Drawing.Point(29, 596);
            this.buttonFournisseurs.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFournisseurs.Name = "buttonFournisseurs";
            this.buttonFournisseurs.Size = new System.Drawing.Size(196, 56);
            this.buttonFournisseurs.TabIndex = 31;
            this.buttonFournisseurs.Text = "Fournisseurs";
            this.buttonFournisseurs.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(856, 596);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 56);
            this.button1.TabIndex = 34;
            this.button1.Text = "Déconnexion";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.BackColor = System.Drawing.Color.Green;
            this.buttonAjouter.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouter.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonAjouter.Location = new System.Drawing.Point(223, 495);
            this.buttonAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(199, 56);
            this.buttonAjouter.TabIndex = 35;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Navy;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(12, 49);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(1129, 56);
            this.button2.TabIndex = 37;
            this.button2.Text = "Tableau Récapitulatif de Gestion des Stocks";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBoxReferenceSociete
            // 
            this.textBoxReferenceSociete.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxReferenceSociete.Location = new System.Drawing.Point(162, 357);
            this.textBoxReferenceSociete.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxReferenceSociete.MaxLength = 8;
            this.textBoxReferenceSociete.Name = "textBoxReferenceSociete";
            this.textBoxReferenceSociete.Size = new System.Drawing.Size(92, 23);
            this.textBoxReferenceSociete.TabIndex = 41;
            // 
            // textBoxReferenceFournisseur
            // 
            this.textBoxReferenceFournisseur.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReferenceFournisseur.Location = new System.Drawing.Point(796, 437);
            this.textBoxReferenceFournisseur.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxReferenceFournisseur.MaxLength = 20;
            this.textBoxReferenceFournisseur.Name = "textBoxReferenceFournisseur";
            this.textBoxReferenceFournisseur.Size = new System.Drawing.Size(129, 23);
            this.textBoxReferenceFournisseur.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(639, 440);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Référence Fournisseur";
            // 
            // labelReferenceSociete
            // 
            this.labelReferenceSociete.AutoSize = true;
            this.labelReferenceSociete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReferenceSociete.Location = new System.Drawing.Point(30, 360);
            this.labelReferenceSociete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReferenceSociete.Name = "labelReferenceSociete";
            this.labelReferenceSociete.Size = new System.Drawing.Size(124, 16);
            this.labelReferenceSociete.TabIndex = 38;
            this.labelReferenceSociete.Text = "Référence Société";
            // 
            // textBoxNomArticle
            // 
            this.textBoxNomArticle.CausesValidation = false;
            this.textBoxNomArticle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxNomArticle.Location = new System.Drawing.Point(358, 357);
            this.textBoxNomArticle.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNomArticle.MaxLength = 8;
            this.textBoxNomArticle.Name = "textBoxNomArticle";
            this.textBoxNomArticle.Size = new System.Drawing.Size(238, 23);
            this.textBoxNomArticle.TabIndex = 45;
            // 
            // textBoxDecriptionArticle
            // 
            this.textBoxDecriptionArticle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDecriptionArticle.Location = new System.Drawing.Point(162, 396);
            this.textBoxDecriptionArticle.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDecriptionArticle.MaxLength = 120;
            this.textBoxDecriptionArticle.Name = "textBoxDecriptionArticle";
            this.textBoxDecriptionArticle.Size = new System.Drawing.Size(578, 23);
            this.textBoxDecriptionArticle.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 399);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Description";
            // 
            // labelNomArticle
            // 
            this.labelNomArticle.AutoSize = true;
            this.labelNomArticle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomArticle.Location = new System.Drawing.Point(274, 360);
            this.labelNomArticle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomArticle.Name = "labelNomArticle";
            this.labelNomArticle.Size = new System.Drawing.Size(85, 16);
            this.labelNomArticle.TabIndex = 42;
            this.labelNomArticle.Text = "Nom Article";
            // 
            // textBoxEmplacement
            // 
            this.textBoxEmplacement.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmplacement.Location = new System.Drawing.Point(994, 357);
            this.textBoxEmplacement.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmplacement.MaxLength = 6;
            this.textBoxEmplacement.Name = "textBoxEmplacement";
            this.textBoxEmplacement.Size = new System.Drawing.Size(56, 23);
            this.textBoxEmplacement.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(889, 360);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 48;
            this.label2.Text = "Emplacement";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(756, 400);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 49;
            this.label4.Text = "Stock Mini";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(907, 400);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 50;
            this.label5.Text = "Stock Maxi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(612, 360);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 51;
            this.label6.Text = "Quantité";
            // 
            // textBoxNomFournisseur
            // 
            this.textBoxNomFournisseur.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxNomFournisseur.Location = new System.Drawing.Point(162, 434);
            this.textBoxNomFournisseur.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNomFournisseur.MaxLength = 45;
            this.textBoxNomFournisseur.Name = "textBoxNomFournisseur";
            this.textBoxNomFournisseur.Size = new System.Drawing.Size(455, 23);
            this.textBoxNomFournisseur.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 437);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 52;
            this.label7.Text = "Fournisseur";
            // 
            // textBoxStockMini
            // 
            this.textBoxStockMini.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStockMini.Location = new System.Drawing.Point(839, 396);
            this.textBoxStockMini.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStockMini.MaxLength = 6;
            this.textBoxStockMini.Name = "textBoxStockMini";
            this.textBoxStockMini.Size = new System.Drawing.Size(56, 23);
            this.textBoxStockMini.TabIndex = 54;
            // 
            // textBoxStockMaxi
            // 
            this.textBoxStockMaxi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStockMaxi.Location = new System.Drawing.Point(994, 397);
            this.textBoxStockMaxi.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStockMaxi.MaxLength = 6;
            this.textBoxStockMaxi.Name = "textBoxStockMaxi";
            this.textBoxStockMaxi.Size = new System.Drawing.Size(56, 23);
            this.textBoxStockMaxi.TabIndex = 55;
            // 
            // textBoxQuantite
            // 
            this.textBoxQuantite.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuantite.Location = new System.Drawing.Point(684, 357);
            this.textBoxQuantite.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxQuantite.MaxLength = 6;
            this.textBoxQuantite.Name = "textBoxQuantite";
            this.textBoxQuantite.Size = new System.Drawing.Size(56, 23);
            this.textBoxQuantite.TabIndex = 56;
            // 
            // labelTypeConnexion
            // 
            this.labelTypeConnexion.AutoSize = true;
            this.labelTypeConnexion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeConnexion.Location = new System.Drawing.Point(819, 19);
            this.labelTypeConnexion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTypeConnexion.Name = "labelTypeConnexion";
            this.labelTypeConnexion.Size = new System.Drawing.Size(223, 16);
            this.labelTypeConnexion.TabIndex = 57;
            this.labelTypeConnexion.Text = "Vous êtes connecté en tant que : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1128, 237);
            this.dataGridView1.TabIndex = 58;
            // 
            // TableauStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1154, 658);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelTypeConnexion);
            this.Controls.Add(this.textBoxQuantite);
            this.Controls.Add(this.textBoxStockMaxi);
            this.Controls.Add(this.textBoxStockMini);
            this.Controls.Add(this.textBoxNomFournisseur);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEmplacement);
            this.Controls.Add(this.textBoxNomArticle);
            this.Controls.Add(this.textBoxDecriptionArticle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNomArticle);
            this.Controls.Add(this.textBoxReferenceSociete);
            this.Controls.Add(this.textBoxReferenceFournisseur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelReferenceSociete);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonFournisseurs);
            this.Name = "TableauStock";
            this.Text = "Fournisseurs";
            this.Load += new System.EventHandler(this.FormStocks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonFournisseurs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxReferenceSociete;
        private System.Windows.Forms.TextBox textBoxReferenceFournisseur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelReferenceSociete;
        private System.Windows.Forms.TextBox textBoxNomArticle;
        private System.Windows.Forms.TextBox textBoxDecriptionArticle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNomArticle;
        private System.Windows.Forms.TextBox textBoxEmplacement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNomFournisseur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxStockMini;
        private System.Windows.Forms.TextBox textBoxStockMaxi;
        private System.Windows.Forms.TextBox textBoxQuantite;
        private System.Windows.Forms.Label labelTypeConnexion;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}