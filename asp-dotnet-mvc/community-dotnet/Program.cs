﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

using community_dotnet.Models;

namespace community_dotnet
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //Test t = new Test();

            //t.run();

            CreateWebHostBuilder(args).Build().Run();

            //using (var db = new Database())
            //{
            //    // Create and save a new Blog
            //    Console.WriteLine("Register user in Community AspNet 2018");
            //    Console.WriteLine("Username:");
            //    var username = Console.ReadLine();
            //    Console.WriteLine("Password:");
            //    var pwd = Console.ReadLine();

            //    var user = new UserPoco();
            //    user.Password = pwd;
            //    user.Username = username;
            //    db.Users.Add(user);
            //    db.SaveChanges();

            //    // Display all Blogs from the database
            //    var query = from u in db.Users
            //                orderby u.Username
            //                select u;

            //    Console.WriteLine("User saved in the Community Database:");
            //    foreach (var item in query)
            //    {
            //        Console.WriteLine(item.Username + " " + item.Password);
            //    }

            //    Console.WriteLine("Press any key to exit...");
            //    Console.ReadKey();
            //}
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
