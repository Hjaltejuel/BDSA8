using System;
using Microsoft.Extensions.DependencyInjection;
using BDSA2017.Assignment08.Entities;
using Microsoft.EntityFrameworkCore;
using BDSA2017.Assignment08.Models;
using BDSA2017.Assignment08.UWP.ViewModels;

namespace BDSA2017.Assignment08.UWP.Models
{
    public class IoCContainer
    {
        public static IServiceProvider Create() => ConfigureServices();

        private static IServiceProvider ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();

            var connectionString = @"Data Source=slotcars.db";

            services.AddDbContext<SlotCarContext>(options =>
               options.UseSqlite(connectionString));

            services.AddScoped<ISlotCarContext, SlotCarContext>();
            services.AddScoped<ITrackRepository, TrackRepository>();
            services.AddScoped<MainPageViewModel>();

            return services.BuildServiceProvider();
        }
    }
}
