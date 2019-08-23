using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Customerly.SDK.Models
{

    public class User
    {
        public Data data { get; set; }
    }

    public class Data
    {
        public int crmhero_user_id { get; set; }
        public string app_id { get; set; }
        public string user_id { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public int is_user { get; set; }
        public string last_page_viewed { get; set; }
        public int last_page_viewed_at { get; set; }
        public string ip_address { get; set; }
        public string timezone { get; set; }
        public string city { get; set; }
        public string region { get; set; }
        public string country { get; set; }
        public string isp { get; set; }
        public string browser_name { get; set; }
        public string browser_version { get; set; }
        public string browser_language { get; set; }
        public string os { get; set; }
        public string os_version { get; set; }
        public int web_session { get; set; }
        public int first_seen_at { get; set; }
        public object android_app_name { get; set; }
        public object android_app_version { get; set; }
        public object android_device { get; set; }
        public object android_os_version { get; set; }
        public object android_session { get; set; }
        public object android_last_seen_at { get; set; }
        public object ios_app_name { get; set; }
        public object ios_app_version { get; set; }
        public object ios_device { get; set; }
        public object ios_os_version { get; set; }
        public object ios_session { get; set; }
        public object ios_last_seen_at { get; set; }
        public string picture_initials { get; set; }
        public string picture_background { get; set; }
        public int picture_gravatar { get; set; }
        public int picture_gravatar_last_update { get; set; }
        public JToken custom { get; set; }
        public User_Segments[] user_segments { get; set; }
        public object[] user_tags { get; set; }
        public User_Events user_events { get; set; }
        public object[] user_notes { get; set; }
        public object[] companies { get; set; }
    }
    
    public class User_Events
    {
        public Send_Message_From_Timeline send_message_from_timeline { get; set; }
        public Section_Pricing_Visited section_pricing_visited { get; set; }
        public Payment_Submission_Completed payment_submission_completed { get; set; }
    }

    public class Send_Message_From_Timeline
    {
        public string first { get; set; }
        public string last { get; set; }
        public int count { get; set; }
    }

    public class Section_Pricing_Visited
    {
        public string first { get; set; }
        public string last { get; set; }
        public int count { get; set; }
    }

   


    public class Payment_Submission_Completed
    {
        public string first { get; set; }
        public string last { get; set; }
        public int count { get; set; }
    }

    public class User_Segments
    {
        public int segment_id { get; set; }
        public string app_id { get; set; }
        public int is_editable { get; set; }
        public string name { get; set; }
        public int last_update { get; set; }
        public object cron_lock { get; set; }
        public int entry_date { get; set; }
    }

}
