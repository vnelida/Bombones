using Bombones.Entidades.Dtos;
using Bombones.Entidades.Entidades;
using Bombones.Servicios.Intefaces;
using Bombones.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Drawing.Printing;

namespace Bombones.Windows.Formularios
{
	public partial class frmBombones : Form
	{
		private List<BombonListDto> lista = null!;
		private readonly IServiciosBombones? _servicio;

		
		private int currentPage = 1;//pagina actual
		private int totalPages = 0;//total de paginas
		private int pageSize = 10;//registros por página
		private int totalRecords = 0;//cantidad de registros

		public frmBombones(IServiceProvider? serviceProvider)
		{
			InitializeComponent();
			_servicio = serviceProvider?.GetService<IServiciosBombones>()
				?? throw new ApplicationException("Dependencias no cargadas!!!"); ;
		}

		private void tsbCerrar_Click(object sender, EventArgs e)
		{
			Close();
		}




		private void frmBombones_Load(object sender, EventArgs e)
		{
			try
			{
				//practica n
				totalRecords = _servicio.Cantidad();
				totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);
				LoadData();

				//lista = _servicio!.GetLista();      // la lista guarda el listado de los registros con los tipos de chocolate
				//MostrarDatosEnGrilla();
			}
			catch (Exception)
			{
				throw;
			}
		}

		private void LoadData()
		{
			lista = _servicio!.GetLista(currentPage, pageSize);      // la lista guarda el listado de los registros con los tipos de chocolate
			MostrarDatosEnGrilla(lista);

			if (cboPaginas.Items.Count != totalPages)
			{
				CombosHelper.CargarComboPaginas(ref cboPaginas, totalPages);
			}
			txtCantidadPaginas.Text = totalPages.ToString();
			cboPaginas.SelectedIndex = currentPage == 1 ? 0 : currentPage - 1;

		}

		private void MostrarDatosEnGrilla(List<BombonListDto> lista)
		{
			GridHelper.LimpiarGrilla(dgvDatos);
			foreach (var chocolate in lista)      // Recorre la lista de chocoltes
			{
				var r = GridHelper.ConstruirFila(dgvDatos);       // Se inicialia r con el resultado de ConstruirFila
				GridHelper.SetearFila(r, chocolate);         // Completa la fila r con el objeto chocolate, que es una fila de lista
				GridHelper.AgregarFila(r, dgvDatos);
			}
		}

		private void btnPrimero_Click(object sender, EventArgs e)
		{
			currentPage = 1;
			LoadData();

		}

		private void btnAnterior_Click(object sender, EventArgs e)
		{
			if (currentPage > 1)
			{
				currentPage--;
				LoadData();
			}
		}

		private void btnSiguiente_Click(object sender, EventArgs e)
		{
			if (currentPage < totalPages)
			{
				currentPage++;
				LoadData();
			}
		}

		private void btnUltimo_Click(object sender, EventArgs e)
		{
			currentPage = totalPages;
			LoadData();
		}

		private void cboPaginas_SelectedIndexChanged(object sender, EventArgs e)
		{
			currentPage = int.Parse(cboPaginas.Text);
			LoadData();
		}
	}
}
