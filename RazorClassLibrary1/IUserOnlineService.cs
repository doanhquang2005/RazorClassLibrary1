using System.Security.Claims;
using System.Threading.Tasks;

namespace RazorClassLibrary1
{

  public interface IUserOnlineService {

    Task Online(ClaimsPrincipal user, bool isOnline = true);
  }
}