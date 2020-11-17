namespace Runtime.Data.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IRepositoryFactory
    {
        T Create<T>(T obj) where T : IEntity;
        T Update<T>(T obj) where T : IEntity;
        void Delete<T>(T obj) where T : IEntity;
    }
}
