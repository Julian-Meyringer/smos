namespace SMOS.Model;

public class Submission
{
    public Submission(int id, User artist, int votes, DateTime dateOfCreation)
    {
        Id = id;
        Artist = artist;
        Votes = votes;
        DateOfCreation = dateOfCreation;
    }

    public int Id { get; }
    public User Artist { get; }
    public int Votes { get; }
    public DateTime DateOfCreation { get; }
}