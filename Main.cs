using SiteServer.Plugin;
using SS.Jobs.Provider;

namespace SS.Jobs
{
    public class Main : PluginBase
    {
        public static Main Instance { get; private set; }

        public override void Startup(IService service)
        {
            Instance = this;

            service
                .AddContentModel(JobDao.TableName, JobDao.TableColumns)
                ;
        }
    }
}