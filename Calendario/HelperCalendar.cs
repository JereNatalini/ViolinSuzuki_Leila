using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViolinSuzuki_Leila
{
    class HelperCalendar
    {
        /* const string ApiKey = "AIzaSyDIqEMnhvVv1I8L1cdO3rxjYupy6KwR4tc";
        const string CalendarId = "3fc789bb5571635bbb68816a8dd88feadf4bbbfe400902dc3ea07a0edd69315c@group.calendar.google.com";

        static async Task Main(string[] args)
        {
            var service = new CalendarService(new BaseClientService.Initializer()
            {
                ApiKey = ApiKey,
                ApplicationName = "ViolinSuzukiCalendar"
            });


            var request = service.Events.List(CalendarId);
            request.Fields = "items(summary,start,end)";
            var response = await request.ExecuteAsync();

            foreach (var item in response.Items)
            {
                Console.WriteLine($"Holiday : {item.Summary} start: {item.Start} end: {item.End}");
            }

            Console.ReadLine();
        } */

    }
}
