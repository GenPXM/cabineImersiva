using AutoMapper;
using CabineImersivaApi.Data;
using CabineImersivaApi.DTO;
using CabineImersivaApi.Models;
using CabineImersivaApi.Service.Interface;
using CabineImersivaApi.Utils;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace CabineImersivaApi.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly AppDbContext _DbContext;
        private readonly IMapper _mapper;

        public UsuarioService(AppDbContext context, IMapper mapper) 
        {
            _DbContext = context;
            _mapper = mapper;
        
        }

        public Task<RespostaPadrao> AtualizarUsuario(AtualizarUsuarioDto usuarioDto, int id)
        {
            throw new NotImplementedException();
        }

        public Task<RespostaPadrao> BuscarPorCpf(string cpf)
        {
            throw new NotImplementedException();
        }

        public Task<RespostaPadrao> BuscarUsuario()
        {
            throw new NotImplementedException();
        }

        public Task<RespostaPadrao> BuscarUsuarioId(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<RespostaPadrao> CadastrarUsuario(UsuarioDto usuarioDto)
        {
            RespostaPadrao resposta = new RespostaPadrao();
            Usuario usuario = _mapper.Map<Usuario>(usuarioDto);
            try
            {
                UsuarioDto cadastrarUsuarioDto = new UsuarioDto();
                usuarioDto.Nome = usuario.Nome;
                usuarioDto.Sobrenome = usuario.Sobrenome;
                usuarioDto.CPF = usuario.CPF;
                usuarioDto.Telefone = usuario.Telefone;
                await _DbContext.Usuarios.AddAsync(usuario);
                await _DbContext.SaveChangesAsync();

                resposta.SetSucesso("Cadastro efetuado com sucesso!",usuario);
                return resposta;
                
               

            }
            catch (Exception ex)
            {
                resposta.SetBadRequest(ex.Message);
                return resposta;
            }
        }

        public Task<RespostaPadrao> Deletar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
