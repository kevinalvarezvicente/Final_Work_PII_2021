using Telegram.Bot.Types;
using Library;
using System;

namespace FINAL_WORK_PII_2021.src.Library.Class.Commands
{
    public class PublicationCommand : BaseCommand
    {
      
        public PublicationCommand(BaseCommand next) : base(next)
        {
            this.Keywords = new string[] { "/publicar" };
        }
        protected override bool InternalHandle(Message message, out string response)
        {
            if (message.Text.ToLower().Equals("/publicar"))
            {
                //publish.GeneratePublication();
                response = "publicar";


                return true;
            }

            response = string.Empty;
            return false;
        }
    }
}
