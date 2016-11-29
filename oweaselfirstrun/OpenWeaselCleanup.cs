using System;
using System.IO;
using System.Diagnostics;
using Gtk;

namespace oweaselfirstrun
{
	public partial class OpenWeaselCleanup : Gtk.Window
	{
		public OpenWeaselCleanup () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();


			String changesudoers = "";
			String changesudo = File.ReadAllText("/etc/sudoers");
			// change after debug
			changesudo = changesudo.Replace("warlock ALL=(ALL) NOPASSWD: /home/warlock/documents/oweasel/oweaselfirstrun/oweaselfirstrun/bin/Debug/oweaselfirstrun.exe", changesudoers);
			File.WriteAllText("/etc/sudoers", changesudo);

			String changeautorun = "firefox-esr";
			String changeauto = File.ReadAllText ("/home/warlock/.gtkiw-2.sh");
			// change to /home/warlock/oweaselfirstrun.exe after debug
			changeauto = changeauto.Replace ("sudo /home/warlock/documents/oweasel/oweaselfirstrun/oweaselfirstrun/bin/Debug/oweaselfirstrun.exe", changeautorun);
			File.WriteAllText("/home/warlock/.gtkiw-2.sh", changeauto);
		
		}
		protected void OnClosebtReleased (object sender, EventArgs e)
		{
		Process firefox = new Process();
		firefox.StartInfo.FileName = "/usr/lib/firefox-esr/firefox-esr";
		firefox.Start ();
			Application.Quit ();
		}

	}
}

