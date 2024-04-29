
using CRTWebApi.Repository;

namespace CRTWebApi.Model
{
    public class Master : IMaster
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = "Empty";

        private static readonly List<Master> masters = new List<Master>
        {
        new Master { Id = 1, Name="rahul"},
        new Master { Id = 2, Name="Lokesh"},
        new Master { Id = 3, Name="Bhavesh"},
        new Master { Id = 4, Name="Praveen"}
        };

        public Task<List<Master>> Getall()
        {
            return Task.FromResult(masters);
        }
        public Task<List<Master>> GetById(int id)
        {
            var data = masters.Where(a => a.Id == id).ToList();
            if (data != null)
            {
                return Task.FromResult(data);
            }
            else
            {
                return Task.FromResult(masters);
            }
        }
    }
}
