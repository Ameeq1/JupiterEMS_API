using Jupiter.Business.Core.Interface;
using Jupiter.Business.Core.ModelMapper;
using Jupiter.Business.Models;
using Jupiter.Data.DataAccess.Core.Repositories;
using Jupiter.Data.DataAccess.Core.UnitOfWork;
using Jupiter.Data.DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Business.Core.Implementation
{
    public class ReportService: IReportService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapperFactory _mapperFactory;
        private readonly IMasterNotificationService _notification;
        private readonly Microsoft.Extensions.Configuration.IConfiguration configuration;
        private readonly IAuditLogService _auditLogService;

        private IRepository<Emergency> _repository { get; set; }
        private readonly IHelper _helper;
        private readonly int? _LoginUserId;

        public ReportService(IUnitOfWork unitOfWork, IMapperFactory mapperFactory, IAuditLogService auditLogService,
                                IHelper helper, Microsoft.Extensions.Configuration.IConfiguration _configuration, IMasterNotificationService notification)
        {
            _unitOfWork = unitOfWork;
            _mapperFactory = mapperFactory;


            configuration = _configuration;
            _helper = helper;
            _auditLogService = auditLogService;
            _notification = notification;
        }

        public async Task<List<EmergencyReportModel>> GetAllEmergencyReportList()
        {
            return _mapperFactory.GetList<Emergency, EmergencyReportModel>(await _repository.GetAllAsync());
        }

        public async Task<List<EmergencyReportModel>> GetAllMockDrillEmergencyReportList()
        {
            return _mapperFactory.GetList<Emergency, EmergencyReportModel>(await _repository.GetAllAsync());
        }
    }
}
