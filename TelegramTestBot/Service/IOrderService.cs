using TelegramTestBot.Models;

namespace TelegramTestBot.Service
{
    public interface IOrderService
    {
        public string CreateDescriptionForPartner(OrderParameter orderParameter);
        public string CreateDescriptionForCron(OrderParameter orderParameter);

    }
}
