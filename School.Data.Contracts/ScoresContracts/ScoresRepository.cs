using Core.Common.Contracts;
using School.Business.Scores;
using School.Client.Business.Scores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Contracts.ScoresContracts
{
    public interface IScoresRepository : IDataRepository<Scores, ClientScores>
    {
    }
}
