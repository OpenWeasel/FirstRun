using System;
using System.IO;
using Gtk;

namespace oweaselfirstrun
{
	public partial class UpdateServer : Gtk.Window
	{
		public UpdateServer () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
		protected void OnUpdateserveraddressentryEditingDone (object sender, EventArgs e)
		{
	
		}
		protected void OnOkbtReleased (object sender, EventArgs e)
		{

			String updateserver = updateserveraddressentry.Text;
			String autorun = File.ReadAllText("/home/warlock/.gtkiw-2.sh");
			autorun = autorun.Replace("weaseltestclient.kok.lan", updateserver);
			File.WriteAllText("/home/warlock/.gtkiw-2.sh", autorun);

			Visible = false;
			Application.Init ();
			oweaselfirstrun.OpenWeaselCleanup win = new oweaselfirstrun.OpenWeaselCleanup ();
			win.Show ();
			Application.Run ();

		}		



	}
}

