
namespace Gestiune_Coafor
{
    partial class Furnizori
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.finalContract_txtBox = new System.Windows.Forms.TextBox();
            this.pretBuc_txtBox = new System.Windows.Forms.TextBox();
            this.cantitate_txtBox = new System.Windows.Forms.TextBox();
            this.numeProdus_txtBox = new System.Windows.Forms.TextBox();
            this.d = new System.Windows.Forms.TextBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numefurnizorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produsefurnizorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locatieSediuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.furnizoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mFdbDataSet1 = new Gestiune_Coafor.MFdbDataSet1();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.furnizoriTableAdapter = new Gestiune_Coafor.MFdbDataSet1TableAdapters.FurnizoriTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnizoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mFdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(678, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 38;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(524, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 37;
            this.label4.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(398, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "Locatie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Produse furnizor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "Nume furnizor";
            // 
            // finalContract_txtBox
            // 
            this.finalContract_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalContract_txtBox.Location = new System.Drawing.Point(631, 40);
            this.finalContract_txtBox.Name = "finalContract_txtBox";
            this.finalContract_txtBox.Size = new System.Drawing.Size(146, 29);
            this.finalContract_txtBox.TabIndex = 32;
            // 
            // pretBuc_txtBox
            // 
            this.pretBuc_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretBuc_txtBox.Location = new System.Drawing.Point(476, 41);
            this.pretBuc_txtBox.Name = "pretBuc_txtBox";
            this.pretBuc_txtBox.Size = new System.Drawing.Size(149, 29);
            this.pretBuc_txtBox.TabIndex = 33;
            // 
            // cantitate_txtBox
            // 
            this.cantitate_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantitate_txtBox.Location = new System.Drawing.Point(379, 41);
            this.cantitate_txtBox.Name = "cantitate_txtBox";
            this.cantitate_txtBox.Size = new System.Drawing.Size(89, 29);
            this.cantitate_txtBox.TabIndex = 30;
            // 
            // numeProdus_txtBox
            // 
            this.numeProdus_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeProdus_txtBox.Location = new System.Drawing.Point(239, 42);
            this.numeProdus_txtBox.Name = "numeProdus_txtBox";
            this.numeProdus_txtBox.Size = new System.Drawing.Size(121, 29);
            this.numeProdus_txtBox.TabIndex = 29;
            // 
            // d
            // 
            this.d.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d.Location = new System.Drawing.Point(123, 40);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(101, 29);
            this.d.TabIndex = 28;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.Transparent;
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(832, 630);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(103, 102);
            this.back_btn.TabIndex = 26;
            this.back_btn.Text = "Inapoi";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Transparent;
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Location = new System.Drawing.Point(832, 438);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(103, 102);
            this.delete_btn.TabIndex = 25;
            this.delete_btn.Text = "Stergere";
            this.delete_btn.UseVisualStyleBackColor = false;
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.Transparent;
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.Location = new System.Drawing.Point(832, 244);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(103, 102);
            this.save_btn.TabIndex = 24;
            this.save_btn.Text = "Salvare";
            this.save_btn.UseVisualStyleBackColor = false;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.Transparent;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(832, 92);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(103, 102);
            this.add_btn.TabIndex = 23;
            this.add_btn.Text = "Adauga";
            this.add_btn.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numefurnizorDataGridViewTextBoxColumn,
            this.produsefurnizorDataGridViewTextBoxColumn,
            this.locatieSediuDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.furnizoriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 659);
            this.dataGridView1.TabIndex = 27;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // numefurnizorDataGridViewTextBoxColumn
            // 
            this.numefurnizorDataGridViewTextBoxColumn.DataPropertyName = "Nume_furnizor";
            this.numefurnizorDataGridViewTextBoxColumn.HeaderText = "Nume_furnizor";
            this.numefurnizorDataGridViewTextBoxColumn.Name = "numefurnizorDataGridViewTextBoxColumn";
            this.numefurnizorDataGridViewTextBoxColumn.Width = 125;
            // 
            // produsefurnizorDataGridViewTextBoxColumn
            // 
            this.produsefurnizorDataGridViewTextBoxColumn.DataPropertyName = "Produse_furnizor";
            this.produsefurnizorDataGridViewTextBoxColumn.HeaderText = "Produse_furnizor";
            this.produsefurnizorDataGridViewTextBoxColumn.Name = "produsefurnizorDataGridViewTextBoxColumn";
            this.produsefurnizorDataGridViewTextBoxColumn.Width = 125;
            // 
            // locatieSediuDataGridViewTextBoxColumn
            // 
            this.locatieSediuDataGridViewTextBoxColumn.DataPropertyName = "Locatie_Sediu";
            this.locatieSediuDataGridViewTextBoxColumn.HeaderText = "Locatie_Sediu";
            this.locatieSediuDataGridViewTextBoxColumn.Name = "locatieSediuDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // furnizoriBindingSource
            // 
            this.furnizoriBindingSource.DataMember = "Furnizori";
            this.furnizoriBindingSource.DataSource = this.mFdbDataSet1;
            // 
            // mFdbDataSet1
            // 
            this.mFdbDataSet1.DataSetName = "MFdbDataSet1";
            this.mFdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // refresh_btn
            // 
            this.refresh_btn.BackColor = System.Drawing.Color.Transparent;
            this.refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_btn.Location = new System.Drawing.Point(32, 12);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(73, 58);
            this.refresh_btn.TabIndex = 22;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = false;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // furnizoriTableAdapter
            // 
            this.furnizoriTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = (System.Drawing.Image)global::Gestiune_Coafor.Properties.Resources.logo_mada_no_ellipse2;
            this.pictureBox1.Location = new System.Drawing.Point(852, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // Furnizori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = (System.Drawing.Image)global::Gestiune_Coafor.Properties.Resources.background_mada;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(967, 745);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.finalContract_txtBox);
            this.Controls.Add(this.pretBuc_txtBox);
            this.Controls.Add(this.cantitate_txtBox);
            this.Controls.Add(this.numeProdus_txtBox);
            this.Controls.Add(this.d);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.refresh_btn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Furnizori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Furnizori";
            this.Load += new System.EventHandler(this.Furnizori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnizoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mFdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox finalContract_txtBox;
        private System.Windows.Forms.TextBox pretBuc_txtBox;
        private System.Windows.Forms.TextBox cantitate_txtBox;
        private System.Windows.Forms.TextBox numeProdus_txtBox;
        private System.Windows.Forms.TextBox d;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button refresh_btn;
        private MFdbDataSet1 mFdbDataSet1;
        private System.Windows.Forms.BindingSource furnizoriBindingSource;
        private MFdbDataSet1TableAdapters.FurnizoriTableAdapter furnizoriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numefurnizorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produsefurnizorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locatieSediuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}