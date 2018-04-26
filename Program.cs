using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //分別定義變數
            double bloodb = 0;
            double blooda = 0;
            double bloodo = 0;
            double bloodother = 0;

            //陣列資料
            int[] height = { 173, 0, 179, 155, 183, 170, 163, 174, 165, 189, 177, 180, 154, 167, 170, 173, 165, 158, 180, 165, 153, 175, 162, 165, 0, 160, 165, 173, 164, 177, 177, 180, 170, 151, 176, 180, 168, 152, 666, 2147483647, 165, 155, 777, 173, 169, 170, 169, 171, 0, 170, 150, 160, 155, 164, 163, 165, 184, 0, 155, 0, 168, 160, 0, 0, 150 };
            string[] zodiac = { "金牛", "", "巨蟹", "白羊", "雙魚", "雙子", "天蠍", "巨蟹", "獅子", "雙魚", "雙子", "雙子", "獅子", "雙魚", "天蠍", "天蠍", "處女", "處女", "金牛", "雙魚", "處女", "摩羯", "雙魚", "白羊", "天蠍", "處女", "雙子", "金牛", "雙子", "白羊", "白羊", "摩羯", "射手", "巨蟹", "雙魚", "獅子", "射手", "摩羯", "天蠍", "", "雙魚", "雙子", "", "雙魚", "處女", "金牛", "天秤", "水瓶", "巨蟹", "處女", "白羊", "摩羯", "水瓶", "天秤", "金牛", "天蠍", "天蠍", "", "", "", "摩羯", "天蠍", "雙子", "", "獅子" };
            string[] names = { "葉俊廷", "張澤瑜", "王程捷", "江儀婷", "張秉華", "陳柏霖", "黃紀瑜", "黃昱維", "蔡逸群", "登琳", "世新魏鈞孝吧", "劉定南", "陳信如", "童信傑", "李岳倫", "鄒和恆", "簡毓玟", "劉子瑄", "蕭紹洋", "李亞宸la", "張以潔", "邱仕紳", "呂家瑩", "世新林鑫佑", "徐均得", "陳佳欣", "張恩瑋", "周詮", "王湘婷", "蕭宇成", "Max Cheung(BANG)", "馬嘉誠Σヽ(ﾟД ﾟ; )ﾉ魔貫光殺砲(ﾟДﾟ)σ━0000", "陳昱嘉", "康珈熏", "盧奕宏", "陳郁佳的大哥黃博涵", "遲正雯", "世新林星彤", "許晏誠ｘ勒是奇多＿８＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝Ｄ　", "許子安", "高子晴", "陳思婷", "矝鵘鮿", "余彥廷", "吳耀輝", "鄭丞智", "林冠廷", "世新何曜宇", "邵喬雨", "張豐愷", "林子晴", "邱雁回", "陳家欣是韓妞", "鄧雅馨", "謝汶珊", "李曼寧", "世新徐偉哲", "张钰慈", "鍾宜珊", "raer_tsai", "世新李姳諼", "鄭曼君", "陳柏霖", "世新許子安", "世新方若帆" };
            string[] blood = { "O", "其他", "O", "O", "A", "O", "A", "A", "O", "O", "A", "O", "A", "B", "O", "O", "A", "其他", "O", "O", "A", "", "B", "O", "", "O", "B", "O", "B", "B", "B", "O", "O", "AB", "O", "B", "A", "O", "O", "", "O", "A", "", "O", "O", "A", "O", "O", "其他", "B", "O", "O", "O", "A", "AB", "A", "O", "", "AB", "", "O", "O", "O", "", "O" };
            string[] sns = { "A106082026", "A106082016", "A106082062", "A106082054", "A104082006", "A106082029", "A106082046", "A106082030", "A106082022", "A106082034", "A103082022", "A106082020", "A106082011", "A106082024", "A105082201", "106082010", "A106082028", "a106082056", "a106082043", "A106082006", "A106082051", "A106082032", "a106082058", "A106082035", "a106082017", "A104082036", "A106082009", "a106082007", "A106082052", "A106082008", "A106082063", "A106082038", "A106082025", "A106082057", "A106082013", "A106082027", "A106082048", "a106082036", "A106082059", "a106082045", "A106082012", "A106082037", "A106082021", "A106082031", "A106082061", "A106082042", "A106082023", "A106082040", "A106082001", "a106082002", "A106082014", "A106082041", "A106082049", "A106082015", "A106082044", "A106082047", "A106082018", "A106082005", "A106082050", "a106082055", "A106082039", "A104082013", "A106082029", "", "A104040024" };
            string[] genders = { "男", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "男", "女", "男", "男", "男", "女", "女", "男", "男", "女", "男", "女", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "女", "男", "男", "女", "女", "男", "男", "女", "女", "男", "男", "男", "男", "男", "男", "女", "男", "女", "女", "女", "女", "女", "女", "男", "女", "女", "女", "女", "女", "男", "男", "女", "女", "女", "男" };
            double grilsum = 0;
            double sum = 0;
            double boysum = 0;
            double lenghboy = 0;
            double lenghgril = 0;
            double lengh = 0;
            Console.WriteLine("天蠍座O型的人有:");
            int max = 0;
            int min = 200;
            //陣列計算
            for (int i = 0; i < sns.Length; i++)
            {
                if (height[i] > 100 && height[i] < 200)
                {
                    if (height[i] > max)
                    {
                        max = height[i];
                    }
                    if (height[i] < min)
                    {
                        min = height[i];
                    }
                    if (genders[i] == "男")
                    {
                        boysum = boysum + height[i];
                    }
                    if (genders[i] == "女")
                    {
                        grilsum = grilsum + height[i];
                    }
                    if (genders[i] == "男")
                    {
                        lenghboy++;
                    }
                    if (genders[i] == "女")
                    {
                        lenghgril++;
                    }
                    sum = sum + height[i];
                    lengh++;
                }
                if (zodiac[i] == "天蠍" && blood[i] == "O")
                {
                    Console.Write(names[i] + "\n");
                }

                if (blood[i] == "B")
                {
                    bloodb++;
                }
                if (blood[i] == "A")
                {
                    blooda++;
                }
                if (blood[i] == "O")
                {
                    bloodo++;
                }
                if (blood[i] == "其他")
                {
                    bloodother++;
                }
            }

            double all = blood.Length;
            double grilhightaverage = grilsum / lenghgril;
            double boyhightaverage = boysum / lenghboy;
            double bloodbpersent = 100 * (bloodb / all);
            double bloodapersent = 100 * (blooda / all);
            double bloodopersent = 100 * (bloodo / all);
            double bloodotherpersent = 100 * (bloodother / all);
            double boypersent = 100 * (lenghboy / all);
            double grilpersent = 100 * (lenghgril / all);
            double hightaverage = sum / lengh;
            //輸出
            Console.WriteLine("男生人數:" + lenghboy + "   " + boypersent + "%");
            Console.WriteLine("女生人數:" + lenghgril + "   " + grilpersent + "%");
            Console.WriteLine("血型A的人數:" + blooda + "  " + bloodapersent + "%");
            Console.WriteLine("血型B的人數:" + bloodb + "  " + bloodbpersent + "%");
            Console.WriteLine("血型O的人數:" + bloodo + "  " + bloodopersent + "%");
            Console.WriteLine("血型其他的人數:" + bloodother + "  " + bloodotherpersent + "%");
            Console.WriteLine("全班女生平均身高:" + grilhightaverage);
            Console.WriteLine("全班男生平均身高:" + boyhightaverage);
            Console.WriteLine("全班平均身高:" + hightaverage);
            Console.WriteLine("班級最高身高:" + max);
            Console.WriteLine("班級最低身高:" + min);
            Console.Write("請輸入學號:");

            string sn = Console.ReadLine();
            int herN = -1;
            //迴圈
            for (int i = 0; i < sns.Length; i++)
            {
                if (sn == sns[i])
                {
                    herN = i;
                }
            }

            Console.WriteLine(names[herN]);
            Console.WriteLine(zodiac[herN]);
            Console.WriteLine(height[herN]);

            //結束
            Console.ReadLine();
        }
    }
}