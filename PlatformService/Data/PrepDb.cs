using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PlatformService.Models;

namespace PlatformService.Data{


    public static class PrepDb{

        public static void PrepPopulation(IApplicationBuilder app){

            using(var serviceScope=app.ApplicationServices.CreateScope()){

                    SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());

            }

            
        }


        private static void SeedData(AppDbContext context){

            if(!context.Platfroms.Any()) {

                System.Console.WriteLine("--> Seeding Data.....");

                context.Platfroms.AddRange(

                    new Platfrom() {Name="Dot Net",Publisher="Microsoft",Cost="Free"},
                    new Platfrom() {Name="SQL server",Publisher="Microsoft",Cost="Free"},
                    new Platfrom() {Name="Kubernetes",Publisher="Cloud Native Foundation ",Cost="Free"}
                );

                context.SaveChanges();

            }
            else{

                System.Console.WriteLine("->> We already have data");
            }

        }
    }
}