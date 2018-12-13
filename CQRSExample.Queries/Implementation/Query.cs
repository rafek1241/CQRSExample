using CQRSExample.Queries.Interface;

namespace CQRSExample.Queries.Implementation
{
    public abstract class Query : IQuery
    {
        public Query(string connection)
        {
            Connection = connection;
        }

        public string Connection { get; }
    }
}