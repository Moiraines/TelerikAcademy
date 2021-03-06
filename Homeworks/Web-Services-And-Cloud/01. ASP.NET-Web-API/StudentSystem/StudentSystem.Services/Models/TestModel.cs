﻿namespace StudentSystem.Web.Models
{
    using System;
    using System.Linq.Expressions;
    using StudentSystem.Models;

    public class TestModel
    {
        public static Expression<Func<Test, TestModel>> FromTest
        {
            get
            {
                return t => new TestModel
                {
                    TestId = t.Id
                };
            }
        }

        public int TestId { get; set; }
    }
}