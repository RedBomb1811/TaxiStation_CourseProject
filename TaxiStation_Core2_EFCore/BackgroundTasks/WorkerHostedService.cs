using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TestExample.DB;

namespace TaxiStation_Core2_EFCore.BackgroundTasks
{
    public class WorkerHostedService : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stopToken)
        {

            DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder<TaxiStationContext>();

            DbContextOptions<TaxiStationContext> options = (DbContextOptions<TaxiStationContext>)optionsBuilder
                    .UseSqlServer("Data Source=DESKTOP-074QD8U;Initial Catalog=TaxiStation;Persist Security Info=True;User ID=GENIUS_DATABASE_12345;Password=12345")
                    .Options;

            using (TaxiStationContext context = new TaxiStationContext(options))
            {
                //Do your preparation (e.g. Start code) here
                while (!stopToken.IsCancellationRequested)
                {
                    await context.Database.CanConnectAsync();
                    Thread.Sleep(10_000);
                    // await DoSomethingAsync();
                }
                //Do your cleanup (e.g. Stop code) here
            }
        }
    }
}
