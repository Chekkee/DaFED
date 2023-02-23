using DaFED.Models;

namespace DaFED.Services
{
    public interface ICandidateService
    {
        IEnumerable<Candidate> GetGoodCandidates();
        IEnumerable<Candidate> GetDecentCandidates();
        IEnumerable<Candidate> GetBadCandidates();
        IEnumerable<Candidate> GetCandidatesYoungerThen(int age);
        void InsertNewCandidate(InsertNewCandidateDTO newCandidate);
    }
}
