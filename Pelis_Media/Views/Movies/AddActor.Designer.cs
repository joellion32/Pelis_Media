namespace Pelis_Media.Views.Movies
{
	partial class AddActor
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dataGActors = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dataGListActors = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnSaveActors = new System.Windows.Forms.Button();
			this.lbAlert = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGActors)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGListActors)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dataGActors);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(35, 49);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1211, 325);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Todos los Actores";
			// 
			// dataGActors
			// 
			this.dataGActors.AllowUserToAddRows = false;
			this.dataGActors.AllowUserToDeleteRows = false;
			this.dataGActors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGActors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGActors.EnableHeadersVisualStyles = false;
			this.dataGActors.Location = new System.Drawing.Point(19, 26);
			this.dataGActors.Name = "dataGActors";
			this.dataGActors.ReadOnly = true;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGActors.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGActors.RowHeadersVisible = false;
			this.dataGActors.RowHeadersWidth = 51;
			this.dataGActors.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataGActors.RowTemplate.Height = 24;
			this.dataGActors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGActors.Size = new System.Drawing.Size(1173, 283);
			this.dataGActors.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dataGListActors);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
			this.groupBox2.Location = new System.Drawing.Point(35, 437);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1211, 296);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Lista de Actores";
			// 
			// dataGListActors
			// 
			this.dataGListActors.AllowUserToAddRows = false;
			this.dataGListActors.AllowUserToDeleteRows = false;
			this.dataGListActors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGListActors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGListActors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.apellido});
			this.dataGListActors.Location = new System.Drawing.Point(19, 27);
			this.dataGListActors.Name = "dataGListActors";
			this.dataGListActors.ReadOnly = true;
			this.dataGListActors.RowHeadersWidth = 51;
			this.dataGListActors.RowTemplate.Height = 24;
			this.dataGListActors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGListActors.Size = new System.Drawing.Size(1173, 253);
			this.dataGListActors.TabIndex = 0;
			// 
			// id
			// 
			this.id.HeaderText = "id_actor";
			this.id.MinimumWidth = 6;
			this.id.Name = "id";
			this.id.ReadOnly = true;
			// 
			// nombre
			// 
			this.nombre.HeaderText = "nombre";
			this.nombre.MinimumWidth = 6;
			this.nombre.Name = "nombre";
			this.nombre.ReadOnly = true;
			// 
			// apellido
			// 
			this.apellido.HeaderText = "apellido";
			this.apellido.MinimumWidth = 6;
			this.apellido.Name = "apellido";
			this.apellido.ReadOnly = true;
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
			this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnAdd.Location = new System.Drawing.Point(722, 380);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(524, 55);
			this.btnAdd.TabIndex = 37;
			this.btnAdd.Text = "AGREGAR ACTOR";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnSaveActors
			// 
			this.btnSaveActors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
			this.btnSaveActors.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSaveActors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveActors.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSaveActors.Location = new System.Drawing.Point(722, 739);
			this.btnSaveActors.Name = "btnSaveActors";
			this.btnSaveActors.Size = new System.Drawing.Size(524, 55);
			this.btnSaveActors.TabIndex = 38;
			this.btnSaveActors.Text = "GUARDAR LISTA";
			this.btnSaveActors.UseVisualStyleBackColor = false;
			this.btnSaveActors.Click += new System.EventHandler(this.btnSaveActors_Click);
			// 
			// lbAlert
			// 
			this.lbAlert.AutoSize = true;
			this.lbAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbAlert.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.lbAlert.Location = new System.Drawing.Point(906, 21);
			this.lbAlert.Name = "lbAlert";
			this.lbAlert.Size = new System.Drawing.Size(340, 25);
			this.lbAlert.TabIndex = 39;
			this.lbAlert.Text = "Cambios aplicados sastifastoriamente";
			this.lbAlert.Visible = false;
			// 
			// AddActor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1314, 799);
			this.Controls.Add(this.lbAlert);
			this.Controls.Add(this.btnSaveActors);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddActor";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Agregar Actores";
			this.Load += new System.EventHandler(this.AddActor_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGActors)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGListActors)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dataGActors;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnSaveActors;
		private System.Windows.Forms.DataGridView dataGListActors;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
		private System.Windows.Forms.Label lbAlert;
	}
}