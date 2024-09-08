using BuildingBlockCB.CQRS;
using Catalog.API.Models;
using MediatR;

namespace Catalog.API.products.CreateProduct
{
    public record CreateProductCommand(string Name,List<string> Category,string Description,string ImageFile, decimal Price) : ICommand<CreateProductResult>;

    public record CreateProductResult(Guid Id);
    internal class CreateproductCommandHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
    {
        public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            // Create product entity from command object
            //save to db
            //return createproductresult result

            var product = new Product
            {
                Name = command.Name,
                Category = command.Category,
                Description = command.Description,
                ImageFile = command.ImageFile,
                Price = command.Price
            };

            return new CreateProductResult(Guid.NewGuid());
           
        }
    }
}
