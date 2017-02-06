using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using FamousQuoteQuiz.App.ViewModels;
using FamousQuoteQuiz.Data;

namespace FamousQuoteQuiz.App.App_Start
{
    public static class MapperConfig
    {
        public static void ConfigureMappings()
        {
            Mapper.CreateMap<Quotes, QuoteViewModels>()
                .ForMember(model => model.AuthorName, config => config.MapFrom(quote => quote.Author.Name)).ReverseMap();
            Mapper.CreateMap<Quotes, MainViewModels>()
               .ForMember(model => model.Quotes, config => config.MapFrom(quote => quote.Author.Name)).ReverseMap();
            Mapper.CreateMap<Author, AuthorViewModels>()
                .ForMember(model => model.Name, config => config.MapFrom(author => author.Name)).ReverseMap();
            Mapper.CreateMap<Author, MainViewModels>()
                .ForMember(model => model.Authors, config => config.MapFrom(author => author.Name)).ReverseMap();
        }
    }
}