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
                Cause = "Community, Animal Welfare",
                SupportF = "Money, Services",
                ImageUrl = "https://pbs.twimg.com/profile_images/931550545860616199/hEit2Niu.jpg",
                Description = "Our mission is to bring about the day when all dogs can enjoy a happy life, free from the threat of unnecessary destruction."
            });

            models.Add(new CharityModel(){
                Name = "The Salvation Army",
                Tags = emptyTagModel,
                Cause = "Community, Homeless",
                SupportF = "Money, Goods",
                ImageUrl = "https://secure2.convio.net/tsauk/images/content/pagebuilder/TSA-donation-rebrand-logoheader.png",
                Description = "Your gift could help vulnerable homeless people this Christmas."
            });

            models.Add(new CharityModel()
            {
                Name = "RSPCA",
                Tags = emptyTagModel,
                Cause = "Community, Animal welfare",
                SupportF = "Money, Goods",
                ImageUrl = "https://www.rspca.org.uk/ptl2017Themes/images/RSPCA_Logo_Big.png",
                Description = "We were the first to introduce a law to protect animals and work hard to ensure that all animals can live free from pain and suffering."
            });

            models.Add(new CharityModel()
            {
                Name = "CoppaFeel!",
                Tags = emptyTagModel,
                Cause = "Disease Research, Community",
                SupportF = "Money, Space",
                ImageUrl = "https://pbs.twimg.com/profile_images/474261106932723712/EMu84AvA.png",
                Description = "CoppaFeel! exists to educate and remind every young person in the UK that checking their boobs isn’t only fun, it could save their life."
            });

            models.Add(new CharityModel()
            {
                Name = "Bill & Melinda Gates Foundation",
                Tags = emptyTagModel,
                Cause = "Children, Poverty",
                SupportF = "Money, Services",
                ImageUrl = "data:image/png;base64,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",
                Description = "In developing countries, we focus on improving people’s health and wellbeing, helping individuals lift themselves out of hunger and extreme poverty."
            });
            models.Add(new CharityModel()
            {
                Name = "SOS Children's Villages",
                Tags = emptyTagModel,
                Cause = "Children",
                SupportF = "Money, Goods",
                ImageUrl = "https://www.soschildrensvillages.org.uk/logo.gif",
                Description = "Across the world millions of children and young people cannot access the education they need to lead fulfilling lives. With SOS Children's Villages UK you can raise money to send children to school each year."
            });
            models.Add(new CharityModel()
            {
                Name = "Marie Curie",
                Tags = emptyTagModel,
                Cause = "Medical",
                SupportF = "Money, Services",
                ImageUrl = "http://www.building4jobs.com/getasset/d8762b45-b195-4c3b-895c-c19541cc5f22/;w=360;h=200",
                Description = "We provide care and support for people living with any terminal illness, and their families. Last year we cared for over 40000 people across the UK. "
            });
            models.Add(new CharityModel()
            {
                Name = "Norfolk Community Foundation",
                Tags = emptyTagModel,
                Cause = "Community",
                SupportF = "Money, Space, Goods",
                ImageUrl = "http://www.norfolkfoundation.com/wp-content/themes/ncf/img/ncf-logo.jpg?v=2",
                Description = "We make it easier and more satisfying for individuals and companies wishing to support community projects in their area by managing charitable funds set up on their behalf and in accordance with their wishes."
            });
            models.Add(new CharityModel()
            {
                Name = "Mind",
                Tags = emptyTagModel,
                Cause = "Community, Medical",
                SupportF = "Money, Space",
                ImageUrl = "https://pbs.twimg.com/profile_images/700296365285310464/nxkGt-oH.jpg",
                Description = "We won't give up until everyone experiencing a mental health problem gets support and respect."
            });
            models.Add(new CharityModel()
            {
                Name = "Shelter",
                Tags = emptyTagModel,
                Cause = "Community, Homless",
                SupportF = "Money, Goods, Services",
                ImageUrl = "http://shelter-england-images.s3.amazonaws.com/mobile/shelter-logo.png",
                Description = "Help us make sure being homeless never becomes a Christmas tradition."
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