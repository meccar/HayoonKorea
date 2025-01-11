using System.Threading.Tasks;

namespace HayoonKorea.Data;

public interface IHayoonKoreaDbSchemaMigrator
{
    Task MigrateAsync();
}
