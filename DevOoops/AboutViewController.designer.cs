// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace DevOoops
{
	[Register ("AboutViewController")]
	partial class AboutViewController
	{
		[Outlet]
		DevOoops.CustomControls.HyperlinkTextField GitHubLink { get; set; }

		[Outlet]
		DevOoops.CustomControls.HyperlinkTextField TwitterLink { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (GitHubLink != null) {
				GitHubLink.Dispose ();
				GitHubLink = null;
			}

			if (TwitterLink != null) {
				TwitterLink.Dispose ();
				TwitterLink = null;
			}
		}
	}
}
