using System.Security.Cryptography;

namespace FitBitesLibrary.Infraestructure.Models;
public class GenarateRefreshToken {
    public static string GenerateRefreshToken() {
        var randomNumber = new byte[32];
        using (var rng = RandomNumberGenerator.Create()) {
            rng.GetBytes(randomNumber);
        }
        return Convert.ToBase64String(randomNumber);
    }
}
