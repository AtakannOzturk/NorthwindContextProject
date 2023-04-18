using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        //Kullanıcı bilgisi ve rolleri verildi.
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}

 