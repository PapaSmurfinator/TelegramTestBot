using TelegramTestBot.Models;

namespace TelegramTestBot.Extensions
{
    public static class TypeExtensions
    {
        public static string AsString(this OrderPaymentMethods paymentMethod)
        {
            return paymentMethod switch
            {
                OrderPaymentMethods.Cash => "Наличными",
                OrderPaymentMethods.Online => "Онлайн",
                _ => "Не определен."
            };
        }
    }
}
