using EntitiesCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesCL
{
    public interface IInstitutionService
    {
        Institution GetInstitutionByID(long institutionID);
    }
}
