using BullCommanderLibrary.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BullCommander.Services
{
    public class MainService : IMainService
    {
        public Task<List<IComputer>> GetServerList()
        {
            throw new System.NotImplementedException();
        }
    }
}