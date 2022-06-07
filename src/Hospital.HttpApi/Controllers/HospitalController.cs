using Hospital.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Hospital.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class HospitalController : AbpControllerBase
{
    protected HospitalController()
    {
        LocalizationResource = typeof(HospitalResource);
    }
}
