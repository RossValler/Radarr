using System.Collections.Generic;
using NzbDrone.Core.Datastore;
using NzbDrone.Core.Messaging.Events;


namespace NzbDrone.Core.MediaFiles
{
    public interface IMovieFileRepository : IBasicRepository<MovieFile>
    {
        List<MovieFile> GetFilesByMovie(int movieId);
        List<MovieFile> GetFilesWithoutMediaInfo();
    }


    public class MovieFileRepository : BasicRepository<MovieFile>, IMovieFileRepository
    {
        public MovieFileRepository(IMainDatabase database, IEventAggregator eventAggregator)
            : base(database, eventAggregator)
        {
        }

        public List<MovieFile> GetFilesByMovie(int movieId)
        {
            return Query.Where(c => c.MovieId == movieId).ToList();
        }

        public List<MovieFile> GetFilesWithoutMediaInfo()
        {
            return Query.Where(c => c.MediaInfo == null).ToList();
        }
    }
}