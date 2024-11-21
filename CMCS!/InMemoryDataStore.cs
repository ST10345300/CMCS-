namespace CMCS_;
using CMCS_.Models;
using System.Collections.Generic;
using System.Linq;

public static class InMemoryDataStore
{
    private static List<LecturerClaim> _claims = new List<LecturerClaim>();

    public static List<LecturerClaim> GetAllClaims() => _claims;

    public static LecturerClaim GetClaimById(int id) => _claims.FirstOrDefault(c => c.Id == id);

    public static void AddClaim(LecturerClaim claim)
    {
        claim.Id = _claims.Any() ? _claims.Max(c => c.Id) + 1 : 1;
        _claims.Add(claim);
    }

    public static void UpdateClaimStatus(int id, string status)
    {
        var claim = GetClaimById(id);
        if (claim != null)
        {
            claim.Status = status;
        }
    }
}
