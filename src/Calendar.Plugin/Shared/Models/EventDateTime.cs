using System;
using Xamarin.Forms;

namespace Xamarin.Plugin.Calendar.Models
{
    public class EventDateTime : IComparable, IComparable<DateTime>, IEquatable<DateTime>
    {
        public EventDateTime(DateTime date, Color markColor)
        {
            Date = date;
            MarkColor = markColor;
        }

        public DateTime Date { get; set; }

        public Color MarkColor { get; set; }

        public int CompareTo(object obj)
        {
            return Date.CompareTo(obj);
        }

        public int CompareTo(DateTime other)
        {
            return Date.CompareTo(other);
        }

        public bool Equals(DateTime other)
        {
            return Date.Equals(other);
        }
    }
}