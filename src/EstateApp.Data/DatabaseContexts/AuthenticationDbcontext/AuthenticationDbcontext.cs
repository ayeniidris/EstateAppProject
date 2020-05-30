using EstateApp.Data.Entities;
using Microsoft.AspNetcore.Identity.EntityFrameworkcore;

namespace EstateApp.Data.Databasecontexts.AuthenticationDbcontext
{
    public class AuthenticationDbcontext : IdentityDbContext<ApplicationUser>
    {
        public AuthenticationDbcontexT(DbContextoptions<AuthenticationDbContext> options)
            :base(options)
        {
            
        }
    }
}