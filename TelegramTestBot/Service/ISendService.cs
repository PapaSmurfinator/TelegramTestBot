using System.Threading.Tasks;
using TelegramTestBot.Models;
using TelegramTestBot.Contract;

namespace TelegramTestBot.Service
{
    public interface ISendService
    {
        Task SendStatus(RequestData requestData);
        Task<CheckPartnerResponseModel> ConfirmPassword(string phoneNumber);
    }
}
