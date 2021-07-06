using MediatR;
using System.Collections.Generic;

namespace CarChangeApi.Queries
{
    public class TestQuery
    {
        public class Query : IRequest<IEnumerable<string>> { }
        public class Handler : RequestHandler<Query, IEnumerable<string>>
        {
            private readonly IEnumerable<string> _db = new List<string>() { "asd", "ddd", "324" };
            public Handler(IEnumerable<string> db)
            {
                //_db = db;
            }
            protected override IEnumerable<string> Handle(Query request)
            {
                return _db;
            }
        }
    }
}
