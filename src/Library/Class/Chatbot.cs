using Telegram.Bot;
using Telegram.Bot.Types;

namespace Library
{
    /// <summary>
    /// Clase realizada con el patrón singleton
    /// Se crea una unica instancia de esta clase y en cuyo caso de que se quiera crear otro devuelve al anterior.
    /// </summary>
    public class TelegramBot
    {

        /// <value>Guarda el identificador unico del bot de Telegram.</value>
        private const string TELEBRAM_BOT_TOKEN = "2085142257:AAGK0NCrRqZDJ4yfX1P_hH5CGp1dzBupn3Y";

        private static TelegramBot instance;
        private ITelegramBotClient bot;

        private TelegramBot()
        {
            this.bot = new TelegramBotClient(TELEBRAM_BOT_TOKEN);
        }

        public ITelegramBotClient Client
        {
            get
            {
                return this.bot;
            }
        }

        private User BotInfo
        {
            get
            {
                return this.Client.GetMeAsync().Result;
            }
        }

        public int BotId
        {
            get
            {
                return (int)this.BotInfo.Id;
            }
        }

        public string BotName
        {
            get
            {
                return this.BotInfo.FirstName;
            }
        }

        public static TelegramBot Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TelegramBot();
                }
                return instance;
            }
        }
    }
}