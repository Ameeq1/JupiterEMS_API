﻿using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using JupiterWeb.Application.Contracts.Persistence;
using JupiterWeb.Application.Responses;
using JupiterWeb.Application.Features.GloblaFilters;


namespace JupiterWeb.Application.Features.Branchs.Queries.GetBranchListWithPagination
{
    /// <summary>
    /// Added by YReddy on 08/12/2022 
    /// Method is used to pull all user details depends on filter values
    /// </summary>
    public class BranchSearchFiltersHandler : IRequestHandler<BranchSearchFilters, Response<GlobalSeachResponse>>
    {
        private readonly IBranchRepository _branchRepository;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;
        public BranchSearchFiltersHandler(IMapper mapper, IBranchRepository branchRepository, ILogger<BranchSearchFiltersHandler> logger)
        {
            _mapper = mapper;
            _branchRepository = branchRepository;
            _logger = logger;
        }

        public async Task<Response<GlobalSeachResponse>> Handle(BranchSearchFilters request, CancellationToken cancellationToken)
        {
            var allBranchs = await _branchRepository.GetBranchListWithPaginationGlobal(request);
            return new Response<GlobalSeachResponse>(allBranchs, "success"); ;
        }
    }
}
