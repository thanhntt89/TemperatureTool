using System.ComponentModel;

namespace TemperatureTool.Models
{
    public class DataExport
    {      
        [Description("​番号")]
        public int index { get; set; }
        [Description("名前")]
        public string name { get; set; }
        [Description("生年月日")]
        public string birthday { get; set; }
        [Description("郵便番号")]
        public string postno { get; set; }
        [Description("メールアドレス")]
        public string email { get; set; }
        [Description("S/N")]
        public string sn { get; set; }
        [Description("USER ID")]
        public string user_id { get; set; }
        [Description("年月日")]
        public string date { get; set; }
        [Description("代表温度")]
        public string temp { get; set; }
        [Description("体重")]
        public string weight { get; set; }
        [Description("生理")]
        public string menstruation { get; set; }
        [Description("不正出血")]
        public string abnormal_bleeding { get; set; }
        [Description("体調不良")]
        public string poor_physical_condition { get; set; }
        [Description("性交渉")]
        public string sexual_intercourse { get; set; }
        [Description("おりもの")]
        public string vaginal_discharge { get; set; }
        [Description("寝不足")]
        public string lack_sleep { get; set; }
        [Description("飲酒")]
        public string drinking_alcohol { get; set; }
        [Description("運動")]
        public string motion { get; set; }
        [Description("休暇")]
        public string vacation { get; set; }
        [Description("通院")]
        public string commuting_hospital { get; set; }
        [Description("服薬")]
        public string taking_medicine { get; set; }
        [Description("気分悪い")]
        public string feel_sick { get; set; }
        [Description("気分普通")]
        public string mood_norma { get; set; }
        [Description("メモ")]
        public string memo { get; set; }
        [Description("時間")]
        public string time { get; set; }
        [Description("皮膚側温度")]
        public string skin_temp { get; set; }
        [Description("外気温度")]
        public string outsite_temp { get; set; }
        [Description("計算温度")]
        public string cal_temp { get; set; }
        [Description("スタートフラグ")]
        public string start_flag { get; set; }
        [Description("ストップフラグ")]
        public string end_flag { get; set; }
        [Description("代表データの使用有無")]
        public string data_flg { get; set; }

    }
}
