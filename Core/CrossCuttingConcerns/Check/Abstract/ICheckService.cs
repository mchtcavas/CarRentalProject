using Core.Entities;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Check.Abstract
{
    public interface ICheckService
    {
        IResult Check();
    }
}
