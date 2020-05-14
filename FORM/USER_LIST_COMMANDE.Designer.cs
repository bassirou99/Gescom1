namespace GESCOM.FORM
{
    partial class USER_LIST_COMMANDE
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.profilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gESCOMDataSet = new GESCOM.GESCOMDataSet();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.profilTableAdapter = new GESCOM.GESCOMDataSetTableAdapters.ProfilTableAdapter();
            this.dvgArticle = new System.Windows.Forms.DataGridView();
            this.ID_Article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reference_Article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libelle_Article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock_Article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix_Article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_Catégorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.txtSck = new System.Windows.Forms.Label();
            this.txtStk = new System.Windows.Forms.TextBox();
            this.txtLbl = new System.Windows.Forms.Label();
            this.txtLib = new System.Windows.Forms.TextBox();
            this.txtRef = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESCOMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgArticle)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(682, 214);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 29);
            this.button3.TabIndex = 88;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(722, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 87;
            this.label9.Text = "Qte Stock";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox6.Location = new System.Drawing.Point(790, 269);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(112, 25);
            this.textBox6.TabIndex = 86;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(540, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 17);
            this.label10.TabIndex = 85;
            this.label10.Text = "Qte Com";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox7.Location = new System.Drawing.Point(606, 268);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(112, 25);
            this.textBox7.TabIndex = 84;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(375, 277);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 17);
            this.label11.TabIndex = 83;
            this.label11.Text = "Libellé";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox8.Location = new System.Drawing.Point(428, 269);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(109, 25);
            this.textBox8.TabIndex = 82;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(374, 224);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 17);
            this.label12.TabIndex = 81;
            this.label12.Text = "Référence";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox9.Location = new System.Drawing.Point(454, 216);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(150, 28);
            this.textBox9.TabIndex = 80;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(682, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 29);
            this.button2.TabIndex = 79;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(722, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 78;
            this.label8.Text = "Adresse";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox5.Location = new System.Drawing.Point(789, 145);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(112, 25);
            this.textBox5.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(533, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 76;
            this.label6.Text = "Prenom";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox3.Location = new System.Drawing.Point(596, 144);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(112, 25);
            this.textBox3.TabIndex = 75;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(375, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 74;
            this.label7.Text = "Nom";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox4.Location = new System.Drawing.Point(418, 145);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(109, 25);
            this.textBox4.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 72;
            this.label4.Text = "Telephone";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.Location = new System.Drawing.Point(454, 92);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 28);
            this.textBox2.TabIndex = 71;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(827, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 29);
            this.button1.TabIndex = 70;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(454, 42);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 22);
            this.dateTimePicker1.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 68;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 67;
            this.label2.Text = "Numéro";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(454, 9);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 25);
            this.textBox1.TabIndex = 66;
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
            this.txtLog.Location = new System.Drawing.Point(94, 134);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(239, 36);
            this.txtLog.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.label1.Location = new System.Drawing.Point(72, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 55;
            this.label1.Text = "Enregistrement d\'un Client";
            // 
            // profilTableAdapter
            // 
            this.profilTableAdapter.ClearBeforeFill = true;
            // 
            // dvgArticle
            // 
            this.dvgArticle.AutoGenerateColumns = false;
            this.dvgArticle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgArticle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Article,
            this.Reference_Article,
            this.Libelle_Article,
            this.Stock_Article,
            this.Prix_Article,
            this.Nom_Catégorie});
            this.dvgArticle.DataSource = this.gESCOMDataSet;
            this.dvgArticle.EnableHeadersVisualStyles = false;
            this.dvgArticle.Location = new System.Drawing.Point(409, 357);
            this.dvgArticle.Name = "dvgArticle";
            this.dvgArticle.RowHeadersVisible = false;
            this.dvgArticle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            this.dvgArticle.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dvgArticle.RowTemplate.Height = 24;
            this.dvgArticle.Size = new System.Drawing.Size(483, 192);
            this.dvgArticle.TabIndex = 58;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 65;
            this.label5.Text = "Adresse";
            // 
            // txtPrix
            // 
            this.txtPrix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrix.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPrix.Location = new System.Drawing.Point(94, 357);
            this.txtPrix.Multiline = true;
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(239, 36);
            this.txtPrix.TabIndex = 64;
            // 
            // txtSck
            // 
            this.txtSck.AutoSize = true;
            this.txtSck.Location = new System.Drawing.Point(14, 292);
            this.txtSck.Name = "txtSck";
            this.txtSck.Size = new System.Drawing.Size(76, 17);
            this.txtSck.TabIndex = 63;
            this.txtSck.Text = "Telephone";
            // 
            // txtStk
            // 
            this.txtStk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtStk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStk.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtStk.Location = new System.Drawing.Point(94, 284);
            this.txtStk.Multiline = true;
            this.txtStk.Name = "txtStk";
            this.txtStk.Size = new System.Drawing.Size(239, 36);
            this.txtStk.TabIndex = 62;
            // 
            // txtLbl
            // 
            this.txtLbl.AutoSize = true;
            this.txtLbl.Location = new System.Drawing.Point(14, 216);
            this.txtLbl.Name = "txtLbl";
            this.txtLbl.Size = new System.Drawing.Size(57, 17);
            this.txtLbl.TabIndex = 61;
            this.txtLbl.Text = "Prenom";
            // 
            // txtLib
            // 
            this.txtLib.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtLib.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLib.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtLib.Location = new System.Drawing.Point(94, 208);
            this.txtLib.Multiline = true;
            this.txtLib.Name = "txtLib";
            this.txtLib.Size = new System.Drawing.Size(239, 36);
            this.txtLib.TabIndex = 60;
            // 
            // txtRef
            // 
            this.txtRef.AutoSize = true;
            this.txtRef.Location = new System.Drawing.Point(14, 142);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(37, 17);
            this.txtRef.TabIndex = 59;
            this.txtRef.Text = "Nom";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(219, 421);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 31);
            this.btnSave.TabIndex = 57;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // USER_LIST_COMMANDE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvgArticle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.txtSck);
            this.Controls.Add(this.txtStk);
            this.Controls.Add(this.txtLbl);
            this.Controls.Add(this.txtLib);
            this.Controls.Add(this.txtRef);
            this.Controls.Add(this.btnSave);
            this.Name = "USER_LIST_COMMANDE";
            this.Size = new System.Drawing.Size(916, 633);
            this.Load += new System.EventHandler(this.USER_LIST_COMMANDE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESCOMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgArticle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource profilBindingSource;
        private GESCOMDataSet gESCOMDataSet;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label1;
        private GESCOMDataSetTableAdapters.ProfilTableAdapter profilTableAdapter;
        private System.Windows.Forms.DataGridView dvgArticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Article;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference_Article;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libelle_Article;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock_Article;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix_Article;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_Catégorie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.Label txtSck;
        private System.Windows.Forms.TextBox txtStk;
        private System.Windows.Forms.Label txtLbl;
        private System.Windows.Forms.TextBox txtLib;
        private System.Windows.Forms.Label txtRef;
        private System.Windows.Forms.Button btnSave;
    }
}
