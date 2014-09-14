using AcspNet.Owin;
using Owin;

namespace $safeprojectname$
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			app.UseAcspNet();
		}
	}
}