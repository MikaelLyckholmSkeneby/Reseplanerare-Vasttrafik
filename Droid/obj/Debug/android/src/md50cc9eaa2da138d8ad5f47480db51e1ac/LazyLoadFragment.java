package md50cc9eaa2da138d8ad5f47480db51e1ac;


public abstract class LazyLoadFragment
	extends android.support.v4.app.Fragment
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("stops.LazyLoadFragment, stops", LazyLoadFragment.class, __md_methods);
	}


	public LazyLoadFragment ()
	{
		super ();
		if (getClass () == LazyLoadFragment.class)
			mono.android.TypeManager.Activate ("stops.LazyLoadFragment, stops", "", this, new java.lang.Object[] {  });
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
