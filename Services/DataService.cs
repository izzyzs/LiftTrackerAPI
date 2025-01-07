namespace LiftTrackerAPI.Services;

using LiftTrackerAPI.Types;
using LiftTrackerAPI.Data;
using System.Linq;
using SQLitePCL;
using Yarp.ReverseProxy.Forwarder;

public interface IDataService
{
    User? GetUser(int id);
    IEnumerable<Lift>? GetLifts(int id);
    Lift? GetLiftByName(int id, string name);
}

    // Task<Height> GetHeightAsync(int id);
    // Task<Weight> GetWeightAsync(int id);
    // Task<IEnumerable<Lift>> GetLiftsAsync(int id);

public class DataService : IDataService
{
    private readonly AppDbContext _context;    
    public DataService (AppDbContext context)
    {
        _context = context;
    }
    public User? GetUser(int id)
    {
        var user = _context.Users.Find(id);
        return user;
    }

    public IEnumerable<Lift>? GetLifts(int id)
    {
        User? user = _context.Users.Find(id);
        if (user == null)
        {
            return null;
        }

        var lifts = user.Lifts;
        return [.. lifts];
    }

    public Lift? GetLiftByName(int id, string name)
    {
        User? user = _context.Users.Find(id);
        if (user == null) {
            return null;
        }

        Lift? lift = user.Lifts.FirstOrDefault(l => l.Name == name);
        if (lift == null) {
            return null;
        }
        return lift;
    }
}

/*
public async Task<Height> GetHeightAsync(int id)
    {
        var user =  await _context.Users.FindAsync(id);
        Height height = user.UserHeight;
        return height;
    }

    public async Task<Weight> GetWeightAsync(int id)
    {
        var user = await _context.Users.FindAsync(id);
        Weight weight = user.UserWeight;
        return weight;
    }

    public async Task<IEnumerable<Lift>> GetLiftsAsync(int id)
    {
        var user = await _context.Users.FindAsync(id);
        var lifts = user.Lifts;
        return [.. lifts];
    }

*/