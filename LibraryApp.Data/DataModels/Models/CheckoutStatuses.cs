using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Data.DataModels.Models
{
    public enum CheckoutStatuses
    {
        PENDING,
        CHECKEDOUT,  
        OVERDUE,
        RETURNED
    }
}
