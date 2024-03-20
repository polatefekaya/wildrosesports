using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.Domain.IdentityEntities {
    public class ApplicationUser : IdentityUser<Guid> {
        public string? PersonName { get; set; }
    }
}
