using FirstAPIProject.DTOs;
using FirstAPIProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAPIProject.Repositories
{
    public class TreesRepository : ITreesRepository
    {
        public IReadOnlyCollection<string> GetSeasons(TreeDto tree)
        {
            var return_val = new List<string>();

            foreach(var season in tree.Seasons)
            {
                return_val.Add(season);
            }

            return tree.Seasons;
        }
    }
}
