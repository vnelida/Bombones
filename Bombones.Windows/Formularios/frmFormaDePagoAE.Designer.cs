﻿namespace Bombones.Windows
{
    partial class frmFormaDePagoAE
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormaDePagoAE));
			btnCancelar = new Button();
			btnOk = new Button();
			txtForma = new TextBox();
			label1 = new Label();
			errorProvider1 = new ErrorProvider(components);
			errorProvider2 = new ErrorProvider(components);
			((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
			((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
			SuspendLayout();
			// 
			// btnCancelar
			// 
			btnCancelar.Image = Properties.Resources.Cancelar;
			btnCancelar.Location = new Point(661, 350);
			btnCancelar.Margin = new Padding(6);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(195, 115);
			btnCancelar.TabIndex = 19;
			btnCancelar.Text = "Cancelar";
			btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
			btnCancelar.UseVisualStyleBackColor = true;
			btnCancelar.Click += btnCancelar_Click;
			// 
			// btnOk
			// 
			btnOk.Image = (Image)resources.GetObject("btnOk.Image");
			btnOk.Location = new Point(76, 350);
			btnOk.Margin = new Padding(6);
			btnOk.Name = "btnOk";
			btnOk.Size = new Size(537, 115);
			btnOk.TabIndex = 20;
			btnOk.Text = "Ok";
			btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
			btnOk.UseVisualStyleBackColor = true;
			btnOk.Click += btnOk_Click;
			// 
			// txtForma
			// 
			txtForma.Location = new Point(221, 85);
			txtForma.Margin = new Padding(6);
			txtForma.MaxLength = 100;
			txtForma.Name = "txtForma";
			txtForma.Size = new Size(632, 39);
			txtForma.TabIndex = 18;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(76, 92);
			label1.Margin = new Padding(6, 0, 6, 0);
			label1.Name = "label1";
			label1.Size = new Size(143, 32);
			label1.TabIndex = 17;
			label1.Text = "Descripción:";
			// 
			// errorProvider1
			// 
			errorProvider1.ContainerControl = this;
			// 
			// errorProvider2
			// 
			errorProvider2.ContainerControl = this;
			// 
			// frmFormaDePagoAE
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(973, 442);
			Controls.Add(btnCancelar);
			Controls.Add(btnOk);
			Controls.Add(txtForma);
			Controls.Add(label1);
			Margin = new Padding(6);
			MaximumSize = new Size(999, 513);
			MinimumSize = new Size(999, 513);
			Name = "frmFormaDePagoAE";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmFormaDePagoAE";
			((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
			((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnCancelar;
        private Button btnOk;
        private TextBox txtForma;
        private Label label1;
        private ErrorProvider errorProvider1;
		private ErrorProvider errorProvider2;
	}
}