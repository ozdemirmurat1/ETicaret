using Microsoft.AspNetCore.Http;

namespace Eticaret.PresentationEnSon.Areas.Admin.Helpers
{
    public interface IAdminChecker
    {
        bool Check(HttpRequest request);
    }
}