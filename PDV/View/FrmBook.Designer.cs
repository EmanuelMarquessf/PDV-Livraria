
namespace PDV.View
{
    partial class FrmBook
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.nmcQuant = new System.Windows.Forms.NumericUpDown();
            this.LblQuant = new System.Windows.Forms.Label();
            this.txbIsbn = new System.Windows.Forms.TextBox();
            this.txbValue = new System.Windows.Forms.TextBox();
            this.LblValue = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTitle = new System.Windows.Forms.TextBox();
            this.txbYear = new System.Windows.Forms.TextBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblPages = new System.Windows.Forms.Label();
            this.lblCover = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.txbAuthor = new System.Windows.Forms.TextBox();
            this.cbbCover = new System.Windows.Forms.ComboBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.txbCompany = new System.Windows.Forms.TextBox();
            this.txbLanguage = new System.Windows.Forms.TextBox();
            this.nmcPages = new System.Windows.Forms.NumericUpDown();
            this.txbGender = new System.Windows.Forms.TextBox();
            this.lblEdition = new System.Windows.Forms.Label();
            this.txbEdition = new System.Windows.Forms.TextBox();
            this.nmcVolume = new System.Windows.Forms.NumericUpDown();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcQuant)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcVolume)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblIsbn);
            this.panel2.Controls.Add(this.nmcQuant);
            this.panel2.Controls.Add(this.LblQuant);
            this.panel2.Controls.Add(this.txbIsbn);
            this.panel2.Controls.Add(this.txbValue);
            this.panel2.Controls.Add(this.LblValue);
            this.panel2.Location = new System.Drawing.Point(0, 325);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(917, 93);
            this.panel2.TabIndex = 74;
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsbn.Location = new System.Drawing.Point(20, 3);
            this.lblIsbn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(68, 25);
            this.lblIsbn.TabIndex = 55;
            this.lblIsbn.Text = "ISBN*";
            // 
            // nmcQuant
            // 
            this.nmcQuant.BackColor = System.Drawing.Color.LightCyan;
            this.nmcQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmcQuant.Location = new System.Drawing.Point(786, 30);
            this.nmcQuant.Margin = new System.Windows.Forms.Padding(2);
            this.nmcQuant.Name = "nmcQuant";
            this.nmcQuant.Size = new System.Drawing.Size(118, 38);
            this.nmcQuant.TabIndex = 13;
            // 
            // LblQuant
            // 
            this.LblQuant.AutoSize = true;
            this.LblQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuant.Location = new System.Drawing.Point(792, 3);
            this.LblQuant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblQuant.Name = "LblQuant";
            this.LblQuant.Size = new System.Drawing.Size(54, 25);
            this.LblQuant.TabIndex = 37;
            this.LblQuant.Text = "Qtd*";
            // 
            // txbIsbn
            // 
            this.txbIsbn.BackColor = System.Drawing.Color.LightCyan;
            this.txbIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIsbn.Location = new System.Drawing.Point(8, 30);
            this.txbIsbn.Margin = new System.Windows.Forms.Padding(2);
            this.txbIsbn.Name = "txbIsbn";
            this.txbIsbn.Size = new System.Drawing.Size(443, 38);
            this.txbIsbn.TabIndex = 11;
            // 
            // txbValue
            // 
            this.txbValue.BackColor = System.Drawing.Color.LightCyan;
            this.txbValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbValue.Location = new System.Drawing.Point(470, 30);
            this.txbValue.Margin = new System.Windows.Forms.Padding(2);
            this.txbValue.Name = "txbValue";
            this.txbValue.Size = new System.Drawing.Size(300, 38);
            this.txbValue.TabIndex = 12;
            // 
            // LblValue
            // 
            this.LblValue.AutoSize = true;
            this.LblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValue.Location = new System.Drawing.Point(465, 3);
            this.LblValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblValue.Name = "LblValue";
            this.LblValue.Size = new System.Drawing.Size(70, 25);
            this.LblValue.TabIndex = 40;
            this.LblValue.Text = "Valor*";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.btnCancel.Location = new System.Drawing.Point(9, 443);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 40);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.btnSave.Location = new System.Drawing.Point(770, 443);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 40);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Cadastrar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbTitle);
            this.panel1.Controls.Add(this.txbYear);
            this.panel1.Controls.Add(this.LblDescription);
            this.panel1.Controls.Add(this.lblAuthor);
            this.panel1.Controls.Add(this.lblPages);
            this.panel1.Controls.Add(this.lblCover);
            this.panel1.Controls.Add(this.lblGender);
            this.panel1.Controls.Add(this.lblVolume);
            this.panel1.Controls.Add(this.lblLanguage);
            this.panel1.Controls.Add(this.txbAuthor);
            this.panel1.Controls.Add(this.cbbCover);
            this.panel1.Controls.Add(this.lblCompany);
            this.panel1.Controls.Add(this.txbCompany);
            this.panel1.Controls.Add(this.txbLanguage);
            this.panel1.Controls.Add(this.nmcPages);
            this.panel1.Controls.Add(this.txbGender);
            this.panel1.Controls.Add(this.lblEdition);
            this.panel1.Controls.Add(this.txbEdition);
            this.panel1.Controls.Add(this.nmcVolume);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 248);
            this.panel1.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(435, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 61;
            this.label1.Text = "Ano";
            // 
            // txbTitle
            // 
            this.txbTitle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txbTitle.BackColor = System.Drawing.Color.LightCyan;
            this.txbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txbTitle.Location = new System.Drawing.Point(15, 32);
            this.txbTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txbTitle.Name = "txbTitle";
            this.txbTitle.Size = new System.Drawing.Size(573, 38);
            this.txbTitle.TabIndex = 1;
            // 
            // txbYear
            // 
            this.txbYear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txbYear.Location = new System.Drawing.Point(440, 99);
            this.txbYear.Margin = new System.Windows.Forms.Padding(2);
            this.txbYear.Name = "txbYear";
            this.txbYear.Size = new System.Drawing.Size(126, 38);
            this.txbYear.TabIndex = 5;
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescription.Location = new System.Drawing.Point(18, 5);
            this.LblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(73, 25);
            this.LblDescription.TabIndex = 36;
            this.LblDescription.Text = "Titulo*";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(606, 5);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(63, 25);
            this.lblAuthor.TabIndex = 43;
            this.lblAuthor.Text = "Autor";
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPages.Location = new System.Drawing.Point(826, 139);
            this.lblPages.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(50, 25);
            this.lblPages.TabIndex = 47;
            this.lblPages.Text = "Pag";
            // 
            // lblCover
            // 
            this.lblCover.AutoSize = true;
            this.lblCover.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCover.Location = new System.Drawing.Point(434, 139);
            this.lblCover.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCover.Name = "lblCover";
            this.lblCover.Size = new System.Drawing.Size(63, 25);
            this.lblCover.TabIndex = 58;
            this.lblCover.Text = "Capa";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(569, 72);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(83, 25);
            this.lblGender.TabIndex = 49;
            this.lblGender.Text = "Gênero";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.Location = new System.Drawing.Point(292, 139);
            this.lblVolume.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(84, 25);
            this.lblVolume.TabIndex = 51;
            this.lblVolume.Text = "Volume";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguage.Location = new System.Drawing.Point(18, 139);
            this.lblLanguage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(75, 25);
            this.lblLanguage.TabIndex = 57;
            this.lblLanguage.Text = "Idioma";
            // 
            // txbAuthor
            // 
            this.txbAuthor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txbAuthor.Location = new System.Drawing.Point(605, 32);
            this.txbAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.txbAuthor.Name = "txbAuthor";
            this.txbAuthor.Size = new System.Drawing.Size(283, 38);
            this.txbAuthor.TabIndex = 2;
            // 
            // cbbCover
            // 
            this.cbbCover.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbbCover.BackColor = System.Drawing.Color.LightCyan;
            this.cbbCover.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCover.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cbbCover.FormattingEnabled = true;
            this.cbbCover.Items.AddRange(new object[] {
            "Comum",
            "Dura"});
            this.cbbCover.Location = new System.Drawing.Point(440, 165);
            this.cbbCover.Name = "cbbCover";
            this.cbbCover.Size = new System.Drawing.Size(384, 39);
            this.cbbCover.TabIndex = 9;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(18, 72);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(80, 25);
            this.lblCompany.TabIndex = 45;
            this.lblCompany.Text = "Editora";
            // 
            // txbCompany
            // 
            this.txbCompany.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txbCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txbCompany.Location = new System.Drawing.Point(15, 99);
            this.txbCompany.Margin = new System.Windows.Forms.Padding(2);
            this.txbCompany.Name = "txbCompany";
            this.txbCompany.Size = new System.Drawing.Size(198, 38);
            this.txbCompany.TabIndex = 3;
            // 
            // txbLanguage
            // 
            this.txbLanguage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txbLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txbLanguage.Location = new System.Drawing.Point(15, 166);
            this.txbLanguage.Margin = new System.Windows.Forms.Padding(2);
            this.txbLanguage.Name = "txbLanguage";
            this.txbLanguage.Size = new System.Drawing.Size(271, 38);
            this.txbLanguage.TabIndex = 7;
            // 
            // nmcPages
            // 
            this.nmcPages.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nmcPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.nmcPages.Location = new System.Drawing.Point(837, 166);
            this.nmcPages.Margin = new System.Windows.Forms.Padding(2);
            this.nmcPages.Name = "nmcPages";
            this.nmcPages.Size = new System.Drawing.Size(51, 38);
            this.nmcPages.TabIndex = 10;
            // 
            // txbGender
            // 
            this.txbGender.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txbGender.Location = new System.Drawing.Point(580, 99);
            this.txbGender.Margin = new System.Windows.Forms.Padding(2);
            this.txbGender.Name = "txbGender";
            this.txbGender.Size = new System.Drawing.Size(308, 38);
            this.txbGender.TabIndex = 6;
            // 
            // lblEdition
            // 
            this.lblEdition.AutoSize = true;
            this.lblEdition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdition.Location = new System.Drawing.Point(217, 72);
            this.lblEdition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEdition.Name = "lblEdition";
            this.lblEdition.Size = new System.Drawing.Size(78, 25);
            this.lblEdition.TabIndex = 53;
            this.lblEdition.Text = "Edição";
            // 
            // txbEdition
            // 
            this.txbEdition.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txbEdition.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txbEdition.Location = new System.Drawing.Point(222, 99);
            this.txbEdition.Margin = new System.Windows.Forms.Padding(2);
            this.txbEdition.Name = "txbEdition";
            this.txbEdition.Size = new System.Drawing.Size(204, 38);
            this.txbEdition.TabIndex = 4;
            // 
            // nmcVolume
            // 
            this.nmcVolume.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nmcVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.nmcVolume.Location = new System.Drawing.Point(303, 166);
            this.nmcVolume.Margin = new System.Windows.Forms.Padding(2);
            this.nmcVolume.Name = "nmcVolume";
            this.nmcVolume.Size = new System.Drawing.Size(123, 38);
            this.nmcVolume.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.btnClear.Location = new System.Drawing.Point(381, 443);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(155, 40);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "F1 - Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Black;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.label3);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(932, 51);
            this.pnlTop.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(361, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 29);
            this.label3.TabIndex = 35;
            this.label3.Text = "Cadastrar Livro";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(917, 494);
            this.panel3.TabIndex = 64;
            // 
            // FrmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(917, 494);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de livro";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmBook_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcQuant)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcVolume)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.NumericUpDown nmcQuant;
        private System.Windows.Forms.Label LblQuant;
        private System.Windows.Forms.TextBox txbIsbn;
        private System.Windows.Forms.TextBox txbValue;
        private System.Windows.Forms.Label LblValue;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTitle;
        private System.Windows.Forms.TextBox txbYear;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Label lblCover;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.TextBox txbAuthor;
        private System.Windows.Forms.ComboBox cbbCover;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.TextBox txbCompany;
        private System.Windows.Forms.TextBox txbLanguage;
        private System.Windows.Forms.NumericUpDown nmcPages;
        private System.Windows.Forms.TextBox txbGender;
        private System.Windows.Forms.Label lblEdition;
        private System.Windows.Forms.TextBox txbEdition;
        private System.Windows.Forms.NumericUpDown nmcVolume;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
    }
}