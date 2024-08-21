using Bombones.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones.Servicios.Intefaces
{
	public interface IServiceFormasDePago
	{
		void Borrar(int formaDePagoId);
		bool EstaRelacionado(int formaDePagoId);
		bool Existe(FormaDePago formaDePago);
		List<FormaDePago>? GetLista();
		void Guardar(FormaDePago formaDePago);
	}
}
