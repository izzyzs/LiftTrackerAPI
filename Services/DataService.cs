namespace LiftTrackerAPI.Services;

using LiftTrackerAPI.Types;
using LiftTrackerAPI.Data;
using SQLitePCL;
using Yarp.ReverseProxy.Forwarder;

public interface IDataService
{
    Task<User> GetUserAsync(int id);
    Task<Height> GetHeightAsync(int id);
    Task<Weight> GetWeightAsync(int id);
    Task<IEnumerable<Lift>> GetLiftsAsync(int id);
    Task <Lift> GetLiftByNameAsync(int id, string name);
}

public class DataService : IDataService
{
    private readonly AppDbContext _context;    
    public DataService (AppDbContext context)
    {
        _context = context;
    }
    public async Task<User> GetUserAsync(int id)
    {
        var user = await _context.Users.FindAsync(id);
        return user;
    }

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

    public async Task<List<Lift>> GetLiftsAsync(int id)
    {
        var user = await _context.Users.FindAsync(id);
        var lifts = user.Lifts;
        return lifts;
    }

    public async Task<Lift> GetLiftByNameAsync(int id, string name)
    {
        var user = await _context.Users.FindAsync(id);
        var lifts = user.Lifts();
        foreach (Lift l in lifts) {
            if (l.Name == name) {
                return l;
            }
        }
        return null;
    }
}