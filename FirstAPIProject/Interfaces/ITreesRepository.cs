using FirstAPIProject.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAPIProject.Interfaces
{
    public interface ITreesRepository
    {
        IReadOnlyCollection<string> GetSeasons(TreeDto tree);
    }
}
