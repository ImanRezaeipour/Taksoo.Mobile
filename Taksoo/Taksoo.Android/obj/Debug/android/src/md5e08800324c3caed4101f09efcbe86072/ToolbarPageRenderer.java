package md5e08800324c3caed4101f09efcbe86072;


public class ToolbarPageRenderer
	extends md5270abb39e60627f0f200893b490a1ade.NavigationPageRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onViewAdded:(Landroid/view/View;)V:GetOnViewAdded_Landroid_view_View_Handler\n" +
			"";
		mono.android.Runtime.register ("Taksoo.Droid.Control.ToolbarPageRenderer, Taksoo.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ToolbarPageRenderer.class, __md_methods);
	}


	public ToolbarPageRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == ToolbarPageRenderer.class)
			mono.android.TypeManager.Activate ("Taksoo.Droid.Control.ToolbarPageRenderer, Taksoo.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public ToolbarPageRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == ToolbarPageRenderer.class)
			mono.android.TypeManager.Activate ("Taksoo.Droid.Control.ToolbarPageRenderer, Taksoo.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public ToolbarPageRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == ToolbarPageRenderer.class)
			mono.android.TypeManager.Activate ("Taksoo.Droid.Control.ToolbarPageRenderer, Taksoo.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public void onViewAdded (android.view.View p0)
	{
		n_onViewAdded (p0);
	}

	private native void n_onViewAdded (android.view.View p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
