namespace dataBinding_Banque
{
    partial class Compte
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
            this.label1 = new System.Windows.Forms.Label();
            this.NumCompte = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Solde = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Premier = new System.Windows.Forms.Button();
            this.Suivant = new System.Windows.Forms.Button();
            this.precedent = new System.Windows.Forms.Button();
            this.dernier = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Nouveau = new System.Windows.Forms.Button();
            this.NumClient = new System.Windows.Forms.ComboBox();
            this.TypeCompte = new System.Windows.Forms.ComboBox();
            this.compteDataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.compteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Num Compte";
            // 
            // NumCompte
            // 
            this.NumCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumCompte.Location = new System.Drawing.Point(179, 42);
            this.NumCompte.Name = "NumCompte";
            this.NumCompte.Size = new System.Drawing.Size(118, 22);
            this.NumCompte.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Num Client";
            // 
            // Solde
            // 
            this.Solde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Solde.Location = new System.Drawing.Point(179, 123);
            this.Solde.Name = "Solde";
            this.Solde.ReadOnly = true;
            this.Solde.Size = new System.Drawing.Size(118, 22);
            this.Solde.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Solde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Type Compte";
            // 
            // Premier
            // 
            this.Premier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Premier.Location = new System.Drawing.Point(402, 42);
            this.Premier.Name = "Premier";
            this.Premier.Size = new System.Drawing.Size(97, 23);
            this.Premier.TabIndex = 8;
            this.Premier.Text = "|<<";
            this.Premier.UseVisualStyleBackColor = true;
            this.Premier.Click += new System.EventHandler(this.Premier_Click);
            // 
            // Suivant
            // 
            this.Suivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suivant.Location = new System.Drawing.Point(402, 83);
            this.Suivant.Name = "Suivant";
            this.Suivant.Size = new System.Drawing.Size(97, 23);
            this.Suivant.TabIndex = 9;
            this.Suivant.Text = ">>";
            this.Suivant.UseVisualStyleBackColor = true;
            this.Suivant.Click += new System.EventHandler(this.Suivant_Click);
            // 
            // precedent
            // 
            this.precedent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precedent.Location = new System.Drawing.Point(402, 121);
            this.precedent.Name = "precedent";
            this.precedent.Size = new System.Drawing.Size(97, 23);
            this.precedent.TabIndex = 10;
            this.precedent.Text = "<<";
            this.precedent.UseVisualStyleBackColor = true;
            this.precedent.Click += new System.EventHandler(this.precedent_Click);
            // 
            // dernier
            // 
            this.dernier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dernier.Location = new System.Drawing.Point(402, 164);
            this.dernier.Name = "dernier";
            this.dernier.Size = new System.Drawing.Size(97, 23);
            this.dernier.TabIndex = 11;
            this.dernier.Text = ">>|";
            this.dernier.UseVisualStyleBackColor = true;
            this.dernier.Click += new System.EventHandler(this.dernier_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supprimer.Location = new System.Drawing.Point(561, 164);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(97, 23);
            this.Supprimer.TabIndex = 15;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Modifier
            // 
            this.Modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifier.Location = new System.Drawing.Point(561, 121);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(97, 23);
            this.Modifier.TabIndex = 14;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter.Location = new System.Drawing.Point(561, 83);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(97, 23);
            this.Ajouter.TabIndex = 13;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Nouveau
            // 
            this.Nouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nouveau.Location = new System.Drawing.Point(561, 42);
            this.Nouveau.Name = "Nouveau";
            this.Nouveau.Size = new System.Drawing.Size(97, 23);
            this.Nouveau.TabIndex = 12;
            this.Nouveau.Text = "Nouveau";
            this.Nouveau.UseVisualStyleBackColor = true;
            this.Nouveau.Click += new System.EventHandler(this.Nouveau_Click);
            // 
            // NumClient
            // 
            this.NumClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumClient.FormattingEnabled = true;
            this.NumClient.Location = new System.Drawing.Point(179, 80);
            this.NumClient.Name = "NumClient";
            this.NumClient.Size = new System.Drawing.Size(118, 24);
            this.NumClient.TabIndex = 16;
            // 
            // TypeCompte
            // 
            this.TypeCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeCompte.FormattingEnabled = true;
            this.TypeCompte.Items.AddRange(new object[] {
            "education",
            "prof"});
            this.TypeCompte.Location = new System.Drawing.Point(179, 166);
            this.TypeCompte.Name = "TypeCompte";
            this.TypeCompte.Size = new System.Drawing.Size(118, 24);
            this.TypeCompte.TabIndex = 17;
            // 
            // compteDataGridView
            // 
            this.compteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.compteDataGridView.Location = new System.Drawing.Point(77, 225);
            this.compteDataGridView.Name = "compteDataGridView";
            this.compteDataGridView.Size = new System.Drawing.Size(559, 150);
            this.compteDataGridView.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(313, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Gestion Comptes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 422);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.compteDataGridView);
            this.Controls.Add(this.TypeCompte);
            this.Controls.Add(this.NumClient);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.Nouveau);
            this.Controls.Add(this.dernier);
            this.Controls.Add(this.precedent);
            this.Controls.Add(this.Suivant);
            this.Controls.Add(this.Premier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Solde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumCompte);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.compteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumCompte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Solde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Premier;
        private System.Windows.Forms.Button Suivant;
        private System.Windows.Forms.Button precedent;
        private System.Windows.Forms.Button dernier;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Nouveau;
        private System.Windows.Forms.ComboBox NumClient;
        private System.Windows.Forms.ComboBox TypeCompte;
        private System.Windows.Forms.DataGridView compteDataGridView;
        private System.Windows.Forms.Label label5;
    }
}

