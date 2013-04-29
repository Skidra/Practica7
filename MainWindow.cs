using System;
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

	protected void OnButton1Clicked (object sender, EventArgs e)
	{
		int puntos = 0;
		if(this.rb1.Active)
			puntos++;
		if(this.spin.Text=="4")
			puntos++;
		if(this.cb1.Active)
			puntos++;
		if(this.cb2.Active)
			puntos++;

		DateTime Fecha = this.calendario.GetDate();
		string fechaSeleccionada = Fecha.ToShortDateString();
		if(fechaSeleccionada=="16/09/1810")
			puntos++;
		
		this.total.Text=puntos.ToString ();
	}
}
