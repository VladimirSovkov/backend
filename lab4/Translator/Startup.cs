using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Translate.Data.Models;

namespace Translator
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        private async Task OutputResponseCode(HttpContext context, string message, int statusCode )
        {
            context.Response.ContentType = "text/plain; charset=utf-8";
            await context.Response.WriteAsync(message);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            DictionaryFile vocabulary = new DictionaryFile();
            vocabulary.CreatDictionary("Data\\Dictionary\\dictionary.txt");

            app.Run(async (context) =>
            {
                if (context.Request.Query.ContainsKey("word"))
                {
                    string word = context.Request.Query["word"];
                    string translation = vocabulary.GetWordTranslation(word);

                    if (translation == "")
                    {
                        await OutputResponseCode(context, "Not Found", 404);
                    }
                    else
                    {
                        await OutputResponseCode(context, translation, 200);
                    }

                }
                else
                {
                    await OutputResponseCode(context, "Bad Request", 400);
                }

            });
        }
    }
}
