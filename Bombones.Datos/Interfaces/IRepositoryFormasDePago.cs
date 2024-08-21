using Bombones.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones.Datos.Interfaces
{
	public interface IRepositoryFormasDePago
	{
		void Agregar(FormaDePago formaDePago, SqlConnection conn, SqlTransaction tran);
		void Borrar(int formaDePagoId, SqlConnection conn, SqlTransaction tran);
		void Editar(FormaDePago formaDePago, SqlConnection conn, SqlTransaction tran);
		bool EstaRelacionado(int formaDePagoId, SqlConnection conn);
		bool Existe(FormaDePago formaDePago, SqlConnection conn);
		List<FormaDePago>? GetLista(SqlConnection conn);
	}
}
