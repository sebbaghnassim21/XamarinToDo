package crc64a13f97236b7b1578;


public abstract class SchedulerViewRenderer_2
	extends crc643f46942d9dd1fff9.ViewRenderer_2
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("DevExpress.XamarinForms.Scheduler.Droid.Internal.SchedulerViewRenderer`2, DevExpress.XamarinForms.Scheduler.Android", SchedulerViewRenderer_2.class, __md_methods);
	}


	public SchedulerViewRenderer_2 (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == SchedulerViewRenderer_2.class)
			mono.android.TypeManager.Activate ("DevExpress.XamarinForms.Scheduler.Droid.Internal.SchedulerViewRenderer`2, DevExpress.XamarinForms.Scheduler.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public SchedulerViewRenderer_2 (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == SchedulerViewRenderer_2.class)
			mono.android.TypeManager.Activate ("DevExpress.XamarinForms.Scheduler.Droid.Internal.SchedulerViewRenderer`2, DevExpress.XamarinForms.Scheduler.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public SchedulerViewRenderer_2 (android.content.Context p0)
	{
		super (p0);
		if (getClass () == SchedulerViewRenderer_2.class)
			mono.android.TypeManager.Activate ("DevExpress.XamarinForms.Scheduler.Droid.Internal.SchedulerViewRenderer`2, DevExpress.XamarinForms.Scheduler.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
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
