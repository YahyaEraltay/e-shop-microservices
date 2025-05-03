using MediatR;

namespace Catalog.API.Products.CreateProduct;

public record CreateProductCommand(string name, List<string> Category, string Description, string ImageFile, string Price) : IRequest<CreateProductResult>;
public record CreateProductResult(Guid id);

internal class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
{
    public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {

    }
}
