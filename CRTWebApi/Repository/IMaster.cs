using CRTWebApi.Model;


namespace CRTWebApi.Repository
{
    public interface IMaster
    {
        public Task<List<Master>> Getall();
        public Task<List<Master>> GetById(int id);
    }
}
