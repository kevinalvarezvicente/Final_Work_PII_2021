using Telegram.Bot.Types;
using Library;
using System;

namespace src.Library.Class.Commands
{
    public class MaterialCommand : BaseCommand
    {
      
        public MaterialCommand(BaseCommand next) : base(next)
        {
            this.Keywords = new string[] { "/material" };
        }
        protected override bool InternalHandle(Message message, out string response)
        {
            if (message.Text.ToLower().Equals("/material"))
            {
                response = "Que residuo quieres crear?";
                return true;
            }

            response = string.Empty;
            return false;
        }
    }
}
