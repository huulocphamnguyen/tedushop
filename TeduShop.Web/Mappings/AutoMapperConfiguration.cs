using AutoMapper;
using TeduShop.Model.Models;
using TeduShop.Web.Models;

namespace TeduShop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            //var config = new MapperConfiguration(cfg =>
            //{
            //    cfg.CreateMap<Post, PostViewModel>();
            //    cfg.CreateMap<PostCategory, PostCategoryViewModel>();
            //    cfg.CreateMap<Tag, TagViewModel>();
            //    cfg.CreateMap<PostTag, PostTagViewModel>();
            //});
            Mapper.CreateMap<Post, PostViewModel>();
            Mapper.CreateMap<PostCategory, PostCategoryViewModel>();
            Mapper.CreateMap<Tag, TagViewModel>();
            //var mapper = config.CreateMapper();
        }
    }
}