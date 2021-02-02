namespace Pelis_Media.Views
{
	partial class Actor
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnCreate = new System.Windows.Forms.Button();
			this.comboSex = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
			this.tbxSearch = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnall = new System.Windows.Forms.Button();
			this.dataGActors = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGActors)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCreate
			// 
			this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
			this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCreate.Location = new System.Drawing.Point(1134, 110);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(354, 41);
			this.btnCreate.TabIndex = 33;
			this.btnCreate.Text = "CREAR ACTOR";
			this.btnCreate.UseVisualStyleBackColor = false;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// comboSex
			// 
			this.comboSex.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.comboSex.DisplayMember = "Id";
			this.comboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboSex.FormattingEnabled = true;
			this.comboSex.Items.AddRange(new object[] {
            "M",
            "F"});
			this.comboSex.Location = new System.Drawing.Point(886, 112);
			this.comboSex.Name = "comboSex";
			this.comboSex.Size = new System.Drawing.Size(202, 37);
			this.comboSex.TabIndex = 32;
			this.comboSex.SelectedIndexChanged += new System.EventHandler(this.comboGenres_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(784, 118);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 25);
			this.label4.TabIndex = 31;
			this.label4.Text = "SEXO";
			// 
			// btnSearch
			// 
			this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
			this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSearch.Location = new System.Drawing.Point(611, 110);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(132, 45);
			this.btnSearch.TabIndex = 30;
			this.btnSearch.Text = "BUSCAR";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// iconPictureBox2
			// 
			this.iconPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.iconPictureBox2.BackColor = System.Drawing.SystemColors.Control;
			this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Search;
			this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
			this.iconPictureBox2.IconSize = 43;
			this.iconPictureBox2.Location = new System.Drawing.Point(24, 112);
			this.iconPictureBox2.Name = "iconPictureBox2";
			this.iconPictureBox2.Size = new System.Drawing.Size(51, 43);
			this.iconPictureBox2.TabIndex = 29;
			this.iconPictureBox2.TabStop = false;
			// 
			// tbxSearch
			// 
			this.tbxSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.tbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxSearch.Location = new System.Drawing.Point(81, 112);
			this.tbxSearch.Multiline = true;
			this.tbxSearch.Name = "tbxSearch";
			this.tbxSearch.Size = new System.Drawing.Size(524, 43);
			this.tbxSearch.TabIndex = 28;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(19, 33);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 29);
			this.label3.TabIndex = 27;
			this.label3.Text = "Actores";
			// 
			// btnall
			// 
			this.btnall.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
			this.btnall.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnall.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnall.Location = new System.Drawing.Point(1134, 694);
			this.btnall.Name = "btnall";
			this.btnall.Size = new System.Drawing.Size(354, 41);
			this.btnall.TabIndex = 26;
			this.btnall.Text = "MOSTRAR TODO";
			this.btnall.UseVisualStyleBackColor = false;
			this.btnall.Click += new System.EventHandler(this.btnall_Click);
			// 
			// dataGActors
			// 
			this.dataGActors.AllowUserToAddRows = false;
			this.dataGActors.AllowUserToDeleteRows = false;
			this.dataGActors.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.dataGActors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGActors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGActors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGActors.EnableHeadersVisualStyles = false;
			this.dataGActors.Location = new System.Drawing.Point(24, 173);
			this.dataGActors.Name = "dataGActors";
			this.dataGActors.ReadOnly = true;
			this.dataGActors.RowHeadersWidth = 51;
			this.dataGActors.RowTemplate.Height = 24;
			this.dataGActors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGActors.Size = new System.Drawing.Size(1464, 503);
			this.dataGActors.TabIndex = 25;
			this.dataGActors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGActors_CellContentClick);
			// 
			// Actor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1520, 755);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.comboSex);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.iconPictureBox2);
			this.Controls.Add(this.tbxSearch);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnall);
			this.Controls.Add(this.dataGActors);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Actor";
			this.Text = "Actores";
			this.Load += new System.EventHandler(this.Actors_Load);
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGActors)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.ComboBox comboSex;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnSearch;
		private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
		private System.Windows.Forms.TextBox tbxSearch;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnall;
		private System.Windows.Forms.DataGridView dataGActors;
	}
}