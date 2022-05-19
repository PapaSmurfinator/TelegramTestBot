using TelegramTestBot.Models;

namespace TelegramTestBot.Extended
{
    public class ExtendedOrder : Order
    {
        public bool? IsAccept { get; set; }
        public int? MessageId { get; set; }
    }
}
