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

            var emptyTagModel = new List<TagModel>()
            {
                new TagModel() { },
                new TagModel() { },
                new TagModel() { },
                new TagModel() { },
            };

            models.Add(new CharityModel()
            {
                Name = "Dogs Trust",
                Id = 0,
                Tags = emptyTagModel,
                ImageUrl = "http://i.imgur.com/adIpFYY.jpg",
                Description = "Mentitum tincidunt sed an, mei no scaevola incorrupte, qui augue iuvaret fabellas ex. Tale iriure similique nam ei, an dicat scripta tincidunt mea, sanctus tacimates accommodare in pro. Sed brute assentior ne. Ad omnis viris veniam quo, eam malis eligendi ne. Tota nemore et pri. "
            });

            models.Add(new CharityModel(){
                Name = "Big C",
                Tags = emptyTagModel,
                ImageUrl = "http://i.imgur.com/adIpFYY.jpg",
                Description = "Mentitum tincidunt sed an, mei no scaevola incorrupte, qui augue iuvaret fabellas ex. Tale iriure similique nam ei, an dicat scripta tincidunt mea, sanctus tacimates accommodare in pro. Sed brute assentior ne. Ad omnis viris veniam quo, eam malis eligendi ne. Tota nemore et pri. "
            });

            models.Add(new CharityModel()
            {
                Name = "MIND",
                Tags = emptyTagModel,
                ImageUrl = "http://i.imgur.com/adIpFYY.jpg",
                Description = "Mentitum tincidunt sed an, mei no scaevola incorrupte, qui augue iuvaret fabellas ex. Tale iriure similique nam ei, an dicat scripta tincidunt mea, sanctus tacimates accommodare in pro. Sed brute assentior ne. Ad omnis viris veniam quo, eam malis eligendi ne. Tota nemore et pri. "
            });

            models.Add(new CharityModel()
            {
                Name = "Dementia Together",
                Tags = emptyTagModel,
                ImageUrl = "http://i.imgur.com/adIpFYY.jpg",
                Description = "Mentitum tincidunt sed an, mei no scaevola incorrupte, qui augue iuvaret fabellas ex. Tale iriure similique nam ei, an dicat scripta tincidunt mea, sanctus tacimates accommodare in pro. Sed brute assentior ne. Ad omnis viris veniam quo, eam malis eligendi ne. Tota nemore et pri. "
            });

            models.Add(new CharityModel()
            {
                Name = "Cancer Research",
                Tags = emptyTagModel,
                ImageUrl = "http://i.imgur.com/adIpFYY.jpg",
                Description = "Mentitum tincidunt sed an, mei no scaevola incorrupte, qui augue iuvaret fabellas ex. Tale iriure similique nam ei, an dicat scripta tincidunt mea, sanctus tacimates accommodare in pro. Sed brute assentior ne. Ad omnis viris veniam quo, eam malis eligendi ne. Tota nemore et pri. "
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