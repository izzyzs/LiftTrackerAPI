namespace LiftTrackerAPI.Types;

using LiftTrackerAPI.Data;
using LiftTrackerAPI.Services;
using System.Linq;

public class Query
{

    [UseProjection]
    public IQueryable<User>? GetUser(int id, IDataService dataService, CancellationToken ct) {
        User? user = dataService.GetUser(id);
        if (user == null)
        {
            return null;
        }
        return (IQueryable<User>)user;
    }

    [UseProjection]
    public IQueryable<Lift>? GetLiftByName(int id, string name, IDataService dataService, CancellationToken ct) {
        Lift? lift = dataService.GetLiftByName(id, name);
        if (lift == null)
        {
            return null;
        }
        return (IQueryable<Lift>)lift;
    }
}
// public Task<Height> GetHeight(int id, CancellationToken ct) {
    //     return _dataService.GetHeightAsync(id);
    // }

    // public Task<Weight> GetWeight(int id, CancellationToken ct) {
    //     return _dataService.GetWeightAsync(id);
    // }

    // public async Task<List<Lift>> GetLifts(int id, CancellationToken ct) {
    //     return lifts.ToList();
    // }


// }

// public class QueryType : ObjectType
// {
//     protected override void Configure(IObjectTypeDescriptor descriptor)
//     {
//         descriptor
//             .Field("user")
//             .Argument("id", a => a.Type<IntType>())
//             .ResolveWith<QueryResolvers>(r => r.GetUser(default, default));
            

//         descriptor
//             .Field("height")
//             .Argument("id", a => a.Type<IntType>())
//             .ResolveWith<QueryResolvers>(r => r.GetHeight(default, default)); 

//         descriptor
//             .Field("weight")
//             .Argument("id", a => a.Type<IntType>())
//             .ResolveWith<QueryResolvers>(r => r.GetWeight(default, default));

//         descriptor
//             .Field("lifts")
//             .Argument("id", a => a.Type<IntType>())
//             .ResolveWith<QueryResolvers>(r => r.GetLifts(default, default));


//         descriptor
//             .Field("lift")
//             .Argument("id", a => a.Type<IntType>())
//             .Argument("name", a => a.Type<StringType>())
//             .ResolveWith<QueryResolvers>(r => r.GetLiftByName());
//     }
// }