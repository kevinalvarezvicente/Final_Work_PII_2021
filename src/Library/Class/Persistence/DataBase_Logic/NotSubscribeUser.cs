using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Library;
using src.Library.Class.Persistence.Lists;

namespace src.Library.Class.Persistence.DataBase_Logic
{
    public class NotSubscribeUser{
        public int IdUser { get; private set; }
        public string App { get; private set; }
        public string Token { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idUser"></param>
        /// <param name="app"></param>
        /// <param name="token"></param>
        public NotSubscribeUser(int idUser, string app, string token){
            this.IdUser = idUser; //Names must be the same with some diferences between upper an lower characters for json.
            this.App = app;
            this.Token = token;
        }

    }
}