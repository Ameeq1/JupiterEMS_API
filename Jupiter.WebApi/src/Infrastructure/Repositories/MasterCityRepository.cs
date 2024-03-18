using Jupiter.Data.DataAccess.Core.UnitOfWork;
using Jupiter.Business.Models;
using Jupiter.Data.DataAccess.Core.Repositories;
using Jupiter.Data.DataAccess.Entity;
using Jupiter.Data.DataAccess.Helper;
using JupiterWeb.Application.Contracts.Persistence;
using JupiterWeb.Persistence;
using JupiterWeb.Persistence.Helper;
using Microsoft.Extensions.Logging;
using System.Data;
using static Jupiter.Utility.Enums.GeneralEnum;
using DbParameter = Jupiter.Data.DataAccess.Helper.DbParameter;

namespace JupiterWeb.Persistence.Repositories
{
    public class MasterCityRepository : BaseRepository<MasterCity>, IMasterCityRepository
    {
        private readonly ILogger _logger;
        //Connection string changes
        protected Microsoft.Extensions.Configuration.IConfiguration _configuration;
        private string _dbConnection;
        //private readonly IUnitOfWork _unitOfWork;
        // private readonly IMapperFactory _mapperFactory;
        //private readonly IHelper _helper;

        private IRepository<MasterCity> _repository { get; set; }


        public MasterCityRepository(ValuationDbContext dbContext, ILogger<MasterCity> logger, //IUnitOfWork unitOfWork,
                                    Microsoft.Extensions.Configuration.IConfiguration configuration)
                                  : base(dbContext, logger)
        {
            _logger = logger;
            //_unitOfWork = unitOfWork;
            //_mapperFactory = mapperFactory;
            //_helper = helper;

            //_repository = _dbContext.Set<MasterCity>();
            _configuration = configuration;
            _dbConnection = _configuration[ApplicationHelper.ConnectionStringkey];
        }


        public async Task<DataTableResponseModel> GetAll(DataTableAjaxPostModel model)
        {
            var _dbParams = new[]
             {
                 new DbParameter("CityId", 0,SqlDbType.Int),
                 new DbParameter("PageSize", model.length, SqlDbType.Int),
                 new DbParameter("PageNumber", model.start, SqlDbType.Int),
                 new DbParameter("OrderClause", "CityName", SqlDbType.VarChar),
                 new DbParameter("ReverseSort", 1, SqlDbType.Int)
             };

            int _count = 0;
            var lstStf = MedullaEmergencyDBHelper.ExecuteMappedReaderWithOutputParameter<MasterCityEntity>(ProcedureMetastore.usp_City_SearchAllList,

             _dbConnection, out _count, CommandType.StoredProcedure, _dbParams);


            DataTableResponseModel oDataTableResponseModel = new DataTableResponseModel(model.draw, _count, 0, lstStf);

            return oDataTableResponseModel;
        }
        public async Task<MasterCity> GetById(int id)
        {
            var dd = await _repository.GetAsync(id);
            return dd;
        }
        public async Task<DBOperation> Upsert(MasterCityEntity entityCity)
        {
            MasterCity objCity;

            if (entityCity.Id > 0)
            {
                objCity = _repository.Get(entityCity.Id);
                var OldObjCity = objCity;
                if (objCity != null)
                {
                    objCity.CityName = entityCity.CityName;
                    objCity.CountryId = entityCity.CountryId;
                    objCity.StateId = entityCity.StateId;
                    objCity.Stdcode = entityCity.STDCode;
                    objCity.IsActive = entityCity.IsActive;
                    objCity.ModifiedDate = AppConstants.DateTime;
                    objCity.ModifiedBy = entityCity.CreatedBy;
                    _repository.UpdateAsync(objCity);
                }
                else
                {
                    return DBOperation.NotFound;
                }
            }
            else
            {
                objCity = new MasterCity();

                objCity.CityName = entityCity.CityName;
                objCity.CountryId = entityCity.CountryId;
                objCity.StateId = entityCity.StateId;
                objCity.Stdcode = entityCity.STDCode;
                objCity.IsActive = entityCity.IsActive;
                objCity.CreatedDate = AppConstants.DateTime;
                objCity.CreatedBy = entityCity.CreatedBy;
                objCity.ModifiedDate = AppConstants.DateTime;
                objCity.ModifiedBy = entityCity.CreatedBy;
                _repository.AddAsync(objCity);
            }
            //await _unitOfWork.SaveChangesAsync();

            if (objCity.Id == 0)
                return DBOperation.Error;

            return DBOperation.Success;
        }

        public async Task<DBOperation> Delete(int id)
        {
            var entityCity = _repository.Get(x => x.Id == id);

            if (entityCity == null)
                return DBOperation.NotFound;

            _repository.Remove(entityCity);

            //await _unitOfWork.SaveChangesAsync();

            return DBOperation.Success;
        }
    }
}
