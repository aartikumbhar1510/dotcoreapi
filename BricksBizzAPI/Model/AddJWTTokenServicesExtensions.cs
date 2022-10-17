using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BricksBizzAPI.Model
{
    public static class AddJWTTokenServicesExtensions
    {
        public static void AddJWTTokenServices(IServiceCollection Services, IConfiguration Configuration)
        {
            // Add Jwt Setings
            var bindJwtSettings = new JwtSettings();
            Configuration.Bind("JsonWebTokenKeys", bindJwtSettings);
           
        }
    }

}
