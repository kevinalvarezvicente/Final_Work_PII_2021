using Telegram.Bot.Types;
using Library;
using System;

namespace FINAL_WORK_PII_2021.src.Library.Class.Commands
{
    public class PublicationCommand : BaseCommand
    {
        string[] Questions = {"Que material quieres publicar?","Nombre de la empresa?","Fecha de publicacion?"};
        string[] Answers = {"","",""};
        int iQuestions = 0;
        bool publicationActive = false;
        public PublicationCommand(BaseCommand next) : base(next)
        {
            this.Keywords = new string[] { "/publicar" };
        }
        protected override bool InternalHandle(Message message, out string response)
        {
            if (publicationActive)
            {
                response = Questions[iQuestions];
                Answers[iQuestions] = message.Text;
                iQuestions++;
                if (iQuestions > 2)
                {
                    this.publicationActive = false;
                }
                return true;
            }
            else
            {
                if (message.Text.ToLower().Equals("/publicar"))
                {
                    //publish.GeneratePublication();
                    response = "Nombre de la publicacion?";

                    this.publicationActive = true;
                    return true;
                }

                response = string.Empty;
                return false;
            }
        }
    }
}
