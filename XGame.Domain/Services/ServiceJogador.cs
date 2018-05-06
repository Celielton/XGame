using System;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Interfaces.Repositories;
using XGame.Domain.Interfaces.Services;

namespace XGame.Domain.Services
{
    public class ServiceJogador : IServiceJogador
    {
        private readonly IRepositoryJogador _repository;

        public ServiceJogador(IRepositoryJogador repository)
        {
            _repository = repository;
        }

        public AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request)
        {
           Guid id =  _repository.AdicionarJogador(request);
            return new AdicionarJogadorResponse() { Id = id, Message = "Operação realizada com sucesso!" };
        }

        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request)
        {
            return _repository.AutenticarJogador(request);
        }
    }
}
