﻿//using Atlas.Application.Common.Interfaces;
//using MediatR.Pipeline;
//using Microsoft.Extensions.Logging;
//using System.Threading;
//using System.Threading.Tasks;

//namespace Atlas.Application.Common.Behaviours
//{
//    public class LoggingBehaviour<TRequest> : IRequestPreProcessor<TRequest>
//    {
//        private readonly ILogger _logger;
//        private readonly ICurrentUserService _currentUserService;


//        public LoggingBehaviour(ILogger<TRequest> logger, ICurrentUserService currentUserService)
//        {
//            _logger = logger;
//            _currentUserService = currentUserService;
//        }

//        public  Task Process(TRequest request, CancellationToken cancellationToken)
//        {
//            var requestName = typeof(TRequest).Name;
//            var userName = _currentUserService.Username ?? string.Empty;

//           _logger.LogInformation("Atlas Request: {Name} {@UserName} {@Request}",
//                requestName, userName, request);
            
//            return null;
//        }
//    }
//}
