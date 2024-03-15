using MediatR;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Shop.Domain.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            // Verifica se o cliente já está cadastrado
            // Valida os dados
            // Insere o cliente
            // Envia e-mail de boas vindas

            var result = new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "André Baltiei",
                Email = "andre@balta.io",
                Date = DateTime.Now
            };

            return Task.FromResult(result);
        }
    }
}
