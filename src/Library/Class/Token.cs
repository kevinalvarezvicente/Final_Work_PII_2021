using System;
using System.Collections.Generic;

namespace src.Library.Class
{
    public class Token
    {
        /// <param name="ListToken">Lista de los tokens creados con su identificador.</param>
        //private List<Token> listToken = new List<Token>();
        public string numberToken { get; set; }
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Token"/>.
        /// </summary>
        public Token()
        {
            numberToken = "";
        }

        /// <summary>
        /// Instance an object of type Token.
        /// </summary>
        /// <returns>The token instantiated</returns>
        public void CreateToken()
        {
            this.numberToken = this.GenerateCode();
        }

        /// <summary>
        /// Generate the encrypt token.
        /// </summary>
        /// <returns>The encrypted token </returns>
        public string GenerateCode()
        {
            //<summary>
            //Instance a guid object called gToken
            //</summary>
            //<param name = "gToken"> Globally unique identifier of 16 digits </param>
            Guid gToken = Guid.NewGuid();
            //<summary>
            //Converts the variable of guid type to an array.
            //</summary
            //<param name = "aToken"> A 16 element byte array </param>
            byte[] aToken = gToken.ToByteArray();
            //<summary>
            //Encrypts te array of 16 elements to base 64
            //</summary>
            //<param name = "eToken"> Encrypted token to base 64</param>
            string eToken = Convert.ToBase64String(aToken);
            
            return eToken;
        }

    }
}

