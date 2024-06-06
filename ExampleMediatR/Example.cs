using MediatR;

namespace ExampleMediatR
{
    public class Example
    {


    }


    public class MyQuery : IRequest<MyResponse>
    {
        public string Data { get; set; }
    }

    public class MyQueryHandler : IRequestHandler<MyQuery, MyResponse>
    {
        public async Task<MyResponse> Handle(MyQuery request, CancellationToken cancellationToken)
        {
            return new MyResponse { ProcessedData = $"Processed: {request.Data}" };
        }
    }


    public class MyResponse
    {
        public string ProcessedData { get; set; }
    }
}
