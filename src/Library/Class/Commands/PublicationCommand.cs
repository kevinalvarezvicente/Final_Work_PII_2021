using Telegram.Bot.Types;
using Library;

namespace FINAL_WORK_PII_2021.src.Library.Class.Commands
{
    public class PublicationCommand : BaseCommand
    {
      
        public PublicationCommand(BaseCommand next) : base(next)
        {
            this.Keywords = new string[] { "/publish" };
        }
        protected override bool InternalHandle(Message message, out string response)
        {
            if (message.Text.ToLower().Equals("/publish"))
            {
                response = "Qué te gustaria Publicar?";
                // Publication publish = new Publication();
                // publish.generatePublication();
                return true;
            }

            response = string.Empty;
            return false;
        }
    }
}
