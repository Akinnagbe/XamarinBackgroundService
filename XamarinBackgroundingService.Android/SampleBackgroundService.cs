using System;
using Android.Content;
using AndroidX.Work;

namespace XamarinBackgroundingService.Droid
{
    public class SampleBackgroundService: Worker
    {
        public SampleBackgroundService(Context context, WorkerParameters workerParameters) : base(context, workerParameters)
        {
        }

        public override Result DoWork()
        {
            var taxReturn = GetTime();
            Android.Util.Log.Debug("Olamide", $"The time is : {taxReturn}");
            return Result.InvokeSuccess();
        }

        public string GetTime()
        {
            var time =  DateTime.Now.ToString();
            AndroidNotificationManager manager = AndroidNotificationManager.Instance ?? new AndroidNotificationManager();
            manager.SendNotification("New Email", time);
            return time;
        }


    }
}
