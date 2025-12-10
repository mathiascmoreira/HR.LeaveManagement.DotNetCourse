using HR.LeaveManagement.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR.LeaveManagement.Identity.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        var hasher = new PasswordHasher<ApplicationUser>();
        builder.HasData(
             new ApplicationUser
             {
                 Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                 Email = "admin@localhost.com",
                 NormalizedEmail = "ADMIN@LOCALHOST.COM",
                 FirstName = "System",
                 LastName = "Admin",
                 UserName = "admin@localhost.com",
                 NormalizedUserName = "ADMIN@LOCALHOST.COM",
                 //PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                 ConcurrencyStamp = "ed521a0f-5b08-4698-9291-95f4d0921a9e",
                 SecurityStamp = "5735cf23-edb7-4a9b-9a80-12a94c68c038",
                 PasswordHash = "AQAAAAIAAYagAAAAEIsgjsrC7yNN/CH9goqppcsGnhKQ5ZH1py2wEmaI2bS+sPEMS2GkvsNSd2avNHL/Gg==",
                 EmailConfirmed = true
             },
             new ApplicationUser
             {
                 Id = "9e224968-33e4-4652-b7b7-8574d048cdb9",
                 Email = "user@localhost.com",
                 NormalizedEmail = "USER@LOCALHOST.COM",
                 FirstName = "System",
                 LastName = "User",
                 UserName = "user@localhost.com",
                 NormalizedUserName = "USER@LOCALHOST.COM",
                 //PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                 ConcurrencyStamp = "a6913bb6-c542-43a4-875b-e949fde1785a",
                 SecurityStamp = "a1f2b2f3-c4f5-4641-8b02-a93a1b6b0abb",
                 PasswordHash = "AQAAAAIAAYagAAAAEIsgjsrC7yNN/CH9goqppcsGnhKQ5ZH1py2wEmaI2bS+sPEMS2GkvsNSd2avNHL/Gg==",
                 EmailConfirmed = true
             }
        );
    }
}
