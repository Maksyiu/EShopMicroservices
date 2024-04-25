using BuildingBlocks.CQRS;
using CatalogAPI.Models;
using MediatR;
using System.ComponentModel;

namespace CatalogAPI.Products.CreatePoduct
{
    public record CreateProductCommand(string Name, List<string> Category, string Description, 
        string ImageFile, decimal Price) 
        : ICommand<CreateProductResult>;
    public record CreateProductResult(Guid Id);

    internal class CreateProductCommandHandler 
        : ICommandHandler<CreateProductCommand, CreateProductResult>
    {
        public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            // Business logic to create a product
            // create product entity
            // save to database
            // return createproduct result

            var product = new Product
            {
                Name = command.Name,
                Category = command.Category,
                Description = command.Description,
                ImageFile = command.ImageFile,
                Price = command.Price
            };

            // TODO: save to database - pozniej to zrobimy

            // return result

            return new CreateProductResult(Guid.NewGuid());            
        }
    }
}
