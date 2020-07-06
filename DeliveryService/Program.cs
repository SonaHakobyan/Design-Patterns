using System;
using System.Text;

namespace DeliveryService
{
   //[Flags]
    public enum EntryStatus
    {
        /// <summary>
        /// Entry started
        /// </summary>
        Started = 1,

        /// <summary>
        /// Entry finished with a warning
        /// </summary>
        Warning = 2,
        /// <summary>
        /// Entry succeed
        /// </summary>
        Success = 4,
    }
    class Program
    {
        static void Main(string[] args)
        {
            //var entryStatuses = EntryStatus.Started | EntryStatus.Warning;
            //var EntryStarted = entryStatuses.HasFlag(EntryStatus.Started);
            //var EntrySuccess = entryStatuses.HasFlag(EntryStatus.Success);

            //var a = entryStatuses.ToString();


            //var builder = new StringBuilder();
            //var b = builder
            //    .Append((entryStatuses & EntryStatus.Success) != 0 ? EntryStatus.Success.ToString() + " " : string.Empty)
            //    .Append((entryStatuses & EntryStatus.Warning) != 0 ? EntryStatus.Warning.ToString() + " " : string.Empty)
            //    .Append((entryStatuses & EntryStatus.Started) != 0 ? EntryStatus.Started.ToString() + " " : string.Empty)
            //    .ToString().Trim().Replace(' ', ',');

            //object o = null;
            //string s = null;
            //if (o is object)
            //{
            //    int c = 1;
            //}

            //if (s is string)
            //{
            //    int c = 1;
            //}

            //if (o is string)
            //{
            //    int c = 1;
            //}

            //var scheduledDate1 = o is string schDat ? schDat : o?.ToString();
            var a = EntryStatus.Started.ToString();

            Console.WriteLine(a.ToLower());
        }
    }
}
