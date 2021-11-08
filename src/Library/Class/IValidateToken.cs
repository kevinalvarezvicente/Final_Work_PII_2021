using PII_Proyecto_Final_TEMP.src.Library.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public interface IValidateToken
    {
        bool isValid(Guid token);
    }
}