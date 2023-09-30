using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace BasicFacebookFeatures
{
    internal class DataUpdater
    {
        private readonly List<IObserver> m_Observers = new List<IObserver>();
        private Timer m_Timer;

        public void AddObserver(IObserver observer)
        {
            m_Observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            m_Observers.Remove(observer);
        }

        public void StartUpdatingData()
        {
            // Set up a timer to notify observers every 10 minutes.
            m_Timer = new Timer(10 * 60 * 1000); // 10 minutes in milliseconds
            m_Timer.Elapsed += OnTimerElapsed;
            m_Timer.Start();
        }

        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            // Notify all observers when the timer elapses.
            foreach (var observer in m_Observers)
            {
                observer.Update();
            }
        }
    }
}
