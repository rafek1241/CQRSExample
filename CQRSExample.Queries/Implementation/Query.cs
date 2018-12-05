using CQRSExample.Queries.Interface;

namespace CQRSExample.Queries.Implementation
{
    public abstract class Query : IQuery
    {
        public string Connection { get; }


        public Query(string connection)
        {
            Connection = connection;
        }

    }
}
