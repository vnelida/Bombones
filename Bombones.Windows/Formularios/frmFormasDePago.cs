using Bombones.Entidades.Entidades;
using Bombones.Servicios.Intefaces;
using Bombones.Windows.Formularios;
using Bombones.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bombones.Windows
{
	public partial class frmFormasDePago : Form
	{
		private readonly IServiceFormasDePago? _servicio;
		private List<FormaDePago>? lista;

		public frmFormasDePago(IServiceProvider serviceProvider)
		{
			InitializeComponent();
			_servicio = serviceProvider.GetService<IServiceFormasDePago>();
		}

		private void frmFormasDePago_Load(object sender, EventArgs e)
		{
			lista = _servicio!?.GetLista();
			MostrarDatosEnGrilla();
		}

		private void MostrarDatosEnGrilla()
		{
			GridHelper.LimpiarGrilla(dgvDatos);
			if (lista is not null)
			{
				foreach (var item in lista)
				{
					var r = GridHelper.ConstruirFila(dgvDatos);
					GridHelper.SetearFila(r, item);
					GridHelper.AgregarFila(r, dgvDatos);
				}

			}
		}

		private void tsbNuevo_Click(object sender, EventArgs e)
		{
			frmFormaDePagoAE frm = new frmFormaDePagoAE() { Text = "Agregar Forma de pago" };
			DialogResult dr = frm.ShowDialog(this);
			try
			{
				if (dr == DialogResult.Cancel)
				{
					return;
				}
				FormaDePago? formaDePago = frm.GetFormaDePago();
				if (formaDePago is null)
				{
					return;
				}

				if (!_servicio!.Existe(formaDePago))
				{
					_servicio!.Guardar(formaDePago);

					var r = GridHelper.ConstruirFila(dgvDatos);
					GridHelper.SetearFila(r, formaDePago);
					GridHelper.AgregarFila(r, dgvDatos);

					MessageBox.Show("Registro agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

				}
				else
				{
					MessageBox.Show("Registro duplicado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}

		private void tsbCerrar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void tsbEditar_Click(object sender, EventArgs e)
		{
			if (dgvDatos.SelectedRows.Count == 0)
			{
				return;
			}
			try
			{
				var r = dgvDatos.SelectedRows[0];
				FormaDePago formaDePago;
				if (r.Tag != null)
				{
					formaDePago = (FormaDePago)r.Tag;
					frmFormaDePagoAE frm = new frmFormaDePagoAE() { Text = "Editar" };
					frm.SetFormaDePago(formaDePago);
					DialogResult dr = frm.ShowDialog(this);

					if (DialogResult == DialogResult.Cancel)
					{
						return;
					}
					formaDePago = frm.GetFormaDePago();
					if (!_servicio.Existe(formaDePago))
					{
						_servicio.Guardar(formaDePago);
						GridHelper.SetearFila(r, formaDePago);
						MessageBox.Show("Registro editado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

					}
					else
					{
						MessageBox.Show("Edicion denegad. Registro existente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

					}
				}



			}
			catch (Exception)
			{

				throw;
			}
		}

		private void tsbBorrar_Click(object sender, EventArgs e)
		{
			if (dgvDatos.SelectedRows.Count == 0)
			{
				return;
			}
			var r = dgvDatos.SelectedRows[0];
			FormaDePago? formaDePago = null!;
			if (r.Tag != null)
			{
				formaDePago = (FormaDePago)r.Tag;
			}
			try
			{
				DialogResult dr = MessageBox.Show($"Desea borrar el registro {formaDePago.Descripcion}", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
				if (dr == DialogResult.No)
				{
					return;
				}
				//if (!_servicio.EstaRelacionado(formaDePago.FormaDePagoId))
				//{
					_servicio.Borrar(formaDePago.FormaDePagoId);
				QuitarFila(r);
					MessageBox.Show("Registro borrado exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);


				//}
				//else
				//{
				//	MessageBox.Show("No se pudo borrar, registro relacionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

				//}

			}
			catch (Exception)
			{

				throw;
			}
		}

		private void QuitarFila(DataGridViewRow r)
		{
			dgvDatos.Rows.Remove(r);
		}
	}
}
