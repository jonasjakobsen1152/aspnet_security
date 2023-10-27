namespace api.GraphQL.Types;

[GraphQLName("User")]
public class UserGql
{
    public int id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string AvatarUrl { get; set; }
    
    public bool IsAdmin { get; set; }
}