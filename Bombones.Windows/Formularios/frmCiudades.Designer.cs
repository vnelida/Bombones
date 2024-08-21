namespace Bombones.Windows
{
    partial class frmCiudades
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCiudades));
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			toolStrip1 = new ToolStrip();
			tsbNuevo = new ToolStripButton();
			tsbBorrar = new ToolStripButton();
			tsbEditar = new ToolStripButton();
			toolStripSeparator1 = new ToolStripSeparator();
			tsbFiltrar = new ToolStripButton();
			tsbActualizar = new ToolStripButton();
			toolStripSeparator2 = new ToolStripSeparator();
			tsbImprimir = new ToolStripButton();
			toolStripSeparator3 = new ToolStripSeparator();
			tsbCerrar = new ToolStripButton();
			tsbOrdenar = new ToolStripDropDownButton();
			aZPorPaísToolStripMenuItem = new ToolStripMenuItem();
			aZPorEstadoToolStripMenuItem = new ToolStripMenuItem();
			zAPorPaísToolStripMenuItem = new ToolStripMenuItem();
			zAPorEstadoToolStripMenuItem = new ToolStripMenuItem();
			panelNavegacion = new Panel();
			txtCantidadPaginas = new TextBox();
			cboPaginas = new ComboBox();
			label2 = new Label();
			label1 = new Label();
			btnUltimo = new Button();
			btnSiguiente = new Button();
			btnAnterior = new Button();
			btnPrimero = new Button();
			panelGrilla = new Panel();
			dgvDatos = new DataGridView();
			colId = new DataGridViewTextBoxColumn();
			colCiudad = new DataGridViewTextBoxColumn();
			colProvinciaEstado = new DataGridViewTextBoxColumn();
			colPais = new DataGridViewTextBoxColumn();
			aZPorCiudadToolStripMenuItem = new ToolStripMenuItem();
			zAPorCiudadToolStripMenuItem = new ToolStripMenuItem();
			toolStrip1.SuspendLayout();
			panelNavegacion.SuspendLayout();
			panelGrilla.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
			SuspendLayout();
			// 
			// toolStrip1
			// 
			toolStrip1.ImageScalingSize = new Size(32, 32);
			toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBorrar, tsbEditar, toolStripSeparator1, tsbFiltrar, tsbActualizar, toolStripSeparator2, tsbImprimir, toolStripSeparator3, tsbCerrar, tsbOrdenar });
			toolStrip1.Location = new Point(0, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Padding = new Padding(0, 0, 4, 0);
			toolStrip1.Size = new Size(1486, 82);
			toolStrip1.TabIndex = 4;
			toolStrip1.Text = "toolStrip1";
			// 
			// tsbNuevo
			// 
			tsbNuevo.Image = (Image)resources.GetObject("tsbNuevo.Image");
			tsbNuevo.ImageScaling = ToolStripItemImageScaling.None;
			tsbNuevo.ImageTransparentColor = Color.Magenta;
			tsbNuevo.Name = "tsbNuevo";
			tsbNuevo.Size = new Size(89, 76);
			tsbNuevo.Text = "Nuevo";
			tsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
			tsbNuevo.Click += tsbNuevo_Click;
			// 
			// tsbBorrar
			// 
			tsbBorrar.Image = (Image)resources.GetObject("tsbBorrar.Image");
			tsbBorrar.ImageScaling = ToolStripItemImageScaling.None;
			tsbBorrar.ImageTransparentColor = Color.Magenta;
			tsbBorrar.Name = "tsbBorrar";
			tsbBorrar.Size = new Size(82, 76);
			tsbBorrar.Text = "Borrar";
			tsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
			tsbBorrar.Click += tsbBorrar_Click;
			// 
			// tsbEditar
			// 
			tsbEditar.Image = (Image)resources.GetObject("tsbEditar.Image");
			tsbEditar.ImageScaling = ToolStripItemImageScaling.None;
			tsbEditar.ImageTransparentColor = Color.Magenta;
			tsbEditar.Name = "tsbEditar";
			tsbEditar.Size = new Size(78, 76);
			tsbEditar.Text = "Editar";
			tsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
			tsbEditar.Click += tsbEditar_Click;
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(6, 82);
			// 
			// tsbFiltrar
			// 
			tsbFiltrar.Image = (Image)resources.GetObject("tsbFiltrar.Image");
			tsbFiltrar.ImageScaling = ToolStripItemImageScaling.None;
			tsbFiltrar.ImageTransparentColor = Color.Magenta;
			tsbFiltrar.Name = "tsbFiltrar";
			tsbFiltrar.Size = new Size(78, 76);
			tsbFiltrar.Text = "Filtrar";
			tsbFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
			// 
			// tsbActualizar
			// 
			tsbActualizar.Image = (Image)resources.GetObject("tsbActualizar.Image");
			tsbActualizar.ImageScaling = ToolStripItemImageScaling.None;
			tsbActualizar.ImageTransparentColor = Color.Magenta;
			tsbActualizar.Name = "tsbActualizar";
			tsbActualizar.Size = new Size(121, 76);
			tsbActualizar.Text = "Actualizar";
			tsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
			// 
			// toolStripSeparator2
			// 
			toolStripSeparator2.Name = "toolStripSeparator2";
			toolStripSeparator2.Size = new Size(6, 82);
			// 
			// tsbImprimir
			// 
			tsbImprimir.Image = (Image)resources.GetObject("tsbImprimir.Image");
			tsbImprimir.ImageScaling = ToolStripItemImageScaling.None;
			tsbImprimir.ImageTransparentColor = Color.Magenta;
			tsbImprimir.Name = "tsbImprimir";
			tsbImprimir.Size = new Size(108, 76);
			tsbImprimir.Text = "Imprimir";
			tsbImprimir.TextImageRelation = TextImageRelation.ImageAboveText;
			// 
			// toolStripSeparator3
			// 
			toolStripSeparator3.Name = "toolStripSeparator3";
			toolStripSeparator3.Size = new Size(6, 82);
			// 
			// tsbCerrar
			// 
			tsbCerrar.Image = (Image)resources.GetObject("tsbCerrar.Image");
			tsbCerrar.ImageScaling = ToolStripItemImageScaling.None;
			tsbCerrar.ImageTransparentColor = Color.Magenta;
			tsbCerrar.Name = "tsbCerrar";
			tsbCerrar.Size = new Size(82, 76);
			tsbCerrar.Text = "Cerrar";
			tsbCerrar.TextImageRelation = TextImageRelation.ImageAboveText;
			tsbCerrar.Click += tsbCerrar_Click;
			// 
			// tsbOrdenar
			// 
			tsbOrdenar.DropDownItems.AddRange(new ToolStripItem[] { aZPorPaísToolStripMenuItem, aZPorEstadoToolStripMenuItem, zAPorPaísToolStripMenuItem, zAPorEstadoToolStripMenuItem, aZPorCiudadToolStripMenuItem, zAPorCiudadToolStripMenuItem });
			tsbOrdenar.Image = Properties.Resources.list_40px;
			tsbOrdenar.ImageScaling = ToolStripItemImageScaling.None;
			tsbOrdenar.ImageTransparentColor = Color.Magenta;
			tsbOrdenar.Name = "tsbOrdenar";
			tsbOrdenar.Size = new Size(123, 76);
			tsbOrdenar.Text = "Ordenar";
			tsbOrdenar.TextImageRelation = TextImageRelation.ImageAboveText;
			// 
			// aZPorPaísToolStripMenuItem
			// 
			aZPorPaísToolStripMenuItem.Image = Properties.Resources.alphabetical_sorting_16px;
			aZPorPaísToolStripMenuItem.Name = "aZPorPaísToolStripMenuItem";
			aZPorPaísToolStripMenuItem.Size = new Size(359, 44);
			aZPorPaísToolStripMenuItem.Text = "A-Z por País";
			aZPorPaísToolStripMenuItem.Click += aZPorPaísToolStripMenuItem_Click;
			// 
			// aZPorEstadoToolStripMenuItem
			// 
			aZPorEstadoToolStripMenuItem.Image = Properties.Resources.alphabetical_sorting_16px;
			aZPorEstadoToolStripMenuItem.Name = "aZPorEstadoToolStripMenuItem";
			aZPorEstadoToolStripMenuItem.Size = new Size(359, 44);
			aZPorEstadoToolStripMenuItem.Text = "A-Z por Estado";
			aZPorEstadoToolStripMenuItem.Click += aZPorEstadoToolStripMenuItem_Click;
			// 
			// zAPorPaísToolStripMenuItem
			// 
			zAPorPaísToolStripMenuItem.Image = Properties.Resources.alphabetical_sorting_2_16px;
			zAPorPaísToolStripMenuItem.Name = "zAPorPaísToolStripMenuItem";
			zAPorPaísToolStripMenuItem.Size = new Size(359, 44);
			zAPorPaísToolStripMenuItem.Text = "Z-A por País";
			zAPorPaísToolStripMenuItem.Click += zAPorPaísToolStripMenuItem_Click;
			// 
			// zAPorEstadoToolStripMenuItem
			// 
			zAPorEstadoToolStripMenuItem.Image = Properties.Resources.alphabetical_sorting_2_16px;
			zAPorEstadoToolStripMenuItem.Name = "zAPorEstadoToolStripMenuItem";
			zAPorEstadoToolStripMenuItem.Size = new Size(359, 44);
			zAPorEstadoToolStripMenuItem.Text = "Z-A por Estado";
			zAPorEstadoToolStripMenuItem.Click += zAPorEstadoToolStripMenuItem_Click;
			// 
			// panelNavegacion
			// 
			panelNavegacion.Controls.Add(txtCantidadPaginas);
			panelNavegacion.Controls.Add(cboPaginas);
			panelNavegacion.Controls.Add(label2);
			panelNavegacion.Controls.Add(label1);
			panelNavegacion.Controls.Add(btnUltimo);
			panelNavegacion.Controls.Add(btnSiguiente);
			panelNavegacion.Controls.Add(btnAnterior);
			panelNavegacion.Controls.Add(btnPrimero);
			panelNavegacion.Dock = DockStyle.Bottom;
			panelNavegacion.Location = new Point(0, 747);
			panelNavegacion.Margin = new Padding(6);
			panelNavegacion.Name = "panelNavegacion";
			panelNavegacion.Size = new Size(1486, 213);
			panelNavegacion.TabIndex = 5;
			// 
			// txtCantidadPaginas
			// 
			txtCantidadPaginas.Location = new Point(327, 75);
			txtCantidadPaginas.Margin = new Padding(6);
			txtCantidadPaginas.Name = "txtCantidadPaginas";
			txtCantidadPaginas.ReadOnly = true;
			txtCantidadPaginas.Size = new Size(154, 39);
			txtCantidadPaginas.TabIndex = 43;
			// 
			// cboPaginas
			// 
			cboPaginas.DropDownStyle = ComboBoxStyle.DropDownList;
			cboPaginas.FormattingEnabled = true;
			cboPaginas.Location = new Point(136, 75);
			cboPaginas.Margin = new Padding(6);
			cboPaginas.Name = "cboPaginas";
			cboPaginas.Size = new Size(123, 40);
			cboPaginas.TabIndex = 42;
			cboPaginas.SelectedIndexChanged += cboPaginas_SelectedIndexChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(273, 81);
			label2.Margin = new Padding(6, 0, 6, 0);
			label2.Name = "label2";
			label2.Size = new Size(46, 32);
			label2.TabIndex = 40;
			label2.Text = "de:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(63, 81);
			label1.Margin = new Padding(6, 0, 6, 0);
			label1.Name = "label1";
			label1.Size = new Size(62, 32);
			label1.TabIndex = 41;
			label1.Text = "Pág.:";
			// 
			// btnUltimo
			// 
			btnUltimo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnUltimo.Image = Properties.Resources.last_24px;
			btnUltimo.Location = new Point(1283, 64);
			btnUltimo.Margin = new Padding(6);
			btnUltimo.Name = "btnUltimo";
			btnUltimo.Size = new Size(139, 87);
			btnUltimo.TabIndex = 36;
			btnUltimo.UseVisualStyleBackColor = true;
			btnUltimo.Click += btnUltimo_Click;
			// 
			// btnSiguiente
			// 
			btnSiguiente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnSiguiente.Image = Properties.Resources.next_24px;
			btnSiguiente.Location = new Point(1133, 64);
			btnSiguiente.Margin = new Padding(6);
			btnSiguiente.Name = "btnSiguiente";
			btnSiguiente.Size = new Size(139, 87);
			btnSiguiente.TabIndex = 37;
			btnSiguiente.UseVisualStyleBackColor = true;
			btnSiguiente.Click += btnSiguiente_Click;
			// 
			// btnAnterior
			// 
			btnAnterior.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnAnterior.Image = Properties.Resources.previous_24px;
			btnAnterior.Location = new Point(982, 64);
			btnAnterior.Margin = new Padding(6);
			btnAnterior.Name = "btnAnterior";
			btnAnterior.Size = new Size(139, 87);
			btnAnterior.TabIndex = 38;
			btnAnterior.UseVisualStyleBackColor = true;
			btnAnterior.Click += btnAnterior_Click;
			// 
			// btnPrimero
			// 
			btnPrimero.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnPrimero.Image = Properties.Resources.first_24px;
			btnPrimero.Location = new Point(832, 64);
			btnPrimero.Margin = new Padding(6);
			btnPrimero.Name = "btnPrimero";
			btnPrimero.Size = new Size(139, 87);
			btnPrimero.TabIndex = 39;
			btnPrimero.UseVisualStyleBackColor = true;
			btnPrimero.Click += btnPrimero_Click;
			// 
			// panelGrilla
			// 
			panelGrilla.Controls.Add(dgvDatos);
			panelGrilla.Dock = DockStyle.Fill;
			panelGrilla.Location = new Point(0, 82);
			panelGrilla.Margin = new Padding(6);
			panelGrilla.Name = "panelGrilla";
			panelGrilla.Size = new Size(1486, 665);
			panelGrilla.TabIndex = 6;
			// 
			// dgvDatos
			// 
			dgvDatos.AllowUserToAddRows = false;
			dgvDatos.AllowUserToDeleteRows = false;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(224, 224, 224);
			dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
			dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colId, colCiudad, colProvinciaEstado, colPais });
			dgvDatos.Dock = DockStyle.Fill;
			dgvDatos.Location = new Point(0, 0);
			dgvDatos.Margin = new Padding(6);
			dgvDatos.MultiSelect = false;
			dgvDatos.Name = "dgvDatos";
			dgvDatos.ReadOnly = true;
			dgvDatos.RowHeadersVisible = false;
			dgvDatos.RowHeadersWidth = 82;
			dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvDatos.Size = new Size(1486, 665);
			dgvDatos.TabIndex = 5;
			// 
			// colId
			// 
			colId.HeaderText = "Id";
			colId.MinimumWidth = 10;
			colId.Name = "colId";
			colId.ReadOnly = true;
			colId.Visible = false;
			colId.Width = 200;
			// 
			// colCiudad
			// 
			colCiudad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colCiudad.HeaderText = "Ciudad";
			colCiudad.MinimumWidth = 10;
			colCiudad.Name = "colCiudad";
			colCiudad.ReadOnly = true;
			// 
			// colProvinciaEstado
			// 
			colProvinciaEstado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colProvinciaEstado.HeaderText = "Prov. Estado";
			colProvinciaEstado.MinimumWidth = 10;
			colProvinciaEstado.Name = "colProvinciaEstado";
			colProvinciaEstado.ReadOnly = true;
			// 
			// colPais
			// 
			colPais.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colPais.HeaderText = "País";
			colPais.MinimumWidth = 10;
			colPais.Name = "colPais";
			colPais.ReadOnly = true;
			// 
			// aZPorCiudadToolStripMenuItem
			// 
			aZPorCiudadToolStripMenuItem.Name = "aZPorCiudadToolStripMenuItem";
			aZPorCiudadToolStripMenuItem.Size = new Size(359, 44);
			aZPorCiudadToolStripMenuItem.Text = "A-Z por Ciudad";
			aZPorCiudadToolStripMenuItem.Click += aZPorCiudadToolStripMenuItem_Click;
			// 
			// zAPorCiudadToolStripMenuItem
			// 
			zAPorCiudadToolStripMenuItem.Name = "zAPorCiudadToolStripMenuItem";
			zAPorCiudadToolStripMenuItem.Size = new Size(359, 44);
			zAPorCiudadToolStripMenuItem.Text = "Z-A por Ciudad";
			zAPorCiudadToolStripMenuItem.Click += zAPorCiudadToolStripMenuItem_Click;
			// 
			// frmCiudades
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1486, 960);
			Controls.Add(panelGrilla);
			Controls.Add(panelNavegacion);
			Controls.Add(toolStrip1);
			Margin = new Padding(6);
			Name = "frmCiudades";
			Text = "frmCiudades";
			Load += frmCiudades_Load;
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			panelNavegacion.ResumeLayout(false);
			panelNavegacion.PerformLayout();
			panelGrilla.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private ToolStrip toolStrip1;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbBorrar;
        private ToolStripButton tsbEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbFiltrar;
        private ToolStripButton tsbActualizar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsbImprimir;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton tsbCerrar;
        private Panel panelNavegacion;
        private TextBox txtCantidadPaginas;
        private ComboBox cboPaginas;
        private Label label2;
        private Label label1;
        private Button btnUltimo;
        private Button btnSiguiente;
        private Button btnAnterior;
        private Button btnPrimero;
        private Panel panelGrilla;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colCiudad;
        private DataGridViewTextBoxColumn colProvinciaEstado;
        private DataGridViewTextBoxColumn colPais;
		private ToolStripDropDownButton tsbOrdenar;
		private ToolStripMenuItem aZPorPaísToolStripMenuItem;
		private ToolStripMenuItem aZPorEstadoToolStripMenuItem;
		private ToolStripMenuItem zAPorPaísToolStripMenuItem;
		private ToolStripMenuItem zAPorEstadoToolStripMenuItem;
		private ToolStripMenuItem aZPorCiudadToolStripMenuItem;
		private ToolStripMenuItem zAPorCiudadToolStripMenuItem;
	}
}