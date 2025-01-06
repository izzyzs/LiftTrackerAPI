namespace LiftTrackerAPI.Types;

using LiftTrackerAPI.Services;
using System.Linq;

public class QueryResolvers
{
    private readonly IDataService _dataService;
    public QueryResolvers(IDataService dataService)
    {
        _dataService = dataService;
    }
    public Task<User> GetUser(int id, CancellationToken ct) {
        try 
        { 
            return _dataService.GetUserAsync(id);
        } 
        catch (Exception e)
        {
            Console.WriteLine(e.Message); 
            return null;
        }
    }

    public Task<Height> GetHeight(int id, CancellationToken ct) {
        try 
        { 
            return _dataService.GetHeightAsync(id);
        } 
        catch (Exception e)
        {
            Console.WriteLine(e.Message); 
            return null;
        }
    }

    public Task<Weight> GetWeight(int id, CancellationToken ct) {
        try 
        { 
            return _dataService.GetWeightAsync(id);
        } 
        catch (Exception e)
        {
            Console.WriteLine(e.Message); 
            return null;
        }
    }

    public async Task<List<Lift>> GetLifts(int id, CancellationToken ct) {
        var lifts = await _dataService.GetLiftsAsync(id);
        return lifts.ToList();
    }

    public async Task<Lift> GetLiftByName(int id, string? name,CancellationToken ct) {
        var lifts = await this.GetLifts(id, ct);
        Lift l;
        foreach (Lift i in lifts)
        {
            if (i.Name == name)
            {
                return i;
            }
        }
        return null;
    }
}

public class QueryType : ObjectType
{
    protected override void Configure(IObjectTypeDescriptor descriptor)
    {
        descriptor
            .Field("user")
            .Argument("id", a => a.Type<IntType>())
            .ResolveWith<QueryResolvers>(r => r.GetUser(default, default));
            

        descriptor
            .Field("height")
            .Argument("id", a => a.Type<IntType>())
            .ResolveWith<QueryResolvers>(r => r.GetHeight(default, default)); 

        descriptor
            .Field("weight")
            .Argument("id", a => a.Type<IntType>())
            .ResolveWith<QueryResolvers>(r => r.GetWeight(default, default));

        descriptor
            .Field("lifts")
            .Argument("id", a => a.Type<IntType>())
            .ResolveWith<QueryResolvers>(r => r.GetLifts(default, default));


        descriptor
            .Field("lift")
            .Argument("id", a => a.Type<IntType>())
            .Argument("name", a => a.Type<StringType>())
            .ResolveWith<QueryResolvers>(r => r.GetLiftByName(default, default, default));
    }
}