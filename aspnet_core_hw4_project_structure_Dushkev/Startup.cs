using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using AutoMapper;
using DAL.Model;
using Shared.DTOs;


namespace aspnet_core_hw4_project_structure_Dushkev
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            var mapper = MapperConfiguration().CreateMapper();
            services.AddScoped(_ => mapper);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }

        public MapperConfiguration MapperConfiguration()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PlaneType, PlaneTypeDTO>();
                cfg.CreateMap<PlaneTypeDTO, PlaneType>();

                cfg.CreateMap<Plane, PlaneDTO>();
                cfg.CreateMap<PlaneDTO, Plane>();

                cfg.CreateMap<Stewardess, StewardessDTO>();
                cfg.CreateMap<StewardessDTO, Stewardess>();

                cfg.CreateMap<Pilot, PilotDTO>();
                cfg.CreateMap<PilotDTO, Pilot>();

                cfg.CreateMap<Crew, CrewDTO>();
                cfg.CreateMap<CrewDTO, Crew>();

                cfg.CreateMap<Ticket, TicketDTO>();
                cfg.CreateMap<TicketDTO, Ticket>();

                cfg.CreateMap<Flight, FlightDTO>();
                cfg.CreateMap<FlightDTO, Flight>();

                cfg.CreateMap<Departure, DepartureDTO>();
                cfg.CreateMap<DepartureDTO, Departure>();
            });
            return config;
        }
    }
}
