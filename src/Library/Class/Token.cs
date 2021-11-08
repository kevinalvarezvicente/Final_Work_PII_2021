using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Token : IValidateToken
    {
        private List<Token> ListToken = new List<Token>();

        public Token() {
            idToken = 0;
            numberToken = Guid.Empty;
        }

        public int idToken { get; private set; }

        public Guid numberToken { get; private set; }

        public Token createToken(int id)
        {
            Token token1 = new Token();
            token1.idToken = id;
            token1.numberToken = token1.generateToken();
            this.ListToken.Add(token1);
            return token1;
        }


        public Guid generateToken() {
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
            string Etoken = Convert.ToBase64String(GToE); //Acá se guarda en la persistencia
            return Gtoken;
        }

        public bool isValid(Guid tokenv)
        {
            byte[] TToV = tokenv.ToByteArray();
            string Vtoken = Convert.ToBase64String(TToV);
            if (Vtoken == Etoken) //Acá se compara con la persistencia
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
    }
}
