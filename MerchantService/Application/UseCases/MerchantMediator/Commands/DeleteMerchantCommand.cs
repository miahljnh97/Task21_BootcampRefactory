using System;
using MediatR;
using MerchantService.Application.UseCases.MerchantMediator.Request;

namespace MerchantService.Application.UseCases.MerchantMediator.Commands
{
    public class DeleteMerchantCommand : IRequest<MerchantDTO>
    {
        public int Id { get; set; }

        public DeleteMerchantCommand(int id)
        {
            Id = id;
        }
    }
}
