using System.Collections.Generic;
using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace Template.Bot.Commands
{
    public interface IBotCommand
    {
        string Command { get; }
        string Description { get; }
        Task<Message> Execute(Message message);
    }
}
