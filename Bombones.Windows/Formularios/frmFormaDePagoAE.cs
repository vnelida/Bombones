using Bombones.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bombones.Windows
{
	public partial class frmFormaDePagoAE : Form
	{
		FormaDePago formaDePago;
		public frmFormaDePagoAE()
		{
			InitializeComponent();
		}

		internal FormaDePago? GetFormaDePago()
		{
			return formaDePago;
		}
		public void SetFormaDePago(FormaDePago formaDePago)
		{
			this.formaDePago = formaDePago;
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			if (formaDePago != null)
			{
				txtForma.Text = formaDePago.Descripcion;
			}
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			if (ValidarDatos())
			{
				if (ValidarDatos())
				{
					if (formaDePago == null)
					{
						formaDePago = new FormaDePago();
					}
					formaDePago.Descripcion = txtForma.Text;

					DialogResult = DialogResult.OK;
				}
			}
		}

		private bool ValidarDatos()
		{
			bool valido = true;
			errorProvider1.Clear();
			if (string.IsNullOrEmpty(txtForma.Text))
			{
				valido = false;
				errorProvider1.SetError(txtForma, "La descripcion es requerida");
			}
			return valido;
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}
	}
}
