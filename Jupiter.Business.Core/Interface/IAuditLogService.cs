﻿using Jupiter.Business.Models;
using Jupiter.Utility.Enums;
using static Jupiter.Utility.Enums.GeneralEnum;

namespace Jupiter.Business.Core.Interface
{
    public interface IAuditLogService
    {
        Task<bool> CreateAuditLog<TResult>(AuditActionTypeEnum auditActionType, TResult oldEntity, TResult newEntity, string? ParentTableName = null, int? ParentTableId = null) where TResult : new();

        Task<DataTableResponseModel> GetAll(DataTableAjaxPostModel model, int? UserName, string? TableName = null, DateTime? DateFrom = null, DateTime? DateTo = null);

        Task<List<AuditLogModelResponse>> GetLogDetailsByFilters(string? TableName, int? Id = null, int? TableKey = null, DateTime? DateFrom = null, DateTime? DateTo = null);
        Task<List<AuditLogTableModel>> GetAllAuditLogTableName();

        Task<DataTableResponseModel> GetAllDetailsLog(DataTableAjaxPostModel model, int? UserId, string? TableName, string? TableKey, int? Id, DateTime? DateFrom = null, DateTime? DateTo = null);

    }
}
