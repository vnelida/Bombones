using Bombones.Datos.Interfaces;
using Bombones.Entidades.Entidades;
using Bombones.Servicios.Intefaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones.Servicios.Servicios
{
	public class ServiceFormasDePago : IServiceFormasDePago
	{
		private readonly IRepositoryFormasDePago? _repositorio;
		private readonly string _cadena;

		public ServiceFormasDePago(IRepositoryFormasDePago? repositorio, string cadena)
		{
			_repositorio = repositorio;
			_cadena = cadena;
		}

		public void Borrar(int formaDePagoId)
		{
			using (var conn = new SqlConnection(_cadena))
			{
				conn.Open();
				using (var tran = conn.BeginTransaction())
				{
					try
					{
						_repositorio!.Borrar(formaDePagoId, conn, tran);
						tran.Commit();
					}
					catch (Exception)
					{
						tran.Rollback();
						throw;
					}
				}
			}
		}

		public bool EstaRelacionado(int formaDePagoId)
		{
			using (var conn = new SqlConnection(_cadena))
			{
				conn.Open();
				return _repositorio!.EstaRelacionado(formaDePagoId, conn);
			}
		}

		public bool Existe(FormaDePago formaDePago)
		{
			using (var conn = new SqlConnection(_cadena))
			{
				conn.Open();
				return _repositorio!.Existe(formaDePago, conn);
			}
		}

		public List<FormaDePago>? GetLista()
		{
			using (var conn = new SqlConnection(_cadena))
			{
				conn.Open();
				return _repositorio!.GetLista(conn);
			}
		}

		public void Guardar(FormaDePago formaDePago)
		{
			using (var conn = new SqlConnection(_cadena))
			{
				conn.Open();
				using (var tran = conn.BeginTransaction())
				{
					try
					{
						if (formaDePago.FormaDePagoId == 0)
						{
							_repositorio!.Agregar(formaDePago, conn, tran);
						}
						else
						{
							_repositorio!.Editar(formaDePago, conn, tran);
						}

						tran.Commit();
					}
					catch (Exception)
					{
						tran.Rollback();
						throw;
					}
				}
			}
		}
	}
}
