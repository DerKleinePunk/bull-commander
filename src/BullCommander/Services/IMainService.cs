using BullCommanderLibrary.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BullCommander.Services
{
    //Tod find better Name this is St
    public interface IMainService
    {
        Task<List<IComputer>> GetServerList();
    }
}