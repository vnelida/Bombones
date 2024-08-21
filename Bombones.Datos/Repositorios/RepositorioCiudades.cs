using Bombones.Datos.Interfaces;
using Bombones.Entidades.Dtos;
using Bombones.Entidades.Entidades;
using Bombones.Entidades.Enumeraciones;
using Dapper;
using System.Data.SqlClient;

namespace Bombones.Datos.Repositorios
{
    public class RepositorioCiudades : IRepositorioCiudades
    {
        public RepositorioCiudades()
        {
             
        }

        public void Agregar(Ciudad ciudad, SqlConnection conn, SqlTransaction tran)
        {
            string insertQuery = @"INSERT INTO Ciudades 
                (NombreCiudad, PaisId, ProvinciaEstadoId) 
                VALUES (@NombreCiudad, @PaisId, @ProvinciaEstadoId); 
                SELECT CAST(SCOPE_IDENTITY() as int)";

            int primaryKey = conn.QuerySingle<int>(insertQuery, ciudad,tran);
            if (primaryKey > 0)
            {
                ciudad.CiudadId = primaryKey;
                return;
            }
            throw new Exception("No se pudo agregar Ciudad");
        }

        public void Borrar(int ciudadId, SqlConnection conn, SqlTransaction tran)
        {
            var deleteQuery = @"DELETE FROM Ciudades 
                WHERE CiudadId=@CiudadId";
            int registrosAfectados = conn
                .Execute(deleteQuery, new { ciudadId },tran);
            if (registrosAfectados == 0)
            {
                throw new Exception("No se pudo borrar la ciudad");
            }
        }

        public void Editar(Ciudad ciudad, SqlConnection conn, SqlTransaction tran)
        {
            var updateQuery = @"UPDATE Ciudades
            SET NombreCiudad=@NombreCiudad,
                PaisId=@PaisId,
                ProvinciaEstadoId=@ProvinciaEstadoId
                WHERE CiudadId=@CiudadId";
            int registrosAfectados = conn.Execute(updateQuery, ciudad,tran);
            if (registrosAfectados == 0)
            {
                throw new Exception("No se pudo editar ciudad");
            }

        }

        public bool EstaRelacionado(int ciudadId, SqlConnection conn, SqlTransaction? tran = null)
        {
            var selectQuery = @"SELECT COUNT(*) FROM Fabricas 
                WHERE CiudadId=@CiudadId";
            return conn.QuerySingle<int>
                (selectQuery, new { ciudadId }) > 0;
        }

        public bool Existe(Ciudad ciudad, SqlConnection conn, SqlTransaction? tran = null)
        {
            string selectQuery = @"SELECT COUNT(*) FROM Ciudades ";
            string condicionalQuery = string.Empty;
            string finalQuery = string.Empty;
            condicionalQuery = ciudad.CiudadId == 0 ?
                " WHERE NombreCiudad=@NombreCiudad AND PaisId=@PaisId " :
                " WHERE NombreCiudad=@NombreCiudad AND PaisId=@PaisId " +
                "AND CiudadId<>@CiudadId";
            finalQuery = string.Concat(selectQuery, condicionalQuery);
            return conn.QuerySingle<int>(finalQuery, ciudad) > 0;
        }

        public int GetCantidad(SqlConnection conn, Pais? paisSeleccionado, ProvinciaEstado? provSeleccionada, SqlTransaction? tran = null)
        {
            var selectQuery = "SELECT COUNT(*) FROM Ciudades";
            List<string> conditions= new List<string>();

            if (paisSeleccionado != null)
            {
                conditions.Add(" WHERE PaisId = @PaisId");
               
            }
            if (provSeleccionada != null)
            {
                conditions.Add("ProvinciaEstadoId= @ProvinciaEstadoId");
            }
            if (conditions.Any())
            {
                selectQuery += string.Join(" AND ", conditions);
                return conn.ExecuteScalar<int>(selectQuery, new {@PaisId=paisSeleccionado?.PaisId,
                    @ProvinciaEstadoId=provSeleccionada?.ProvinciaEstadoId
                });

            }
            return conn.ExecuteScalar<int>(selectQuery);
        }

        public Ciudad? GetCiudadPorId(int ciudadId, SqlConnection conn)
        {
            string selectQuery = @"SELECT CiudadId, NombreCiudad, 
                PaisId, ProvinciaEstadoId FROM Ciudades 
                WHERE CiudadId=@CiudadId";
            return conn.QuerySingleOrDefault<Ciudad>(
                selectQuery, new {@CiudadId= ciudadId });
        }


        public List<CiudadListDto> GetLista(SqlConnection conn, int? currentPage, int? pageSize,
			Orden? orden = Orden.Ninguno, SqlTransaction? tran = null)
        {
			var selectQuery = @"SELECT c.CiudadId, c.NombreCiudad, pe.NombreProvinciaEstado, p.NombrePais 
                    FROM Ciudades c INNER JOIN ProvinciasEstados pe on c.ProvinciaEstadoId=pe.ProvinciaEstadoId
                    INNER JOIN Paises p ON pe.PaisId = p.PaisId";

			List<string> conditions = new List<string>();



			if (conditions.Any())
			{
				selectQuery += " WHERE " + string.Join(" AND ", conditions);
			}
			string orderBy = string.Empty;

			switch (orden)
			{
				case Orden.Ninguno:
					orderBy = " ORDER BY pe.ProvinciaEstadoId ";
					break;
				case Orden.PaisAZ:
					orderBy = " ORDER BY p.NombrePais ";

					break;
				case Orden.PaisZA:
					orderBy = " ORDER BY p.NombrePais DESC ";

					break;
				case Orden.ProvinciaEstadoAZ:
					orderBy = " ORDER BY pe.NombreProvinciaEstado ";

					break;

				case Orden.CiudadZA:
					orderBy = " order by c.NombreCiudad DESC ";

					break;
				case Orden.CiudadAZ:
					orderBy = " order by c.NombreCiudad ASC ";

					break;

				default:
					orderBy = " ORDER BY pe.NombreProvinciaEstado DESC ";

					break;


			}
			selectQuery += orderBy;
			

			if (currentPage.HasValue && pageSize.HasValue)
			{
				var offSet = (currentPage.Value - 1) * pageSize;
				selectQuery += $" OFFSET {offSet} ROWS FETCH NEXT {pageSize.Value} ROWS ONLY";
			}

			return conn.Query<CiudadListDto>(selectQuery).ToList();








			//string selectQuery = @"SELECT c.CiudadId, c.NombreCiudad, 
   //             p.NombrePais, pe.NombreProvinciaEstado FROM Ciudades c
   //             INNER JOIN Paises p ON c.PaisId=p.PaisId INNER JOIN 
   //             ProvinciasEstados pe ON c.ProvinciaEstadoId=pe.ProvinciaEstadoId";

   //         selectQuery += " ORDER BY c.NombreCiudad";
   //         if (currentPage.HasValue && pageSize.HasValue)
   //         {
   //             var offSet = (currentPage.Value - 1) * pageSize;
   //             selectQuery += $" OFFSET {offSet} ROWS FETCH NEXT {pageSize.Value} ROWS ONLY";
   //         }
   //         return conn.Query<CiudadListDto>(selectQuery).ToList();

        }

        public List<Ciudad> GetListaCombo(SqlConnection conn, Pais paisSeleccionado, ProvinciaEstado provinciaEstado)
        {
            string selectQuery = @"SELECT CiudadId, NombreCiudad, 
                PaisId, ProvinciaEstadoId FROM Ciudades 
                WHERE PaisId=@PaisId AND ProvinciaEstadoId=@ProvinciaEstadoId";
            return conn.Query<Ciudad>(selectQuery, new
            {
                @PaisId = paisSeleccionado.PaisId,
                @ProvinciaEstadoId = provinciaEstado.ProvinciaEstadoId
            }).ToList();
        }

        public int GetPaginaPorRegistro(SqlConnection conn, string nombreCiudad, int pageSize, SqlTransaction? tran = null)
        {
            var positionQuery = @"
                    WITH CiudadOrdenada AS (
                    SELECT 
                        ROW_NUMBER() OVER (ORDER BY NombreCiudad) AS RowNum,
                        NombreCiudad
                    FROM 
                        Ciudades
                )
                SELECT 
                    RowNum 
                FROM 
                    CiudadOrdenada 
                WHERE 
                    NombreCiudad = @NombreCiudad";

            int position = conn.ExecuteScalar<int>(positionQuery, new { NombreCiudad = nombreCiudad });
            return (int)Math.Ceiling((decimal)position / pageSize);

        }
    }
}
