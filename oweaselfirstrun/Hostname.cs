using System;
using System.IO;
using Gtk;
namespace oweaselfirstrun
{
	public partial class Hostname : Gtk.Window
	{
		public Hostname () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
		protected void OnHostnameentryEditingDone (object sender, EventArgs e)
		{

		}		

		protected void OnOkbtReleased (object sender, EventArgs e)
		{
			String hostname = hostnameentry.Text;
			String hostnamefile = File.ReadAllText("/home/warlock/documents/oweasel/oweaselfirstrun/oweaselfirstrun/bin/Debug/hostname");
			String hostfile = File.ReadAllText("/home/warlock/documents/oweasel/oweaselfirstrun/oweaselfirstrun/bin/Debug/hosts");
			hostfile = hostfile.Replace("shastaweasel", hostname);
			hostnamefile = hostnamefile.Replace("shastaweasel", hostname);
			File.WriteAllText("/home/warlock/documents/oweasel/oweaselfirstrun/oweaselfirstrun/bin/Debug/hostname", hostnamefile);
			File.WriteAllText("/home/warlock/documents/oweasel/oweaselfirstrun/oweaselfirstrun/bin/Debug/hosts", hostfile);
		}


	}
}

