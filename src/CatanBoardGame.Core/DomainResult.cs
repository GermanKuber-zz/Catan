using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CatanBoardGame.Core
{
    public class DomainResult<TResponse>
    {
        public bool SuccessResult { get; }
        public List<string> Errors { get; set; } = new List<string>();
        public TResponse Response { get; set; }

        public DomainResult<TResponse> Success(Func<TResponse, Task> callback)
        {
            if (SuccessResult)
                callback(Response).Wait();
            return this;
        }
        public TResult Success<TResult>(Func<TResponse, Task<TResult>> callback)
        {
            if (SuccessResult)
                return callback(Response).Result;
            return default(TResult);
        }

        public DomainResult<TResponse> Error(Func<List<string>, Task> callback)
        {
            if (!SuccessResult)
                callback(Errors).Wait();
            return this;
        }

        public static DomainResult<TResponse> Error(List<string> errors) =>
            new DomainResult<TResponse>(errors);
        public static DomainResult<TResponse> Error() =>
            new DomainResult<TResponse>(new List<string>());

        public static DomainResult<TResponse> Ok(TResponse response) =>
            new DomainResult<TResponse>(response);
        public static DomainResult<TResponse> Error(string error) =>
            new DomainResult<TResponse>(new List<string> { error });

        protected DomainResult(TResponse response)
        {
            SuccessResult = true;
            Response = response;
        }


        protected DomainResult(List<string> errors)
        {
            SuccessResult = false;
            Errors = new List<string>();
            Errors.AddRange(errors);
        }

    }
}