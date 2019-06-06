using CoreApp.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreApp.Helpers
{
    //Get List of User then we don't need to query database
    public class CustomClaimsPrincipalFactory: UserClaimsPrincipalFactory<AppUser,AppRole>
    {
        UserManager<AppUser> _userManager;
        public CustomClaimsPrincipalFactory(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, IOptions<IdentityOptions> options) : base(userManager,roleManager,options){
            _userManager = userManager;
        }

        public async override Task<ClaimsPrincipal> CreateAsync(AppUser appUser)
        {
            //Create Claim Principal
            var principal = await base.CreateAsync(appUser);
            //Get role of AppUser
            var roles = await _userManager.GetRolesAsync(appUser);
            //Add fields of AppUser to UserClaims
            ((ClaimsIdentity)principal.Identity).AddClaims(new[]
            {
                new Claim("Email", appUser.Email),
                new Claim("FullName", appUser.FullName),
                new Claim("Avatar", appUser.Avatar??string.Empty),
                //Change to string of Role
                new Claim("Roles",string.Join(";",roles))
            });
            return principal;
        } 
    }
}
