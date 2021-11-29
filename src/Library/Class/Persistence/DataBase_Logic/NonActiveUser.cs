using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Library;
using src.Library.Class.Persistence.Lists;

namespace src.Library.Class.Persistence.DataBase_Logic
{
    public class NonActiveUser{
        public int IdUser { get; private set; }
        public string App { get; private set; }
        public string Token { get; private set; }
        public NonActiveUser(int idUser, string app, string token){
            this.IdUser = idUser;
            this.App = app;
            this.Token = token;
        }

    }
}