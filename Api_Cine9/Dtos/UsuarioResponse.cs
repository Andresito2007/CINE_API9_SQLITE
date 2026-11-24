namespace Api_Cine9.Dtos;

// RESPUESTA DEL REGISTRO Y DEL ENDPOINT "YO"
public class UsuarioResponse(string id, string correo)
{
    public string Id { get; } = id;
    public string Correo { get; } = correo;
}
