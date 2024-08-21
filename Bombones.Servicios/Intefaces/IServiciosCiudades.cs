using Bombones.Entidades.Dtos;
using Bombones.Entidades.Entidades;
using Bombones.Entidades.Enumeraciones;

namespace Bombones.Servicios.Intefaces
{
    public interface IServiciosCiudades
    {
        void Borrar(int ciudadId);
        bool EstaRelacionado(int ciudadId);
        bool Existe(Ciudad ciudad);
        int GetCantidad(Pais? paisSeleccionado=null, ProvinciaEstado? provSeleccionada=null);
        Ciudad? GetCiudadPorId(int ciudadId);
        List<CiudadListDto> GetLista(int? currentPage, int? pageSize, Orden? orden = Orden.Ninguno);
        List<Ciudad> GetListaCombo(Pais paisSeleccionado, ProvinciaEstado provinciaEstado);
        int GetPaginaPorRegistro(string nombreCiudad, int pageSize);
        void Guardar(Ciudad ciudad);
    }
}
