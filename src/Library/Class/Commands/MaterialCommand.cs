using Telegram.Bot.Types;
using Library;
using System;

namespace FINAL_WORK_PII_2021.src.Library.Class.Commands
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
                response = "material";
                return true;
            }

            response = string.Empty;
            return false;
        }
    }
}
