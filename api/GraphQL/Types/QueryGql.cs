namespace api.GraphQL.Types;

[GraphQLName("Query")]
public class QueryGql
{
    public UserGql GetMe()
    {
        return new UserGql()
        {
            id = 2,
            FullName = "ROfl ROFL",
            Email = "Rofl@Rofl.dk",
            AvatarUrl = "wwwROfl.rofl.rfol",
            IsAdmin = false
        };
    }
}