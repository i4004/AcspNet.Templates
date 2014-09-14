using AcspNet;
using AcspNet.Attributes;
using AcspNet.Responses;

namespace $safeprojectname$.Controllers
{
	[Get("/")]
	public class DefaultController : Controller
	{
		public override ControllerResponse Invoke()
		{
			return new Tpl("Hello world!");
		}
	}
}