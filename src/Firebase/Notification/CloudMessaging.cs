﻿using Plugin.Firebase.CloudMessaging;

namespace MetaFrm.Maui.Essentials.Firebase.Notification
{
    /// <summary>
    /// Firebase Messaging lets you reliably deliver messages at no cost. To send or receive messages, the app must get a registration token from InstanceID. This token authorizes an app server to send messages to an app instance.
    /// </summary>
    public class CloudMessaging : Maui.Notification.ICloudMessaging
    {
        /// <summary>
        /// Gets invoked when the fcm registration token has changed.
        /// </summary>
        public event Maui.Notification.TokenChanged? TokenChangedEvent { add { } remove { } }
        /// <summary>
        /// Gets invoked when a new fcm notification was received.
        /// </summary>
        public event Maui.Notification.NotificationReceived? NotificationReceivedEvent { add { } remove { } }

        private Maui.Notification.NotificationTapped? NotificationTapped;
        /// <summary>
        /// Gets invoked when a received fcm notification was tapped by the user.
        /// </summary>
        public event Maui.Notification.NotificationTapped? NotificationTappedEvent
        {
            add
            {
                NotificationTapped += value;

                try
                {
                    try
                    {
                        CrossFirebaseCloudMessaging.Current.NotificationTapped -= Notification_Tapped;
                    }
                    catch (Exception)
                    {
                    }
                    CrossFirebaseCloudMessaging.Current.NotificationTapped += Notification_Tapped;
                }
                catch (Exception)
                {
                }
            }
            remove
            {
                try
                {
                    CrossFirebaseCloudMessaging.Current.NotificationTapped -= Notification_Tapped;
                }
                catch (Exception)
                {
                }

                NotificationTapped -= value;
            }
        }

        private void Notification_Tapped(object? sender, Plugin.Firebase.CloudMessaging.EventArgs.FCMNotificationTappedEventArgs e) => NotificationTapped?.Invoke(this, new Maui.Notification.NotificationTappedEventArgs(new Maui.Notification.NotificationData(e.Notification.Body, e.Notification.Title, e.Notification.ImageUrl, e.Notification.Data)));

        /// <summary>
        /// Gets invoked when something went wrong during the validity check.
        /// </summary>
        public event Maui.Notification.Error? ErrorEvent { add { } remove { } }
    }
}