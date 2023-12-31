




namespace ChoreScore.Repositories;

public class ChoresRepository
{
    private List<Chore> _chores;

    public ChoresRepository()
    {
        _chores = [
            new Chore(1, "make chores", "create chore data"),
            new Chore(2, "complain", "complain about said chores"),
            new Chore(3, "procrastinate", "don't do the chores")
        ];
    }

    internal Chore CreateChore(Chore choreData)
    {
        Chore lastChore = _chores[_chores.Count - 1];
        if (lastChore == null)
        {
            choreData.Id = 1;
        }
        else
        {
            choreData.Id = lastChore.Id + 1;
        }
        _chores.Add(choreData);
        return choreData;
    }

    internal void DestroyChore(Chore chore)
    {
        _chores.Remove(chore);
    }

    internal Chore GetChoreById(int choreId)
    {
        Chore chore = _chores.Find(chore => chore.Id == choreId);
        return chore;
    }

    internal List<Chore> GetChores()
    {
        return _chores;
    }
}
