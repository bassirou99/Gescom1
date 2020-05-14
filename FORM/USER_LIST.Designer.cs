namespace GESCOM.FORM
{
    partial class USER_LIST
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
            this.comboprofil = new System.Windows.Forms.ComboBox();
            this.profilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gESCOMDataSet = new GESCOM.GESCOMDataSet();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtmdp = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.profilTableAdapter = new GESCOM.GESCOMDataSetTableAdapters.ProfilTableAdapter();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dvgUser = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.profilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESCOMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUser)).BeginInit();
            this.SuspendLayout();
            // 
            // comboprofil
            // 
            this.comboprofil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboprofil.FormattingEnabled = true;
            this.comboprofil.Location = new System.Drawing.Point(98, 442);
            this.comboprofil.Name = "comboprofil";
            this.comboprofil.Size = new System.Drawing.Size(239, 24);
            this.comboprofil.TabIndex = 11;
            this.comboprofil.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // profilBindingSource
            // 
            this.profilBindingSource.DataMember = "Profil";
            this.profilBindingSource.DataSource = this.gESCOMDataSet;
            this.profilBindingSource.CurrentChanged += new System.EventHandler(this.profilBindingSource_CurrentChanged);
            // 
            // gESCOMDataSet
            // 
            this.gESCOMDataSet.DataSetName = "GESCOMDataSet";
            this.gESCOMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPrenom
            // 
            this.txtPrenom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPrenom.Location = new System.Drawing.Point(98, 370);
            this.txtPrenom.Multiline = true;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(239, 36);
            this.txtPrenom.TabIndex = 10;
            this.txtPrenom.Text = "Entrer Votre Prenom";
            this.txtPrenom.TextChanged += new System.EventHandler(this.txtPrenom_TextChanged);
            this.txtPrenom.Enter += new System.EventHandler(this.txtPrenom_Enter);
            this.txtPrenom.Leave += new System.EventHandler(this.txtPrenom_Leave);
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNom.Location = new System.Drawing.Point(98, 295);
            this.txtNom.Multiline = true;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(239, 36);
            this.txtNom.TabIndex = 9;
            this.txtNom.Text = "Entrer Votre Nom";
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            this.txtNom.Enter += new System.EventHandler(this.txtNom_Enter);
            this.txtNom.Leave += new System.EventHandler(this.txtNom_Leave);
            // 
            // txtmdp
            // 
            this.txtmdp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtmdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmdp.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtmdp.Location = new System.Drawing.Point(98, 220);
            this.txtmdp.Multiline = true;
            this.txtmdp.Name = "txtmdp";
            this.txtmdp.Size = new System.Drawing.Size(239, 36);
            this.txtmdp.TabIndex = 8;
            this.txtmdp.Text = "Entrer Votre Mot de Passe";
            this.txtmdp.TextChanged += new System.EventHandler(this.txtmdp_TextChanged);
            this.txtmdp.Enter += new System.EventHandler(this.txtmdp_Enter);
            this.txtmdp.Leave += new System.EventHandler(this.txtmdp_Leave);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtLog.Location = new System.Drawing.Point(98, 148);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(239, 36);
            this.txtLog.TabIndex = 7;
            this.txtLog.Text = "Entrer Votre Login";
            this.txtLog.TextChanged += new System.EventHandler(this.txtLog_TextChanged);
            this.txtLog.Enter += new System.EventHandler(this.txtLog_Enter);
            this.txtLog.Leave += new System.EventHandler(this.txtLog_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.label1.Location = new System.Drawing.Point(93, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enregistrement d\'un USER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // profilTableAdapter
            // 
            this.profilTableAdapter.ClearBeforeFill = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(159, 513);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(178, 50);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.label2.Location = new System.Drawing.Point(535, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Liste des USERS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dvgUser
            // 
            this.dvgUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dvgUser.EnableHeadersVisualStyles = false;
            this.dvgUser.Location = new System.Drawing.Point(430, 148);
            this.dvgUser.Name = "dvgUser";
            this.dvgUser.RowHeadersVisible = false;
            this.dvgUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dvgUser.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgUser.RowTemplate.Height = 24;
            this.dvgUser.Size = new System.Drawing.Size(438, 415);
            this.dvgUser.TabIndex = 14;
            this.dvgUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgUser_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Login";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "MDP";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nom";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Prenom";
            this.Column4.Name = "Column4";
            // 
            // USER_LIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dvgUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.comboprofil);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtmdp);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.label1);
            this.Name = "USER_LIST";
            this.Size = new System.Drawing.Size(916, 633);
            this.Load += new System.EventHandler(this.USER_LIST_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESCOMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboprofil;
        private System.Windows.Forms.BindingSource profilBindingSource;
        private GESCOMDataSet gESCOMDataSet;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtmdp;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label1;
        private GESCOMDataSetTableAdapters.ProfilTableAdapter profilTableAdapter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dvgUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
