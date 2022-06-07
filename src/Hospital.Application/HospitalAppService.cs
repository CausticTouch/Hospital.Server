using System;
using System.Collections.Generic;
using System.Text;
using Hospital.Localization;
using Volo.Abp.Application.Services;

namespace Hospital;

/* Inherit your application services from this class.
 */
public abstract class HospitalAppService : ApplicationService
{
    protected HospitalAppService()
    {
        LocalizationResource = typeof(HospitalResource);
    }
}
