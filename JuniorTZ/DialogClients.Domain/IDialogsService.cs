using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogClients.Domain
{
    public interface IDialogsService
    {
        Task<Guid> FindDialog(Guid[] clientsId);
    }
}
