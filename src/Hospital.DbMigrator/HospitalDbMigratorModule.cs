using Hospital.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Hospital.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(HospitalEntityFrameworkCoreModule),
    typeof(HospitalApplicationContractsModule)
    )]
public class HospitalDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
