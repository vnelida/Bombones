using Bombones.Entidades.Dtos;

namespace Bombones.Servicios.Intefaces
{
    public interface IServiciosBombones
    {
		int Cantidad();
		List<BombonListDto> GetLista();
		List<BombonListDto> GetLista(int? currentPage, int? pageSize);
	}
}
