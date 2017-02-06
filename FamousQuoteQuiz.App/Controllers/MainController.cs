﻿using FamousQuoteQuiz.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using FamousQuoteQuiz.App.ViewModels;

namespace FamousQuoteQuiz.App.Controllers
{
    public class MainController : BaseController
    {
        public MainController(IFamousQuoteQuizData data)
            : base(data)
        {
          
        }



        public ActionResult Index()
        {

            var model = new MainViewModels();


            IEnumerable<AuthorViewModels> author;
            var quote = this.Data.Quotes.All().OrderBy(x => Guid.NewGuid()).ProjectTo<QuoteViewModels>().ToList().Take(1);


            var authorIds = this.Data.Authors
                .All()
                .Select(a => a.Id)
                .ToList();

            if (IsBinaryMode.BinaryMode)
            {
                author = this.Data.Authors.All()
                .ProjectTo<AuthorViewModels>()
                .ToList()
                .OrderBy(a => a.Name).Take(1); ;
            }
            else
            {
                author = this.Data.Authors.All().Where(a => authorIds.Contains(a.Id))
                .ProjectTo<AuthorViewModels>()
                .ToList()
                .OrderBy(a => a.Name).Take(4); ;
            }

            


  
            model.Authors = author;
            model.Quotes = quote;

            return this.View(model);

      
        }


        public ActionResult Settings()
        {
            return View();
        }

        public ActionResult ChoiseCorrect(int quoteAuthorId, int authorId, bool isAnswerCorrect = true)
        {
            var quote = this.Data.Quotes
                .All()
                .FirstOrDefault(q => q.Id == quoteAuthorId);

            isAnswerCorrect = !((quote.AuthorId == authorId) ^ isAnswerCorrect);

            var model = new Tuple<string, bool>(quote.Author.Name, isAnswerCorrect);

            return PartialView("_ResultView", model);
        }

        [HttpPost]
        public void ChangeMode(bool isBinaryMode)
        {
            IsBinaryMode.BinaryMode = isBinaryMode;
        }

    }



















}