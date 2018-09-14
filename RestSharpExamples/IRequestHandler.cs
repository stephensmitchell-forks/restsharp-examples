﻿using RestSharpExamples.Model;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using RestSharp;

namespace RestSharpExamples
{
    public interface IRequestHandler
    {
        IRestResponse GetRepositories();
        Task<Repository> CreateRepository(string user, string repository);
        Task<Repository> EditRepository(string user, string repository);
        Task<HttpResponseMessage> DeleteRepository(string user, string repository);
    }
}
