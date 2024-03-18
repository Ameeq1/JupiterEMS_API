using Jupiter.Business.Core;
using Jupiter.Business.Core.Interface;
using Jupiter.Business.Core.ModelMapper;
using Jupiter.Business.Models;
using Jupiter.Data.DataAccess.Core.Repositories;
using Jupiter.Data.DataAccess.Core.UnitOfWork;
using Jupiter.Data.DataAccess.DataContext;
using Jupiter.Data.DataAccess.Entity;
using Jupiter.Data.DataAccess.Helper;
using Jupiter.Utility.AuditLog;
using Jupiter.Utility.Enums;
using Jupiter.Utility.Utility;
using Newtonsoft.Json;
using System.Data;
using System.Reflection;

namespace Jupiter.Business.Core.Implementation
{
    /// <summary>
    /// Added by YReddy on 11/01/2023 for Auditlog
    /// </summary>
    public class AuditLogService : IAuditLogService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapperFactory _mapperFactory;
        private readonly IHelper _helper;
        private readonly IExceptionService _ExceptionService;
        protected readonly MedullaEmergencyDBContext dbContext;
        private readonly string _dbConnection;
        private IRepository<MasterAuditLog> _repository { get; set; }
        private IRepository<MasterUser> _user { get; set; }

        public AuditLogService(MedullaEmergencyDBContext Context, IUnitOfWork unitOfWork, IMapperFactory mapperFactory, IHelper helper, IExceptionService exceptionService)
        {
            _unitOfWork = unitOfWork;
            _mapperFactory = mapperFactory;
            _repository = _unitOfWork.GetRepository<MasterAuditLog>();
            _helper = helper;
            _ExceptionService = exceptionService;
            _user = _unitOfWork.GetRepository<MasterUser>();

            dbContext = Context ?? throw new ArgumentNullException(nameof(Context));
            _dbConnection = DatabaseConnection.ConnString;
        }

        /// <summary>
        /// Create Audit log for changes in any of the field
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="auditActionType"></param>
        /// <param name="oldEntity"></param>
        /// <param name="newEntity"></param>
        /// <param name="PTName"></param>
        /// <param name="PTId"></param>
        /// <returns></returns>
        public async Task<bool> CreateAuditLog<TResult>(AuditActionTypeEnum auditActionType, TResult oldEntity, TResult newEntity,
                     string? PTName = null, int? PTId = null) where TResult : new()
        {
            try
            {
                // Get Last Modified
                PropertyInfo pInfo = newEntity.GetType().GetProperty(AppConstants.ModifiedBy);
                int logCreatedBy = Convert.ToInt32(pInfo.GetValue(newEntity, null));

                // Get table Name, Id
                var TableName = typeof(TResult).Name;
                var TableKeyId = Convert.ToInt32(GetPrimaryKey(oldEntity));

                // Save Audit Log
                MasterAuditLog objAuditLog;
                var entityAudit = new MasterAuditLog()
                {
                    CreatedBy = logCreatedBy,
                    ActionType = Enum.GetName(typeof(AuditActionTypeEnum), auditActionType),
                    Log = oldEntity.ToAuditLog(newEntity),
                    TableKeyId = TableKeyId,
                    TableName = TableName,
                    ParentTableKeyId = PTId,
                    ParentTableName = PTName.Replace("_", ""),
                };

                if (entityAudit.Log != "[]")
                    AddAuditLog(entityAudit);

                return true; // DBOperation.Success;
            }
            catch (Exception ex)
            {
                await _ExceptionService.LogException(ex);
                return false; // DBOperation.Error;
            }
        }

        /// <summary>
        /// Add Audit Log
        /// </summary>
        /// <param name="log"></param>
        public void AddAuditLog(MasterAuditLog log)
        {
            DbParameter[] dbParameters =
            {
                 new DbParameter("TableKeyId",             log.TableKeyId, SqlDbType.Int),
                 new DbParameter("TableName",              log.TableName, SqlDbType.VarChar),
                 new DbParameter("ParentTableKeyId",       log.ParentTableKeyId, SqlDbType.Int),
                 new DbParameter("ParentTableName",        log.ParentTableName, SqlDbType.VarChar),
                 new DbParameter("Log",                    log.Log, SqlDbType.VarChar),
                 new DbParameter("ActionType",             log.ActionType, SqlDbType.Int),
                 new DbParameter("CreatedBy",              log.CreatedBy, SqlDbType.Int)
            };

            MedullaEmergencyDBHelper.ExecuteNonQuery(ProcedureMetastore.usp_AuditLog_Add, _dbConnection, CommandType.StoredProcedure, dbParameters);
        }

        /// <summary>
        /// Get Primary Key
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual int GetPrimaryKey<T>(T entity)
        {
            var keyName = dbContext.Model.FindEntityType(typeof(T)).FindPrimaryKey().Properties
                          .Select(x => x.Name).Single();

            return (int)entity.GetType().GetProperty(keyName).GetValue(entity, null);
        }

        /// <summary>
        /// Get Audit Logs by Module Id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public async Task<IEnumerable<MasterAuditLogWrapperEntity<AuditLog>>> GetByModuleId(int id, string tableName)
        {
            var entityAuditLog = await _repository.FindAllAsync(x => x.TableKeyId == id && x.TableName == tableName);
            var auditLog = entityAuditLog.Select(xx => new MasterAuditLogWrapperEntity<AuditLog>
            {
                ActionType = xx.ActionType,
                Id = xx.Id,
                CreatedBy = xx.CreatedBy,
                CreatedDate = xx.CreatedDate,
                TableKeyId = xx.TableKeyId,
                TableName = xx.TableName,
                Log = JsonConvert.DeserializeObject<IEnumerable<AuditLog>>(xx.Log)
            });

            return auditLog;
        }

        /// <summary>
        /// Get all Audit Log details by various filters
        /// </summary>
        /// <param name="model"></param>
        /// <param name="UserName"></param>
        /// <param name="TableName"></param>
        /// <param name="DateFrom"></param>
        /// <param name="DateTo"></param>
        /// <returns></returns>
        public async Task<DataTableResponseModel> GetAll(DataTableAjaxPostModel model, int? UserName, string? TableName = null, DateTime? DateFrom = null, DateTime? DateTo = null)
        {
            string ColumnName = model.order.Count > 0 ? model.columns[model.order[0].column].data : string.Empty;
            string SortDir = model.order.Count > 0 ? model.order[0].dir : string.Empty;

            System.Data.SqlClient.SqlParameter[] osqlParameter =
            {
                new System.Data.SqlClient.SqlParameter(AppConstants.P_CurrentPageNumber,  model.start),
                new System.Data.SqlClient.SqlParameter(AppConstants.P_PageSize,           model.length),
                new System.Data.SqlClient.SqlParameter(AppConstants.P_SortColumn,         ColumnName),
                new System.Data.SqlClient.SqlParameter(AppConstants.P_SortDirection,      SortDir),
                new System.Data.SqlClient.SqlParameter(AppConstants.P_SearchText,         model.search?.value),
                new System.Data.SqlClient.SqlParameter("@UserId",                         UserName),
                new System.Data.SqlClient.SqlParameter("@TableName",                      TableName),
                new System.Data.SqlClient.SqlParameter("@DateFrom",                       DateFrom),
                new System.Data.SqlClient.SqlParameter("@DateTo",                         DateTo)
            };

            var Results = await _repository.GetBySP(ProcedureMetastore.usp_AuditLog_SearchAllList, CommandType.StoredProcedure, osqlParameter);

            // Get Pagination information
            var res = UtilityHelper.GetPaginationInfo(Results);

            DataTableResponseModel resp = new DataTableResponseModel(model.draw, res.Item1, res.Item1, Results.DataTableToList<AuditLogModelResponse>());

            return resp;
        }


        public async Task<List<AuditLogModelResponse>> GetLogDetailsByFilters(string? TableName, int? Id = null, int? TableKey = null, DateTime? DateFrom = null, DateTime? DateTo = null)
        {
            var entityAuditLogs = await _repository.FindAllAsync(x =>
                                   (TableName == null || x.ParentTableName == TableName || x.TableName == TableName)
                                && (TableKey == null || x.ParentTableKeyId == TableKey || x.TableKeyId == TableKey)
                                && (DateFrom == null || x.CreatedDate >= DateFrom)
                                && (DateTo == null || x.CreatedDate <= DateTo)
                                && (Id == null || x.Id == Id));

            var res = new List<AuditLogModelResponse>();
            foreach (var log in entityAuditLogs)
            {
                var _AuditLogListData = JsonConvert.DeserializeObject<IEnumerable<AuditLogs>>(log.Log);

                var usr = _user.GetAll().Where(a => a.Id == log.CreatedBy).FirstOrDefault();
                res.Add(new AuditLogModelResponse()
                {

                    ActionType = log.ActionType,
                    ParentTableKeyId = log.ParentTableKeyId,
                    ParentTableName = log.ParentTableName,
                    TableKeyId = log.TableKeyId,
                    TableName = log.TableName,
                    Id = log.Id,
                    CreatedBy = log.CreatedBy,
                    CreatedDate = log.CreatedDate, // Include both date and time
                    CreatedDateFormatted = log.CreatedDate?.ToString("yyyy-MM-dd HH:mm:ss"), // Formatted date and time
                    CreatedByName = usr == null ? "" : usr.FirstName + ' ' + usr.LastName, // Use null-conditional operator
                    AuditLogListData = _AuditLogListData?.ToList(),
                });
            }
            return res;
        }

        /// <summary>
        /// Get all Audit Log Table Names
        /// </summary>
        /// <returns></returns>
        public async Task<List<AuditLogTableModel>> GetAllAuditLogTableName()
        {
            var lstStf = MedullaEmergencyDBHelper.ExecuteMappedReader<AuditLogTableModel>(ProcedureMetastore.usp_AuditLog_GetTable,
             DatabaseConnection.ConnString, CommandType.StoredProcedure, null);

            return lstStf;
        }

        /// <summary>
        /// Get all details of Audit Logs by filters
        /// </summary>
        /// <param name="model"></param>
        /// <param name="UserId"></param>
        /// <param name="TableName"></param>
        /// <param name="TableKey"></param>
        /// <param name="Id"></param>
        /// <param name="DateFrom"></param>
        /// <param name="DateTo"></param>
        /// <returns></returns>
        public async Task<DataTableResponseModel> GetAllDetailsLog(DataTableAjaxPostModel model, int? UserId, string? TableName, string? TableKey, int? Id, DateTime? DateFrom = null, DateTime? DateTo = null)
        {
            string ColumnName = model.order.Count > 0 ? model.columns[model.order[0].column].data : string.Empty;
            string SortDir = model.order.Count > 0 ? model.order[0].dir : string.Empty;

            System.Data.SqlClient.SqlParameter[] osqlParameter =
            {
                new System.Data.SqlClient.SqlParameter(AppConstants.P_CurrentPageNumber,  model.start),
                new System.Data.SqlClient.SqlParameter(AppConstants.P_PageSize,           model.length),
                new System.Data.SqlClient.SqlParameter(AppConstants.P_SortColumn,         ColumnName),
                new System.Data.SqlClient.SqlParameter(AppConstants.P_SortDirection,      SortDir),
                new System.Data.SqlClient.SqlParameter(AppConstants.P_SearchText,         model.search?.value),
                new System.Data.SqlClient.SqlParameter("@UserId",                         UserId),
                new System.Data.SqlClient.SqlParameter("@TableName",                      TableName),
                new System.Data.SqlClient.SqlParameter("@TableKey",                       TableKey),
                new System.Data.SqlClient.SqlParameter("@Id",                             Id),
                new System.Data.SqlClient.SqlParameter("@DateFrom",                       DateFrom),
                new System.Data.SqlClient.SqlParameter("@DateTo",                         DateTo)
            };

            var Results = await _repository.GetBySP(ProcedureMetastore.usp_AuditLog_SearchDetailsByFilter, CommandType.StoredProcedure, osqlParameter);

            var res = UtilityHelper.GetPaginationInfo(Results);
            DataTableResponseModel resp = new DataTableResponseModel(model.draw, res.Item1, res.Item1, Results.DataTableToList<AuditLogModelData>());

            return resp;
        }
    }
}

