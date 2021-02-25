
using Core.CrossCuttingConcerns.Check.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Check
{
    public class CheckTool
    {
        public static void Check(ICheckService checkService)
        {
            
            var result = checkService.Check();
            if (!result.Success)
            {
                throw new SystemException("Kural Ihlali !");
            }
        }
    }

    
}
