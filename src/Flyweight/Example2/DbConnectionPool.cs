using System.Collections.Concurrent;
using System.Data;

namespace DesignPatternExamples.Flyweight.Example2
{
    public class DbConnectionPool
    {
        private ConcurrentStack<IDbConnection> _dbConnections;

        public int AvailableConnectionCount => _dbConnections.Count;

        public DbConnectionPool(int size = 10)
        {
            _dbConnections = new ConcurrentStack<IDbConnection>();
            for (int i = 0; i < size; i++)
            {
                _dbConnections.Push(new CustomDbConnection());
            }
        }

        public IDbConnection LeaseConnection()
        {
            _dbConnections.TryPop(out var dbConnection);
            return dbConnection;
        }
        
        public void ReturnConnection(IDbConnection connection)
        {
            _dbConnections.Push(connection);
        }
    }
}