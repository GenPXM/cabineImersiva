using CabineImersivaApi.Utils;
using CabineImersivaApi.DTO;

namespace CabineImersivaApi.Service.Interface
{
    public interface IUsuarioService
    {
        Task<RespostaPadrao> CadastrarUsuario(UsuarioDto usuario);
        Task<RespostaPadrao> BuscarUsuario();
        Task<RespostaPadrao> BuscarUsuarioId (int id);
        Task<RespostaPadrao> BuscarPorCpf(string cpf);
        Task<RespostaPadrao> AtualizarUsuario(AtualizarUsuarioDto usuarioDto, int id);
        Task<RespostaPadrao> Deletar(int id);

    }
}
