using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OkitechWebApp.Data;
using System;
using System.Linq;

namespace OkitechWebApp.Models;
    public static class SeedData
    {
        public static void Initialize (IServiceProvider serviceProvider)
        {
            using (var context = new OkitechWebAppContext( serviceProvider.GetRequiredService< DbContextOptions<OkitechWebAppContext>>() ) ){
                // Look for any user
                if ( context.Register.Any())
                {
                    return;
                }
                context.Register.AddRange(
                    new Register { 
                        //Id = 1,
                        Name = "Sanusi Bello Olaniyan",
                        Gender = "Male",
                        Address = "Sanusi's Compound, Irewole Area, Saki",
                        Password = "TunarshBee",
                        confirmPassword = "TunarshBee",
                        Phone = "08027365891",
                        National_Identity_Number = 2432536785674
                    },
                    new Register { 
                        //Id = 2,
                        Name = "Sanusi Abdul Baaki Olaitan",
                        Gender = "Male",
                        Address = "Sanusi's Compound, Irewole Area, Saki",
                        Password = "Sanbak",
                        confirmPassword = "Sanbak",
                        Phone = "07011647511",
                        National_Identity_Number = 243245343785674
                    },
                    new Register { 
                        //Id = 3,
                        Name = "Sanusi Adam Olanrewaju",
                        Gender = "Male",
                        Address = "Sanusi's Compound, Irewole Area, Saki",
                        Password = "Oladas",
                        confirmPassword = "Oladas",
                        Phone = "08027365891",
                        National_Identity_Number = 534536467578
                    },
                    new Register
                    {
                        //Id = 4,
                        Name = "Sarafadeen Aishat Olanike",
                        Gender = "Female",
                        Address = "Sanusi's Compound, Irewole Area, Saki",
                        Password = "Olanike",
                        confirmPassword = "Olanike",
                        Phone = "08012345678",
                        National_Identity_Number = 3243809237458
                    },
                    new Register
                    {
                        //Id = 5,
                        Name = "Sanusi  Olaniyan",
                        Gender = "Male",
                        Address = "Sanusi's Compound, Irewole Area, Saki",
                        Password = "TunarshBee",
                        confirmPassword = "TunarshBee",
                        Phone = "08027365891",
                        National_Identity_Number = 2432536785674
                    }
                    );
                context.SaveChanges();
            }
        }
    }

