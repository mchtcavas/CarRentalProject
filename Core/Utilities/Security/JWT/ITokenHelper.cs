﻿using Core.Entities.Concrete;
using NuGet.Protocol.Plugins;
using System;
using System.Collections.Generic;
using System.Text;
using OperationClaim = Core.Entities.Concrete.OperationClaim;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
