using EntitiesCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesCL
{
    public class InstitutionService : IInstitutionService
    {
        public Institution GetInstitutionByID(long institutionID)
        {
            return new Institution
            {
                InstitutionID = institutionID,
                Name = "Demo Institution",
                Address = "Demo Address",
                Telephone = "0123456789"
            };
        }
    }
}
