using Bombones.Datos.Interfaces;
using Bombones.Entidades.Dtos;
using Bombones.Entidades.Entidades;
using Dapper;
using System.Data.SqlClient;

namespace Bombones.Datos.Repositorios
{
	public class RepositorioBombones : IRepositorioBombones
	{
		public int GetCantidad(SqlConnection conn)
		{
			var selectQuery = "SELECT COUNT(*) FROM Bombones";
			List<string> conditions = new List<string>();

			return conn.ExecuteScalar<int>(selectQuery);
		}

		public List<BombonListDto> GetLista(SqlConnection conn, SqlTransaction? tran = null)
        {
            var selectQuery = @"SELECT b.BombonId, 
                                   b.NombreBombon, 
                                   tc.Descripcion AS TipoDeChocolate, 
                                   tn.Descripcion AS TipoDeNuez, 
                                   tr.Descripcion AS TipoDeRelleno, 
                                   f.NombreFabrica AS Fabrica, 
                                   b.Stock, 
                                   b.PrecioVenta AS Precio
                            FROM Bombones b 
                            INNER JOIN TiposDeChocolates tc ON b.TipoDeChocolateId = tc.TipoDeChocolateId
                            INNER JOIN TiposDeNueces tn ON b.TipoDeNuezId = tn.TipoDeNuezId
                            INNER JOIN TiposDeRellenos tr ON b.TipoDeRellenoId = tr.TipoDeRellenoId
                            INNER JOIN Fabricas f ON b.FabricaId = f.FabricaId";
            return conn.Query<BombonListDto>(selectQuery).ToList();

        }

		public List<BombonListDto> GetLista(SqlConnection conn, int? currentPage, int? pageSize)
		{
			string selectQuery = @"SELECT b.NombreBombon, tc.Descripcion, tr.Descripcion, tn.Descripcion, b.Stock, b.PrecioVenta
			FROM Bombones b INNER JOIN TiposDeChocolates tc on b.TipoDeChocolateId=tc.TipoDeChocolateId INNER JOIN TiposDeNueces tn 
				on b.TipoDeNuezId=tn.TipoDeNuezId INNER JOIN TiposDeRellenos tr on b.TipoDeRellenoId=tr.TipoDeRellenoId INNER JOIN Fabricas f 
				on f.FabricaId=b.FabricaId";

			selectQuery += " ORDER BY b.NombreBombon";
			if (currentPage.HasValue && pageSize.HasValue)
			{
				var offSet = (currentPage.Value - 1) * pageSize;
				selectQuery += $" OFFSET {offSet} ROWS FETCH NEXT {pageSize.Value} ROWS ONLY";
			}
			return conn.Query<BombonListDto>(selectQuery).ToList();
		}
	}
}
