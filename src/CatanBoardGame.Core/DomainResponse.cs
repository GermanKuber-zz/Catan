using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CatanBoardGame.Core
{
    public class DomainResponse
    {
        public bool SuccessResult { get; }
        public List<string> Errors { get; set; } = new List<string>();

        public DomainResponse Success(Func<Task> callback)
        {
            if (SuccessResult)
                callback().Wait();
            return this;
        }

        public DomainResponse Error(Func<List<string>, Task> callback)
        {
            if (!SuccessResult)
                callback(Errors).Wait(); ;
            return this;
        }

        public static DomainResponse Error(List<string> errors)
        {
            return new DomainResponse(errors);
        }

        public static DomainResponse Ok()
        {
            return new DomainResponse();
        }
        public static DomainResponse Error(string error)
        {
            return new DomainResponse(new List<string> { error });
        }
        public static DomainResponse Error()
        {
            return new DomainResponse(new List<string>());
        }

        protected DomainResponse()
        {
            SuccessResult = true;
        }


        protected DomainResponse(List<string> errors)
        {
            SuccessResult = false;
            Errors = new List<string>();
            Errors.AddRange(errors);
        }
    }
}