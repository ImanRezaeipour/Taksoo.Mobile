package md509e7f96a8708aa60c6e394653b911613;


public class OpenApp
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Taksoo.Droid.DependencyService.OpenApp, Taksoo.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", OpenApp.class, __md_methods);
	}


	public OpenApp ()
	{
		super ();
		if (getClass () == OpenApp.class)
			mono.android.TypeManager.Activate ("Taksoo.Droid.DependencyService.OpenApp, Taksoo.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

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
