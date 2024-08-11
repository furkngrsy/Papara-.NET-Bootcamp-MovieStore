namespace MovieStore.Services
{
    public class DirectorService
    {
        private readonly IDirectorRepository _directorRepository;

        public DirectorService(IDirectorRepository directorRepository)
        {
            _directorRepository = directorRepository;
        }

        public void AddDirector(DirectorDTO directorDTO) { }
        public void UpdateDirector(int id, DirectorDTO directorDTO) { }
        public void DeleteDirector(int id) { }
        public DirectorDTO GetDirectorById(int id) { return null; }
        public List<DirectorDTO> GetAllDirectors() { return null; }
    }

}
