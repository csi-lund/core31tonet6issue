using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace rerun31
{
    [Route("/ErrorStatus")]
    public class ErrorController
    {
        public async Task<IActionResult> IndexAsync(int statusCode = 500)
        {
            return new StatusCodeResult(statusCode);
        }
    }
}
