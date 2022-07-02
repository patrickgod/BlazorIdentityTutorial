using BlazorIdentityTutorial.Shared;
using Microsoft.AspNetCore.Identity;

namespace BlazorIdentityTutorial.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public List<SuperHero> SuperHeroes { get; set; } = new List<SuperHero>();
    }
}