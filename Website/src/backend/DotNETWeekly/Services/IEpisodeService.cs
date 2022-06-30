﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DotNETWeekly.Services
{
    using Models;
    public interface IEpisodeService
    {
        Task<IEnumerable<EpisodeSummary>> GetEpisodeSummaries(CancellationToken token);

        Task AddEpsidoeSummary(EpisodeSummary episodeSummary, CancellationToken token);

        Task UpdateEpisodeSummary(int id, EpisodeSummary episodeSummary, CancellationToken token);

        Task<IEnumerable<Episode>> GetEpisodes(CancellationToken token);

        Task AddEpisode(Episode episode, CancellationToken token);

        Task UpdateEpisode(int id, Episode episode, CancellationToken token);
        
    }
}
