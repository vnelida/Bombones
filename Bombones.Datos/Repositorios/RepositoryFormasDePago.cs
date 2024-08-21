using Bombones.Datos.Interfaces;
using Bombones.Entidades.Entidades;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones.Datos.Repositorios
{
	public class RepositoryFormasDePago : IRepositoryFormasDePago
	{
		public void Agregar(FormaDePago formaDePago, SqlConnection conn, SqlTransaction tran)
		{
			int primaryKey = -1;
			string insertQuery = @"INSERT INTO FormaDepago (Descripcion) 
                VALUES(@Descripcion); SELECT CAST(SCOPE_IDENTITY() as int)";

			primaryKey = conn.QuerySingle<int>(insertQuery, formaDePago, tran);
			if (primaryKey > 0)
			{
				formaDePago.FormaDePagoId = primaryKey;
				return;
			}

			throw new Exception("No se pudo agregar el registro");
		}

		public void Borrar(int formaDePagoId, SqlConnection conn, SqlTransaction tran)
		{
			string deleteQuery = @"DELETE FROM FormaDePago 
                WHERE FormaDePagoId=@FormaDePagoId";
			int registrosAfectados = conn
				.Execute(deleteQuery, new { formaDePagoId }, tran);
			if (registrosAfectados == 0)
			{
				throw new Exception("No se pudo borrar el registro");
			}
		}

		public void Editar(FormaDePago formaDePago, SqlConnection conn, SqlTransaction tran)
		{
			string updateQuery = @"UPDATE FormaDePago SET Descripcion=@Descripcion 
                WHERE FormaDePagoId=@FormaDePagoId";

			int registrosAfectados = conn.Execute(updateQuery, formaDePago, tran);
			if (registrosAfectados == 0)
			{
				throw new Exception("No se pudo editar el registro");
			}
		}

		public bool EstaRelacionado(int formaDePagoId, SqlConnection conn)
		{
			try
			{
				string selectQuery = @"SELECT COUNT(*) 
                        FROM Ventas 
                            WHERE FormaDePagoId=@FormaDePagoId";
				return conn.
					QuerySingle<int>(selectQuery, new { formaDePagoId }) > 0;

			}
			catch (Exception)
			{

				throw new Exception("No se pudo comprobar si existe el registro");
			}
		}

		public bool Existe(FormaDePago formaDePago, SqlConnection conn)
		{
			try
			{
				string selectQuery = @"SELECT COUNT(*) FROM FormaDePago ";
				string finalQuery = string.Empty;
				string conditional = string.Empty;
				if (formaDePago.FormaDePagoId == 0)
				{
					conditional = "WHERE Descripcion = @Descripcion";
				}
				else
				{
					conditional = @"WHERE Descripcion = @Descripcion
                            AND FormaDePagoId<>@FormaDePagoId";
				}
				finalQuery = string.Concat(selectQuery, conditional);
				return conn.QuerySingle<int>(finalQuery, formaDePago) > 0;

			}
			catch (Exception)
			{

				throw new Exception("No se puede comprobar si existe");
			}
		}

		public List<FormaDePago>? GetLista(SqlConnection conn)
		{
			var selectQuery = @"Select * from FormaDePago order by Descripcion";
			
			return conn.Query < FormaDePago>(selectQuery).ToList();
		}
	}
}
