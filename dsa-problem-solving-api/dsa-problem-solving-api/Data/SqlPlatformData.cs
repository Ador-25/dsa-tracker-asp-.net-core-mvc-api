using dsa_problem_solving_api.Contexts;
using dsa_problem_solving_api.Models;

namespace dsa_problem_solving_api.Data
{
    public class SqlPlatformData : IPlatformData
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public SqlPlatformData(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public Platform AddPlatform(Platform platform)
        {
<<<<<<< HEAD
            platform.PlatformId = Guid.NewGuid();
            _applicationDbContext.Platforms.Add(platform);
            _applicationDbContext.SaveChanges();
=======
            platform.PlatformId=Guid.NewGuid();
             _applicationDbContext.Platforms.Add(platform);
>>>>>>> 0c35d9a7fd5d90b2cbd5ee4a5963417c63ed48c5
            return platform;
        }

        public Platform EditPlatform(Guid platformId, Platform platform)
        {
          var temp = _applicationDbContext.Platforms.SingleOrDefault(x => x.PlatformId == platformId);
            if(temp == null)
            {
                return null;
            }
            else
            {
                temp = platform;
            }

            return temp;
        }

        public List<Platform> GetAllPlatforms()
        {
            return _applicationDbContext.Platforms.ToList();
        }

        public Platform GetPlatform(string platformName)
        {
        return _applicationDbContext.Platforms.SingleOrDefault(x => x.PlatformName == platformName);

        }
    }
}
