using System.Collections.Generic;
using System.Web;
using Kindr.Models;
using Nancy;
using Nancy.Bootstrapper;
using Nancy.Helpers;
using Nancy.TinyIoc;

namespace Kindr
{
    public class Bootstrapper  : DefaultNancyBootstrapper
    {
        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            base.ApplicationStartup(container, pipelines);

            StaticConfiguration.DisableErrorTraces = false;

            HttpContext.Current.Application["BusinessModels"] = GetBusinessModels();
            HttpContext.Current.Application["CharityModels"] = GetCharityModels();

        }

        private ICollection<CharityModel> GetCharityModels()
        {
            var models = new List<CharityModel>();

            models.Add(new CharityModel(new List<TagModel>()
            {
                new TagModel() { },
                new TagModel() { },
                new TagModel() { },
                new TagModel() { },
            })
            {
                Name = "Dogs Trust",Id=0,
                Description = "Dogs Trust, formerly known as the National Canine Defence League, is an animal welfare charity and humane society in the United Kingdom which specialises in the well-being of dogs.",
                ImageUrl= "https://pbs.twimg.com/profile_images/931550545860616199/hEit2Niu.jpg"
            });

            models.Add(new CharityModel(new List<TagModel>()
            {
                new TagModel() { },
                new TagModel() { },
                new TagModel() { },
                new TagModel() { },
            }){
                Name = "Big C"
            });

            models.Add(new CharityModel(new List<TagModel>()
            {
                new TagModel() { },
                new TagModel() { },
                new TagModel() { },
                new TagModel() { },
            })
            {
                Name = "Big C"
            });

            models.Add(new CharityModel(new List<TagModel>()
            {
                new TagModel() { },
                new TagModel() { },
                new TagModel() { },
                new TagModel() { },
            })
            {
                Name = "Big C"
            });

            models.Add(new CharityModel(new List<TagModel>()
            {
                new TagModel() { },
                new TagModel() { },
                new TagModel() { },
                new TagModel() { },
            })
            {
                Name = "Big C"
            });

            return models;
        }

        private ICollection<BusinessModel> GetBusinessModels()
        {
            var models = new List<BusinessModel>();

            models.Add(new BusinessModel(new List<TagModel>()
            {
                new TagModel() {   },
                new TagModel() {   },
                new TagModel() {   },
                new TagModel() {   },

            }));

            models.Add(new BusinessModel(new List<TagModel>()
            {
                new TagModel() {   },
                new TagModel() {   },
                new TagModel() {   },
                new TagModel() {   },
                new TagModel() {   },

            }));

            models.Add(new BusinessModel(new List<TagModel>()
            {
                new TagModel() {   },
                new TagModel() {   },
                new TagModel() {   },
                new TagModel() {   },
                new TagModel() {   },

            }));

            models.Add(new BusinessModel(new List<TagModel>()
            {
                new TagModel() {   },
                new TagModel() {   },
                new TagModel() {   },
                new TagModel() {   },
                new TagModel() {   },

            }));

            return models;

        }
    }
}