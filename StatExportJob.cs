using Microsoft.Extensions.Logging;
using Quartz;
using System;
using System.Threading.Tasks;

namespace DC.Web
{
    public class StatExportJob : IJob
    {
        private readonly ILogger<StatExportJob> _logger; 
        //也可以注入项目中其他的实例    
        public StatExportJob(ILogger<StatExportJob> logger)
        {
            _logger = logger;
            _jobsService = jobsService;
        }

        public async Task Execute(IJobExecutionContext context)
        {
            await Task.Yield();

           _logger.LogInformation("test");  
        }
    }
}
