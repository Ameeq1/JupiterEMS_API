using Jupiter.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Business.Core.Interface
{
    public interface IEmergencyService
    {
        //Task<EmployeeNotification> ManageEmergency(EmergencyModel oEmergency);
        Task<bool> Create(Employee employee);
    }
}
