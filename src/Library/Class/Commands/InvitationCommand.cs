using Telegram.Bot.Types;
using Telegram.Bot;
using System;
using System.Threading;
using System.Threading.Tasks;
using Library;


namespace src.Library.Class.Commands
{
    public class InvitationCommand : BaseCommand
    {
        private int num;
        public InvitationCommand(BaseCommand next) : base(next)
        {
            this.Keywords = new string[] { "/invitacion" };
            // this.Next = next;
            // this.num = 0;
        }

        
        protected override bool InternalHandle(Message message, out string response)
        {
            if (message.Text.ToLower().Equals("/invitacion"))
            {
                this.num = 1;
                response = "¿Qué empresa quieres invitar?";
                return true;
            }
            
            if (this.num == 1){
                this.num = 2;
                response = "gracias " + message;
                return true;
            }
            // else{
            //     response = "NO gracias " + this.num.ToString();
            //     return true;
            // }
            
            response = string.Empty;
            return false;


        }
    }
}