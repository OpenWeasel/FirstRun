using System;
using System.Diagnostics;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();

	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
		protected void OnAcceptbtReleased (object sender, EventArgs e)
	{
		Visible = false;
		Application.Init ();
		oweaselfirstrun.Hostname win = new oweaselfirstrun.Hostname ();
		win.Show ();
		Application.Run ();

	}
	protected void OnAcceptbtClicked (object sender, EventArgs e)
	{

		//Application.Quit ();


	}	


	protected void OnDeclinebtClicked (object sender, EventArgs e)
	{
		//throw new System.NotImplementedException ();
		Application.Quit ();
	}	



	


	



	
	

}
