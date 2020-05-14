namespace GESCOM.FORM
{
    partial class USER_LIST_PRODUIT
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.profilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gESCOMDataSet = new GESCOM.GESCOMDataSet();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.profilTableAdapter = new GESCOM.GESCOMDataSetTableAdapters.ProfilTableAdapter();
            this.dvgAricle = new System.Windows.Forms.DataGridView();
            this.ID_Article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reference_Article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libelle_Article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock_Article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix_Article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_Catégorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtRef = new System.Windows.Forms.Label();
            this.txtLbl = new System.Windows.Forms.Label();
            this.txtLib = new System.Windows.Forms.TextBox();
            this.txtSck = new System.Windows.Forms.Label();
            this.textSck = new System.Windows.Forms.TextBox();
            this.txtPrix = new System.Windows.Forms.Label();
            this.textPrix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combocategorie = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESCOMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAricle)).BeginInit();
            this.SuspendLayout();
            // 
            // profilBindingSource
            // 
            this.profilBindingSource.DataMember = "Profil";
            this.profilBindingSource.DataSource = this.gESCOMDataSet;
            // 
            // gESCOMDataSet
            // 
            this.gESCOMDataSet.DataSetName = "GESCOMDataSet";
            this.gESCOMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtLog.Location = new System.Drawing.Point(102, 143);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(239, 36);
            this.txtLog.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.label1.Location = new System.Drawing.Point(71, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Enregistrement d\'un Article";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // profilTableAdapter
            // 
            this.profilTableAdapter.ClearBeforeFill = true;
            // 
            // dvgAricle
            // 
            this.dvgAricle.AutoGenerateColumns = false;
            this.dvgAricle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgAricle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgAricle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Article,
            this.Reference_Article,
            this.Libelle_Article,
            this.Stock_Article,
            this.Prix_Article,
            this.Nom_Catégorie});
            this.dvgAricle.DataSource = this.gESCOMDataSet;
            this.dvgAricle.EnableHeadersVisualStyles = false;
            this.dvgAricle.Location = new System.Drawing.Point(408, 143);
            this.dvgAricle.Name = "dvgAricle";
            this.dvgAricle.RowHeadersVisible = false;
            this.dvgAricle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dvgAricle.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgAricle.RowTemplate.Height = 24;
            this.dvgAricle.Size = new System.Drawing.Size(483, 415);
            this.dvgAricle.TabIndex = 23;
            // 
            // ID_Article
            // 
            this.ID_Article.HeaderText = "ID_Article";
            this.ID_Article.Name = "ID_Article";
            // 
            // Reference_Article
            // 
            this.Reference_Article.HeaderText = "Reference";
            this.Reference_Article.Name = "Reference_Article";
            // 
            // Libelle_Article
            // 
            this.Libelle_Article.HeaderText = "Libelle";
            this.Libelle_Article.Name = "Libelle_Article";
            // 
            // Stock_Article
            // 
            this.Stock_Article.HeaderText = "Stock";
            this.Stock_Article.Name = "Stock_Article";
            // 
            // Prix_Article
            // 
            this.Prix_Article.HeaderText = "Prix";
            this.Prix_Article.Name = "Prix_Article";
            // 
            // Nom_Catégorie
            // 
            this.Nom_Catégorie.HeaderText = "Catégorie";
            this.Nom_Catégorie.Name = "Nom_Catégorie";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(137, 508);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(178, 50);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // txtRef
            // 
            this.txtRef.AutoSize = true;
            this.txtRef.Location = new System.Drawing.Point(22, 151);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(74, 17);
            this.txtRef.TabIndex = 24;
            this.txtRef.Text = "Référence";
            // 
            // txtLbl
            // 
            this.txtLbl.AutoSize = true;
            this.txtLbl.Location = new System.Drawing.Point(22, 225);
            this.txtLbl.Name = "txtLbl";
            this.txtLbl.Size = new System.Drawing.Size(49, 17);
            this.txtLbl.TabIndex = 26;
            this.txtLbl.Text = "Libellé";
            // 
            // txtLib
            // 
            this.txtLib.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtLib.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLib.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtLib.Location = new System.Drawing.Point(102, 217);
            this.txtLib.Multiline = true;
            this.txtLib.Name = "txtLib";
            this.txtLib.Size = new System.Drawing.Size(239, 36);
            this.txtLib.TabIndex = 25;
            // 
            // txtSck
            // 
            this.txtSck.AutoSize = true;
            this.txtSck.Location = new System.Drawing.Point(22, 301);
            this.txtSck.Name = "txtSck";
            this.txtSck.Size = new System.Drawing.Size(43, 17);
            this.txtSck.TabIndex = 28;
            this.txtSck.Text = "Stock";
            // 
            // textSck
            // 
            this.textSck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textSck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSck.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textSck.Location = new System.Drawing.Point(102, 293);
            this.textSck.Multiline = true;
            this.textSck.Name = "textSck";
            this.textSck.Size = new System.Drawing.Size(239, 36);
            this.textSck.TabIndex = 27;
            // 
            // txtPrix
            // 
            this.txtPrix.AutoSize = true;
            this.txtPrix.Location = new System.Drawing.Point(24, 374);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(31, 17);
            this.txtPrix.TabIndex = 30;
            this.txtPrix.Text = "Prix";
            // 
            // textPrix
            // 
            this.textPrix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrix.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textPrix.Location = new System.Drawing.Point(102, 366);
            this.textPrix.Multiline = true;
            this.textPrix.Name = "textPrix";
            this.textPrix.Size = new System.Drawing.Size(239, 36);
            this.textPrix.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.label2.Location = new System.Drawing.Point(513, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Liste des Articles";
            // 
            // combocategorie
            // 
            this.combocategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combocategorie.FormattingEnabled = true;
            this.combocategorie.Location = new System.Drawing.Point(102, 437);
            this.combocategorie.Name = "combocategorie";
            this.combocategorie.Size = new System.Drawing.Size(239, 24);
            this.combocategorie.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Catégorie";
            // 
            // USER_LIST_PRODUIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.textPrix);
            this.Controls.Add(this.txtSck);
            this.Controls.Add(this.textSck);
            this.Controls.Add(this.txtLbl);
            this.Controls.Add(this.txtLib);
            this.Controls.Add(this.txtRef);
            this.Controls.Add(this.combocategorie);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvgAricle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Name = "USER_LIST_PRODUIT";
            this.Size = new System.Drawing.Size(916, 633);
            this.Load += new System.EventHandler(this.USER_LIST_PRODUIT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESCOMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAricle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource profilBindingSource;
        private GESCOMDataSet gESCOMDataSet;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label1;
        private GESCOMDataSetTableAdapters.ProfilTableAdapter profilTableAdapter;
        private System.Windows.Forms.DataGridView dvgAricle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label txtRef;
        private System.Windows.Forms.Label txtLbl;
        private System.Windows.Forms.TextBox txtLib;
        private System.Windows.Forms.Label txtSck;
        private System.Windows.Forms.TextBox textSck;
        private System.Windows.Forms.Label txtPrix;
        private System.Windows.Forms.TextBox textPrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Article;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference_Article;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libelle_Article;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock_Article;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix_Article;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_Catégorie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combocategorie;
        private System.Windows.Forms.Label label3;
    }
}
