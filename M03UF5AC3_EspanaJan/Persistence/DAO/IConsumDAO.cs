using M03UF5AC3_EspanaJan.DTOs;
namespace M03UF5AC3_EspanaJan.Persistence.DAO
{
    public interface IConsumDAO
    {
        public List<ConsumDTO> GetAllConsum();
        public void AddConsum(ConsumDTO consum);
    }
}
