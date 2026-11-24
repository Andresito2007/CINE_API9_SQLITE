using Api_Cine9.Models;

namespace Api_Cine9.Repository;

// CONTRATO DEL REPOSITORIO DE CLIENTES
public interface IClienteRepository
{
    List<Cliente> ObtenerTodos();
    Cliente? ObtenerPorId(int id);

    // FUNCIONALIDADES FUTURAS A USAR EN EL CONTROLLER
    void Agregar(Cliente cliente);

    void Actualizar(Cliente cliente);

    void Eliminar(Cliente cliente);
}
