using System;
using System.Collections.Generic;

namespace PII_Proyecto_Final_TEMP.src.Library.Class
{
    public class Token
    {
        private List<Token> ListToken = new List<Token>();

        public Token() {
            idToken = 0;
            numberToken = "";
        }

        public int idToken { get; set; }

        public string numberToken { get; set; }

        public Token createToken(int id)
        {
            Token token1 = new Token();
            token1.idToken = id;
            token1.numberToken = token1.generateToken();
            this.ListToken.Add(token1);
            return token1;
        }


        public string generateToken() {
            //<summary>
            //Crea un objeto de tipo Guid
            //</summary>
            //<param name = "Gtoken"> Identificador único de 32 dígitos </param>
            Guid Gtoken = Guid.NewGuid();
            //<summary>
            //Guarda los datos de la variable Gtoken en un array de bits
            //</summary
            //<param name = "GToE"> Array de bits </param>
            byte[] GToE = Gtoken.ToByteArray();
            //<summary>
            //Cifra el token y lo guarda en Etoken
            //</summary>
            //<param name = "Etoken"> String con el token cifrado </param>
            string Etoken = Convert.ToBase64String(GToE);
            Console.WriteLine(Etoken);
            return Etoken;
        }
       
    }
}
