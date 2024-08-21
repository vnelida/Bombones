using System.Windows.Forms;

namespace Bombones.Windows.Formularios
{
    partial class frmBombones
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
			tsbOrdenar = new ToolStripDropDownButton();
			tsbCerrar = new ToolStripButton();
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
			colBombon = new DataGridViewTextBoxColumn();
			colChocolate = new DataGridViewTextBoxColumn();
			colRelleno = new DataGridViewTextBoxColumn();
			colNuez = new DataGridViewTextBoxColumn();
			colFabrica = new DataGridViewTextBoxColumn();
			colStock = new DataGridViewTextBoxColumn();
			colPrecio = new DataGridViewTextBoxColumn();
			toolStrip1.SuspendLayout();
			panelNavegacion.SuspendLayout();
			panelGrilla.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
			SuspendLayout();
			// 
			// toolStrip1
			// 
			toolStrip1.ImageScalingSize = new Size(32, 32);
			toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBorrar, tsbEditar, toolStripSeparator1, tsbFiltrar, tsbActualizar, toolStripSeparator2, tsbImprimir, toolStripSeparator3, tsbOrdenar, tsbCerrar });
			toolStrip1.Location = new Point(0, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Padding = new Padding(0, 0, 4, 0);
			toolStrip1.Size = new Size(2204, 82);
			toolStrip1.TabIndex = 4;
			toolStrip1.Text = "toolStrip1";
			// 
			// tsbNuevo
			// 
			tsbNuevo.Image = Properties.Resources.Nuevo;
			tsbNuevo.ImageScaling = ToolStripItemImageScaling.None;
			tsbNuevo.ImageTransparentColor = Color.Magenta;
			tsbNuevo.Name = "tsbNuevo";
			tsbNuevo.Size = new Size(89, 76);
			tsbNuevo.Text = "Nuevo";
			tsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
			// 
			// tsbBorrar
			// 
			tsbBorrar.Image = Properties.Resources.Delete;
			tsbBorrar.ImageScaling = ToolStripItemImageScaling.None;
			tsbBorrar.ImageTransparentColor = Color.Magenta;
			tsbBorrar.Name = "tsbBorrar";
			tsbBorrar.Size = new Size(82, 76);
			tsbBorrar.Text = "Borrar";
			tsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
			// 
			// tsbEditar
			// 
			tsbEditar.Image = Properties.Resources.Edit;
			tsbEditar.ImageScaling = ToolStripItemImageScaling.None;
			tsbEditar.ImageTransparentColor = Color.Magenta;
			tsbEditar.Name = "tsbEditar";
			tsbEditar.Size = new Size(78, 76);
			tsbEditar.Text = "Editar";
			tsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(6, 82);
			// 
			// tsbFiltrar
			// 
			tsbFiltrar.Image = Properties.Resources.filter_40px;
			tsbFiltrar.ImageScaling = ToolStripItemImageScaling.None;
			tsbFiltrar.ImageTransparentColor = Color.Magenta;
			tsbFiltrar.Name = "tsbFiltrar";
			tsbFiltrar.Size = new Size(78, 76);
			tsbFiltrar.Text = "Filtrar";
			tsbFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
			// 
			// tsbActualizar
			// 
			tsbActualizar.Image = Properties.Resources.Update;
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
			tsbImprimir.Image = Properties.Resources.Print;
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
			// tsbOrdenar
			// 
			tsbOrdenar.Image = Properties.Resources.list_40px;
			tsbOrdenar.ImageScaling = ToolStripItemImageScaling.None;
			tsbOrdenar.ImageTransparentColor = Color.Magenta;
			tsbOrdenar.Name = "tsbOrdenar";
			tsbOrdenar.Size = new Size(123, 76);
			tsbOrdenar.Text = "Ordenar";
			tsbOrdenar.TextImageRelation = TextImageRelation.ImageAboveText;
			// 
			// tsbCerrar
			// 
			tsbCerrar.Image = Properties.Resources.Close;
			tsbCerrar.ImageScaling = ToolStripItemImageScaling.None;
			tsbCerrar.ImageTransparentColor = Color.Magenta;
			tsbCerrar.Name = "tsbCerrar";
			tsbCerrar.Size = new Size(82, 76);
			tsbCerrar.Text = "Cerrar";
			tsbCerrar.TextImageRelation = TextImageRelation.ImageAboveText;
			tsbCerrar.Click += tsbCerrar_Click;
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
			panelNavegacion.Location = new Point(0, 971);
			panelNavegacion.Margin = new Padding(6);
			panelNavegacion.Name = "panelNavegacion";
			panelNavegacion.Size = new Size(2204, 213);
			panelNavegacion.TabIndex = 5;
			// 
			// txtCantidadPaginas
			// 
			txtCantidadPaginas.Location = new Point(327, 75);
			txtCantidadPaginas.Margin = new Padding(6);
			txtCantidadPaginas.Name = "txtCantidadPaginas";
			txtCantidadPaginas.ReadOnly = true;
			txtCantidadPaginas.Size = new Size(154, 39);
			txtCantidadPaginas.TabIndex = 27;
			// 
			// cboPaginas
			// 
			cboPaginas.DropDownStyle = ComboBoxStyle.DropDownList;
			cboPaginas.FormattingEnabled = true;
			cboPaginas.Location = new Point(136, 75);
			cboPaginas.Margin = new Padding(6);
			cboPaginas.Name = "cboPaginas";
			cboPaginas.Size = new Size(123, 40);
			cboPaginas.TabIndex = 26;
			cboPaginas.SelectedIndexChanged += cboPaginas_SelectedIndexChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(273, 81);
			label2.Margin = new Padding(6, 0, 6, 0);
			label2.Name = "label2";
			label2.Size = new Size(46, 32);
			label2.TabIndex = 24;
			label2.Text = "de:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(63, 81);
			label1.Margin = new Padding(6, 0, 6, 0);
			label1.Name = "label1";
			label1.Size = new Size(62, 32);
			label1.TabIndex = 25;
			label1.Text = "Pág.:";
			// 
			// btnUltimo
			// 
			btnUltimo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnUltimo.Image = Properties.Resources.last_24px;
			btnUltimo.Location = new Point(2011, 75);
			btnUltimo.Margin = new Padding(6);
			btnUltimo.Name = "btnUltimo";
			btnUltimo.Size = new Size(139, 87);
			btnUltimo.TabIndex = 20;
			btnUltimo.UseVisualStyleBackColor = true;
			btnUltimo.Click += btnUltimo_Click;
			// 
			// btnSiguiente
			// 
			btnSiguiente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnSiguiente.Image = Properties.Resources.next_24px;
			btnSiguiente.Location = new Point(1861, 75);
			btnSiguiente.Margin = new Padding(6);
			btnSiguiente.Name = "btnSiguiente";
			btnSiguiente.Size = new Size(139, 87);
			btnSiguiente.TabIndex = 21;
			btnSiguiente.UseVisualStyleBackColor = true;
			btnSiguiente.Click += btnSiguiente_Click;
			// 
			// btnAnterior
			// 
			btnAnterior.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnAnterior.Image = Properties.Resources.previous_24px;
			btnAnterior.Location = new Point(1710, 75);
			btnAnterior.Margin = new Padding(6);
			btnAnterior.Name = "btnAnterior";
			btnAnterior.Size = new Size(139, 87);
			btnAnterior.TabIndex = 22;
			btnAnterior.UseVisualStyleBackColor = true;
			btnAnterior.Click += btnAnterior_Click;
			// 
			// btnPrimero
			// 
			btnPrimero.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnPrimero.Image = Properties.Resources.first_24px;
			btnPrimero.Location = new Point(1560, 75);
			btnPrimero.Margin = new Padding(6);
			btnPrimero.Name = "btnPrimero";
			btnPrimero.Size = new Size(139, 87);
			btnPrimero.TabIndex = 23;
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
			panelGrilla.Size = new Size(2204, 889);
			panelGrilla.TabIndex = 6;
			// 
			// dgvDatos
			// 
			dgvDatos.AllowUserToAddRows = false;
			dgvDatos.AllowUserToDeleteRows = false;
			dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colId, colBombon, colChocolate, colRelleno, colNuez, colFabrica, colStock, colPrecio });
			dgvDatos.Dock = DockStyle.Fill;
			dgvDatos.Location = new Point(0, 0);
			dgvDatos.Margin = new Padding(6);
			dgvDatos.MultiSelect = false;
			dgvDatos.Name = "dgvDatos";
			dgvDatos.ReadOnly = true;
			dgvDatos.RowHeadersVisible = false;
			dgvDatos.RowHeadersWidth = 82;
			dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvDatos.Size = new Size(2204, 889);
			dgvDatos.TabIndex = 0;
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
			// colBombon
			// 
			colBombon.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colBombon.HeaderText = "Bombon";
			colBombon.MinimumWidth = 10;
			colBombon.Name = "colBombon";
			colBombon.ReadOnly = true;
			// 
			// colChocolate
			// 
			colChocolate.HeaderText = "Chocolate";
			colChocolate.MinimumWidth = 10;
			colChocolate.Name = "colChocolate";
			colChocolate.ReadOnly = true;
			colChocolate.Width = 200;
			// 
			// colRelleno
			// 
			colRelleno.HeaderText = "Relleno";
			colRelleno.MinimumWidth = 10;
			colRelleno.Name = "colRelleno";
			colRelleno.ReadOnly = true;
			colRelleno.Width = 200;
			// 
			// colNuez
			// 
			colNuez.HeaderText = "Nuez";
			colNuez.MinimumWidth = 10;
			colNuez.Name = "colNuez";
			colNuez.ReadOnly = true;
			colNuez.Width = 200;
			// 
			// colFabrica
			// 
			colFabrica.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colFabrica.HeaderText = "Fábrica";
			colFabrica.MinimumWidth = 10;
			colFabrica.Name = "colFabrica";
			colFabrica.ReadOnly = true;
			// 
			// colStock
			// 
			colStock.HeaderText = "Stock";
			colStock.MinimumWidth = 10;
			colStock.Name = "colStock";
			colStock.ReadOnly = true;
			colStock.Width = 200;
			// 
			// colPrecio
			// 
			colPrecio.HeaderText = "P.Vta";
			colPrecio.MinimumWidth = 10;
			colPrecio.Name = "colPrecio";
			colPrecio.ReadOnly = true;
			colPrecio.Width = 200;
			// 
			// frmBombones
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(2204, 1184);
			Controls.Add(panelGrilla);
			Controls.Add(panelNavegacion);
			Controls.Add(toolStrip1);
			Margin = new Padding(6);
			Name = "frmBombones";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmBombones";
			Load += frmBombones_Load;
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
        private ToolStripDropDownButton tsbOrdenar;
        private Panel panelNavegacion;
        private Panel panelGrilla;
        private TextBox txtCantidadPaginas;
        private ComboBox cboPaginas;
        private Label label2;
        private Label label1;
        private Button btnUltimo;
        private Button btnSiguiente;
        private Button btnAnterior;
        private Button btnPrimero;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colBombon;
        private DataGridViewTextBoxColumn colChocolate;
        private DataGridViewTextBoxColumn colRelleno;
        private DataGridViewTextBoxColumn colNuez;
        private DataGridViewTextBoxColumn colFabrica;
        private DataGridViewTextBoxColumn colStock;
        private DataGridViewTextBoxColumn colPrecio;
    }
}