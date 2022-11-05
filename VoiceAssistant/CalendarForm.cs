using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VoiceAssistant
{
    public partial class CalendarForm : Form
    {
        CalendarService service;
        Events events;
        public CalendarForm()
        {
            InitializeComponent();


            UserCredential credential;

            using (var stream =
                new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Google Calendar API service.
            service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
        }
        static string[] Scopes = { CalendarService.Scope.Calendar };
        static string ApplicationName = "Google Calendar API .NET Quickstart";
        private void Form3_Load(object sender, EventArgs e)
        {

            //Add();
            //List();
            //Remove();
            //List();

            ThemeApply();

        }
        public void List(int howMany)
        {
            // Define parameters of request.
            EventsResource.ListRequest request = service.Events.List("primary");
            request.TimeMin = DateTime.Now;
            request.ShowDeleted = false;
            request.SingleEvents = true;
            request.MaxResults = howMany;
            request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

            events = request.Execute();

            if (events.Items != null && events.Items.Count > 0)
            {
                int which = 0;
                foreach (var eventItem in events.Items)
                {
                    string when = eventItem.Start.DateTime.ToString();
                    if (String.IsNullOrEmpty(when))
                    {
                        when = eventItem.Start.Date;
                    }
                    var id = eventItem.Id;
                    which++;
                    label2.Text += which + ". " + eventItem.Summary + " (" + when + ")" + Environment.NewLine + Environment.NewLine;
                }
            }
            else
            {
                label2.Text = "No upcoming events found";
            }
        }
        public void Add(string name, DateTime from, DateTime to)
        {
            Event newEvent = new Event()
            {
                Summary = name,
                Start = new EventDateTime()
                {
                    DateTime = from,
                },
                End = new EventDateTime()
                {
                    DateTime = to,
                },
                //Recurrence = new String[] { "RRULE:FREQ=DAILY;COUNT=2" },
                //Reminders = new Event.RemindersData()
                //{
                //    UseDefault = false,
                //    Overrides = new EventReminder[] {
                //    new EventReminder() { Method = "email", Minutes = 24 * 60 },
                //    new EventReminder() { Method = "sms", Minutes = 10 },
                //    }
                //}
            };

            String calendarId = "primary";
            EventsResource.InsertRequest request = service.Events.Insert(newEvent, calendarId);
            Event createdEvent = request.Execute();
        }
        public string Remove(int which)
        {
            if(events.Items.Count > which)
            {
                var request2 = service.Events.Delete("primary", events.Items[which].Id);
                request2.Execute();
                Console.WriteLine(events.Items[which].Summary + " event was removed");
                return events.Items[which].Summary + " event was removed";
            }
            else
            {
                Console.WriteLine("This event is not in the calendar list");
                return "This event is not in the calendar list";
            }
        }
        private void ThemeApply()
        {
            if (Properties.Settings.Default.Theme)
            {
                this.BackColor = Color.FromArgb(34, 34, 34);
                this.ForeColor = Color.Bisque;
            }
        }
    }
}
