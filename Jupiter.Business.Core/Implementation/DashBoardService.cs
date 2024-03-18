using Jupiter.Business.Core.Interface;
using Jupiter.Business.Core.ModelMapper;
using Jupiter.Business.Models;
using Jupiter.Data.DataAccess.Core.Repositories;
using Jupiter.Data.DataAccess.Core.UnitOfWork;
using Jupiter.Data.DataAccess.Entity;
using Jupiter.Data.DataAccess.Helper;
using Jupiter.Utility.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Business.Core.Implementation
{
    public class DashBoardService: IDashBoardService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapperFactory _mapperFactory;
        private readonly IMasterNotificationService _notification;
        private readonly Microsoft.Extensions.Configuration.IConfiguration configuration;
        private readonly IAuditLogService _auditLogService;
        private IRepository<Emergency> _repository { get; set; }
        private readonly IHelper _helper;
        private readonly int? _LoginUserId;
        public DashBoardService(IUnitOfWork unitOfWork, IMapperFactory mapperFactory, IAuditLogService auditLogService,
                                 IHelper helper, Microsoft.Extensions.Configuration.IConfiguration _configuration, IMasterNotificationService notification)
        {
            _unitOfWork = unitOfWork;
            _mapperFactory = mapperFactory;

          
            configuration = _configuration;
            _helper = helper;
            _auditLogService = auditLogService;
            _notification = notification;
        }
        public async Task<List<DashboardEmergencyModel>> GetActiveEmegencyList()
        {
            return _mapperFactory.GetList<Emergency, DashboardEmergencyModel>(await _repository.GetAllAsync());
        }

        //public async Task<List<DashboardEmergencyModel>> GetTodayEmegencyList()
        //{
        //    return _mapperFactory.GetList<Emergency, DashboardEmergencyModel>(await _repository.GetAllAsync());
        //}

        //public async Task<List<DashboardEmergencyModel>> GetTodayEmegencyList()
        //{
        //    DateTime today = DateTime.Today;
        //    var allItems = await _repository.GetAllAsync();
        //    var filteredItems = allItems.Where(item => item.CreatedDate.Date == today);
        //    var result = filteredItems.ToList();
        //    return _mapperFactory.GetList<MasterDepartment, DashboardEmergencyModel>(result);
        //}

        public async Task<List<DashboardEmergencyModel>> GetTodayEmegencyList(DateTime today)
        {
            // Retrieve all emergencies from the repository asynchronously based on today's date
            var emergencies = await _repository.GetAllAsync(x => x.CreatedDate.Date == today.Date);
            var result = emergencies.ToList();

            // Map the retrieved entities to DashboardEmergencyModel instances
            var dashboardEmergencyModels = _mapperFactory.GetList<Emergency, DashboardEmergencyModel>(result);

            // Return the list of mapped entities
            return dashboardEmergencyModels;
        }




        public async Task<List<DashboardReportedEmergencyModel>> GetReportedEmergencies(DateTime fromDate, DateTime toDate)
        {
            // Create a new list to hold DashboardEmergencyModel instances
            var _emergency = new List<DashboardReportedEmergencyModel>();

            // Retrieve all clients from the repository asynchronously based on the date range
            var res = await _repository.GetAllAsync(x =>  x.CreatedDate >= fromDate && x.CreatedDate <= toDate);

            // Convert the result to a list
            var resList = res.ToList();

            // Map the retrieved entities to DashboardEmergencyModel instances
            _emergency = _mapperFactory.GetList<Emergency, DashboardReportedEmergencyModel>(resList);

            // Return the list of mapped entities
            return _emergency;
        }




        public async Task<List<DashboardRecentEmergencyModel>> GetRecentEmergency()
        {
            return _mapperFactory.GetList<Emergency, DashboardRecentEmergencyModel>(await _repository.GetAllAsync());
        }

        public async Task<List<DashboardOverdueActionItemsforStaffModel>> GetAssignedActionItems()
        {
            return _mapperFactory.GetList<Emergency, DashboardOverdueActionItemsforStaffModel>(await _repository.GetAllAsync());
        }

        public async Task<List<DashboardOverdueActionItemsforStaffModel>> GetOverdueActionItemsforStaff()
        {
            return _mapperFactory.GetList<Emergency, DashboardOverdueActionItemsforStaffModel>(await _repository.GetAllAsync());
        }

        public async Task<List<DashboardCodewiseAnalysisCountModel>> GetCodewiseAnalysisCount(DateTime fromDate, DateTime toDate)
        {
            // Create a new list to hold DashboardEmergencyModel instances
            var _emergency = new List<DashboardCodewiseAnalysisCountModel>();

            // Retrieve all clients from the repository asynchronously based on the date range
            var res = await _repository.GetAllAsync(x => x.CreatedDate >= fromDate && x.CreatedDate <= toDate);

            // Convert the result to a list
            var resList = res.ToList();

            // Map the retrieved entities to DashboardEmergencyModel instances
            _emergency = _mapperFactory.GetList<Emergency, DashboardCodewiseAnalysisCountModel>(resList);

            // Return the list of mapped entities
            return _emergency;
        }

        public async Task<List<DashboardPRAnalysisCountModel>> GetCPRAnalysisAdult(DateTime fromDate, DateTime toDate)
        {
            // Create a new list to hold DashboardEmergencyModel instances
            var _emergency = new List<DashboardPRAnalysisCountModel>();

            // Retrieve all clients from the repository asynchronously based on the date range
            var res = await _repository.GetAllAsync(x => x.CreatedDate >= fromDate && x.CreatedDate <= toDate);

            // Convert the result to a list
            var resList = res.ToList();

            // Map the retrieved entities to DashboardEmergencyModel instances
            _emergency = _mapperFactory.GetList<Emergency, DashboardPRAnalysisCountModel>(resList);

            // Return the list of mapped entities
            return _emergency;
        }

        public async Task<List<DashboardPRAnalysisCountModel>> GetCPRAnalysisPaediatric(DateTime fromDate, DateTime toDate)
        {
            // Create a new list to hold DashboardEmergencyModel instances
            var _emergency = new List<DashboardPRAnalysisCountModel>();

            // Retrieve all clients from the repository asynchronously based on the date range
            var res = await _repository.GetAllAsync(x => x.CreatedDate >= fromDate && x.CreatedDate <= toDate);

            // Convert the result to a list
            var resList = res.ToList();

            // Map the retrieved entities to DashboardEmergencyModel instances
            _emergency = _mapperFactory.GetList<Emergency, DashboardPRAnalysisCountModel>(resList);

            // Return the list of mapped entities
            return _emergency;
        }

        //public async Task<DashboardEmergencyModel> GetMasterPropertyByIdAsync(int id)
        //{
        //    // Create a new Master_PropertyTypeModel instance.
        //    var _userEntity = new DashboardEmergencyModel();

        //    // Return the mapped entity.
        //    _userEntity = _mapperFactory.Get<Emergency, DashboardEmergencyModel>(await _repository.GetAsync(id));

        //    if (_userEntity != null)
        //    {

        //        DbParameter[] osqlParameter =
        //        {
        //            new DbParameter("PropertyId", id, SqlDbType.Int),
        //        };
        //        var amenityList = MedullaEmergencyDBHelper.ExecuteMappedReader<DashboardEmergencyModel>(ProcedureMetastore.usp_Property_Amenity_GetById, DatabaseConnection.ConnString, System.Data.CommandType.StoredProcedure, osqlParameter);



        //        DbParameter[] osqlParameter1 =
        //        {
        //            new DbParameter("PropertyId", id, SqlDbType.Int),
        //        };
        //        var detailLocation = MedullaEmergencyDBHelper.ExecuteSingleMappedReader<DashboardEmergencyModel>(ProcedureMetastore.usp_Property_Location_GetById, DatabaseConnection.ConnString, System.Data.CommandType.StoredProcedure, osqlParameter1);

        //        if (detailLocation != null)
        //        {
        //            _userEntity.PropertyDetail = detailLocation;
        //        }
        //    }

        //    return _userEntity;
        //}
    }
}
