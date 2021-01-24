using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HappyCypher.Domain.Interface
{
    public interface IHappyCypherApiClient
    {
        Task<TResult> GetAsync<TResult>(string uri);
        Task<TResult> PostAsync<TInput, TResult>(string uri, TInput item, List<(string, string)> headers = null);
        Task<TResult> PutAsync<TInput, TResult>(string uri, TInput item);
        Task<TResult> DeleteAsync<TResult>(string uri);
    }
}
