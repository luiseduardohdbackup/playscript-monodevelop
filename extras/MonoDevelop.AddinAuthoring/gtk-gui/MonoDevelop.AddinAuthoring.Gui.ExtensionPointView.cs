
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.AddinAuthoring.Gui
{
	public partial class ExtensionPointView
	{
		private global::Gtk.VBox vbox3;
		private global::Gtk.Label labelName;
		private global::Gtk.Label label1;
		private global::Gtk.Label labelDesc;
		private global::Gtk.VBox vbox4;
		private global::Gtk.Label label9;
		private global::Gtk.Table tableNodes;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.AddinAuthoring.Gui.ExtensionPointView
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.AddinAuthoring.Gui.ExtensionPointView";
			// Container child MonoDevelop.AddinAuthoring.Gui.ExtensionPointView.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 12;
			// Container child vbox3.Gtk.Box+BoxChild
			this.labelName = new global::Gtk.Label ();
			this.labelName.Name = "labelName";
			this.labelName.Xalign = 0F;
			this.labelName.LabelProp = "<b>Addin Name</b>";
			this.labelName.UseMarkup = true;
			this.vbox3.Add (this.labelName);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.labelName]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = global::Mono.Addins.AddinManager.CurrentLocalizer.GetString ("<b><i>Remarks:</i></b>");
			this.label1.UseMarkup = true;
			this.vbox3.Add (this.label1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.label1]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.labelDesc = new global::Gtk.Label ();
			this.labelDesc.Name = "labelDesc";
			this.labelDesc.Xalign = 0F;
			this.labelDesc.LabelProp = "Some description";
			this.labelDesc.Wrap = true;
			this.vbox3.Add (this.labelDesc);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.labelDesc]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.Xalign = 0F;
			this.label9.LabelProp = global::Mono.Addins.AddinManager.CurrentLocalizer.GetString ("<b><i>Extension nodes:</i></b>");
			this.label9.UseMarkup = true;
			this.vbox4.Add (this.label9);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.label9]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.tableNodes = new global::Gtk.Table (((uint)(3)), ((uint)(2)), false);
			this.tableNodes.Name = "tableNodes";
			this.tableNodes.RowSpacing = ((uint)(6));
			this.tableNodes.ColumnSpacing = ((uint)(6));
			this.vbox4.Add (this.tableNodes);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.tableNodes]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			this.vbox3.Add (this.vbox4);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.vbox4]));
			w6.Position = 3;
			this.Add (this.vbox3);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
