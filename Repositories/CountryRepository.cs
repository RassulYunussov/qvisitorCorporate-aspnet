
using qvisitorCorp.Data;
using qvisitorCorp.Models;

namespace qvisitorCorp.Repositories
{
    public class CountryRepository : GenericRepository<ApplicationDbContext,qvCountry>
    {
        public CountryRepository(ApplicationDbContext ctx):base(ctx)
        { 
        }
    }
}