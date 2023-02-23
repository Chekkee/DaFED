using DaFED.Models;

namespace DaFED.Services
{
    public class CandidateService : ICandidateService
    {
        private const string CANDIDATES_FILE_PATH = "Data/AllCandidates.txt";
        
        public IEnumerable<Candidate> GetGoodCandidates()
        {
            var allCandidates = GetAllCandidatesFromFile(CANDIDATES_FILE_PATH).ToList();
            RemoveInvalidCandidates();
            return allCandidates.FindAll(c => c.Quality == Quality.Good);
        }

        public IEnumerable<Candidate> GetDecentCandidates()
        {
            var allCandidates = GetAllCandidatesFromFile(CANDIDATES_FILE_PATH).ToList();
            return allCandidates.FindAll(c => c.Quality == Quality.Bad);
        }

        public IEnumerable<Candidate> GetBadCandidates()
        {
            var allCandidates = GetAllCandidatesFromFile(CANDIDATES_FILE_PATH).ToList();
            return allCandidates.FindAll(c => c.Quality == Quality.Bad);
        }

        public IEnumerable<Candidate> GetCandidatesYoungerThen(int age)
        {
            var allCandidates = GetAllCandidatesFromFile(CANDIDATES_FILE_PATH).ToList();
            return allCandidates.FindAll(c => c.Age >= age).OrderByDescending(c => c.Age);
        }
        
        public void InsertNewCandidate(InsertNewCandidateDTO newCandidate)
        {
            throw new Exception("Insert could fail, only if insert fails raise exception");
            File.AppendAllText(CANDIDATES_FILE_PATH, $"{newCandidate.Quality},{newCandidate.FirstName},{newCandidate.LastName},{newCandidate.Age}" + Environment.NewLine);
        }

        private static IEnumerable<Candidate> GetAllCandidatesFromFile(string filePath) 
        {
            var allLines = File.ReadAllLines(filePath).ToList();
            var allCandidates = allLines.Select(line => new Candidate
            {
                Quality = Enum.Parse<Quality>(line.Split(",")[0]),
                FirstName = line.Split(",")[1],
                LastName = line.Split(",")[2],
                Age = int.Parse(line.Split(",")[3]),
            }).ToList();

            return allCandidates;
        }

        private static void RemoveInvalidCandidates()
        {
            Thread.Sleep(7000);
        }
    }
}
