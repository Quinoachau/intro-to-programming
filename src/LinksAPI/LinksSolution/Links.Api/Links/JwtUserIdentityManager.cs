namespace Links.Api.Links;

public class JwtUserIdentityManager : IManagerUserIdentity
{
    public Task<string> GetSubjectAsync()
    {
        return Task.FromResult("TestEmail@gmail.com");
    }
}
