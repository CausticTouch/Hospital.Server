using System.Threading.Tasks;

namespace Hospital.Data;

public interface IHospitalDbSchemaMigrator
{
    Task MigrateAsync();
}
