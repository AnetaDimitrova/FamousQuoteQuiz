using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using FamousQuoteQuiz.Data;
using FamousQuoteQuiz.Data.Migrations;

namespace FamousQuoteQuiz.App.ViewModels
{
    public class QuoteViewModels 

    {
        public int Id { get; set; }

        public string Content { get; set; }

        public  int AuthorId { get; set; }

        public string AuthorName { get; set; }


        
    }
}