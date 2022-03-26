package crc649ee09f68c265a75d;


public abstract class DayViewBaseRenderer_1
	extends crc64a13f97236b7b1578.SchedulerViewRenderer_2
	implements
		mono.android.IGCUserPeer,
		com.devexpress.scheduler.views.interop.NativeDayViewBaseInterop,
		com.devexpress.scheduler.views.interop.NativeGestureListener,
		com.devexpress.scheduler.views.interop.NativeIdleProvider
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_dayViewTopRowIndexChanged:(D)V:GetDayViewTopRowIndexChanged_DHandler:DevExpress.XamarinAndroid.Scheduler.Interop.INativeDayViewBaseInteropInvoker, DevExpress.Xamarin.Android.Scheduler\n" +
			"n_requestContainers:(I)[Lcom/devexpress/scheduler/viewInfos/containers/DayContainerViewInfo;:GetRequestContainers_IHandler:DevExpress.XamarinAndroid.Scheduler.Interop.INativeDayViewBaseInteropInvoker, DevExpress.Xamarin.Android.Scheduler\n" +
			"n_doubleTap:(Lcom/devexpress/scheduler/views/hittesting/SchedulerHitInfo;)V:GetDoubleTap_Lcom_devexpress_scheduler_views_hittesting_SchedulerHitInfo_Handler:DevExpress.XamarinAndroid.Scheduler.Interop.INativeGestureListenerInvoker, DevExpress.Xamarin.Android.Scheduler\n" +
			"n_longPress:(Lcom/devexpress/scheduler/views/hittesting/SchedulerHitInfo;)V:GetLongPress_Lcom_devexpress_scheduler_views_hittesting_SchedulerHitInfo_Handler:DevExpress.XamarinAndroid.Scheduler.Interop.INativeGestureListenerInvoker, DevExpress.Xamarin.Android.Scheduler\n" +
			"n_tap:(Lcom/devexpress/scheduler/views/hittesting/SchedulerHitInfo;)V:GetTap_Lcom_devexpress_scheduler_views_hittesting_SchedulerHitInfo_Handler:DevExpress.XamarinAndroid.Scheduler.Interop.INativeGestureListenerInvoker, DevExpress.Xamarin.Android.Scheduler\n" +
			"n_idle:()V:GetIdleHandler:DevExpress.XamarinAndroid.Scheduler.Interop.INativeIdleProviderInvoker, DevExpress.Xamarin.Android.Scheduler\n" +
			"";
		mono.android.Runtime.register ("DevExpress.XamarinForms.Scheduler.Android.DayViewBaseRenderer`1, DevExpress.XamarinForms.Scheduler.Android", DayViewBaseRenderer_1.class, __md_methods);
	}


	public DayViewBaseRenderer_1 (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == DayViewBaseRenderer_1.class)
			mono.android.TypeManager.Activate ("DevExpress.XamarinForms.Scheduler.Android.DayViewBaseRenderer`1, DevExpress.XamarinForms.Scheduler.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public DayViewBaseRenderer_1 (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == DayViewBaseRenderer_1.class)
			mono.android.TypeManager.Activate ("DevExpress.XamarinForms.Scheduler.Android.DayViewBaseRenderer`1, DevExpress.XamarinForms.Scheduler.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public DayViewBaseRenderer_1 (android.content.Context p0)
	{
		super (p0);
		if (getClass () == DayViewBaseRenderer_1.class)
			mono.android.TypeManager.Activate ("DevExpress.XamarinForms.Scheduler.Android.DayViewBaseRenderer`1, DevExpress.XamarinForms.Scheduler.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public void dayViewTopRowIndexChanged (double p0)
	{
		n_dayViewTopRowIndexChanged (p0);
	}

	private native void n_dayViewTopRowIndexChanged (double p0);


	public com.devexpress.scheduler.viewInfos.containers.DayContainerViewInfo[] requestContainers (int p0)
	{
		return n_requestContainers (p0);
	}

	private native com.devexpress.scheduler.viewInfos.containers.DayContainerViewInfo[] n_requestContainers (int p0);


	public void doubleTap (com.devexpress.scheduler.views.hittesting.SchedulerHitInfo p0)
	{
		n_doubleTap (p0);
	}

	private native void n_doubleTap (com.devexpress.scheduler.views.hittesting.SchedulerHitInfo p0);


	public void longPress (com.devexpress.scheduler.views.hittesting.SchedulerHitInfo p0)
	{
		n_longPress (p0);
	}

	private native void n_longPress (com.devexpress.scheduler.views.hittesting.SchedulerHitInfo p0);


	public void tap (com.devexpress.scheduler.views.hittesting.SchedulerHitInfo p0)
	{
		n_tap (p0);
	}

	private native void n_tap (com.devexpress.scheduler.views.hittesting.SchedulerHitInfo p0);


	public void idle ()
	{
		n_idle ();
	}

	private native void n_idle ();

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
