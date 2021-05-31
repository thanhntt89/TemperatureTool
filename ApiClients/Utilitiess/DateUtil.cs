using System;
using TimeZoneConverter;

namespace TemperatureTool.ApiClients.Utilitiess
{
    class DateUtil
    {

        // 現在時刻（JST）
        public static DateTime NowJst()
        {
            TimeZoneInfo jstZoneInfo = TZConvert.GetTimeZoneInfo("Tokyo Standard Time");
            DateTime utc = DateTime.UtcNow;          
            DateTime jst = TimeZoneInfo.ConvertTimeFromUtc(utc, jstZoneInfo);
           
            return jst;

        }

        // 当日文字列（yyyy/mm/dd）
        public static string TodayStr()
        {
            DateTime today = NowJst();

            return today.ToString("yyyy/MM/dd");

        }
    }
}
