using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Asistan_V2._0
{
    class rastgele_komutu
    {
        public string Rastgele_sec(string media)
        {
            Random random_sayi = new Random();
            if (media == "video")
            {
                string[] videolar = {
            "YTC75cKzuNk","sXxbkjlHvf4","M8fdi6TwFHY",
            "dap5lEuS5uM","_S7WEVLbQ-Y","GMclY0qFM-A",
            "uNVhXiMPSSM","DN0gAQQ7FAQ","LfmRFW2gZn8",
            "69X7tP6p7E0","2nHE-EErdWs","jG4zCt4Nlis",
            "XukLEaMbm9k","G1IbRujko-A","7SJQfeJtGgI",
            "XIMLoLxmTDw","hPq54gxHAFU","-J2WggXWq70",
            "xvoXMaTdWM8","plrlrGtoiik","X3elVe9Mlh8",
            "b79ij4-DWSk","NuLBhTCmu0I","LJHZ15s0Tus",
            "7XkX3BVGSt8","DrR4SqfJ2uQ","i9dTnGKAJtQ",
            "J_VbCPHAz2M","ETbOX50t0kw","AXrHbrMrun0",
            "OhCQeFX9GSg","Wl959QnD3lM","a8j4b8Ec-KU",
            "A06HQbDxSpg","gnvt399wdjM","o_XaJdDqQA0",
            "FIxYCDbRGJc","PKna_fxEzGU","cIwRQwAS_YY",
            "gu3KzCWoons"};
                System.Diagnostics.Process.Start($"https://www.youtube.com/watch?v={videolar[random_sayi.Next(0, videolar.Length)]}");
                return "Videonu açıyorum!";           
            }
            else if (media == "müzik")
            {
                string[] musics = {
            "PfYnvDL0Qcw", "stdyhfeYxxI",
            "feA64wXhbjo","4NRXx6U8ABQ","-1dSY6ZuXEY",
            "LDU_Txk06tM","FTQbiNvZqaY","QH2-TGUlwu4",
            "SRcnnId15BA","LOZuxwVk7TU","Zi_XLOBDo_Y",
            "QZXc39hT8t4","_CL6n0FJZpk","Gc71AmT_b2k",
            "Ct6BUPvE2sM","ZaI2IlHwmgQ","68ugkg9RePc",
            "4Js-XbNj6Tk","yBLdQ1a4-JI","UcRtFYAz2Yo",
            "B5zOBty9JKM","dPI-mRFEIH0","jqE8M2ZnFL8",
            "hiP14ED28CA","9jK-NcRmVcw","btPJPFnesV4",
            "3JWTaaS7LdU","J---aiyznGQ","LACbVhgtx9I",
            "6Dh-RL__uN4","PHgc8Q6qTjc","dQw4w9WgXcQ",
            "6okxuiiHx2w","5NV6Rdv1a3I","ZbZSe6N_BXs",
            "GRWbIoIR04c","jofNR_WkoCE","8pm_KoguqPM",
            "DRS_PpOrUZ4","y6120QOlsfU","QiFBgtgUtfw",
            "0J2QdDbelmY","zrFI2gJSuwA","iuJDhFRDx9M",
            "Kq4OtRsdXls","sS76eS34Y0c","QK8mJJJvaes",
            "kYtGl1dX5qI","RbtPXFlZlHg","ild31s3afWw",
            "gj0Rz-uP4Mk","xqTBlft8gQA","Hy8kmNEo1i8",
            "Kq80fW90laE","d-diB65scQU","3KFvoDDs0XM",
            };
                System.Diagnostics.Process.Start($"https://www.youtube.com/watch?v={musics[random_sayi.Next(0, musics.Length)]}");
                return "Hoş bir melodisi var!";
            }
            else if (media == "konum")
            {
                string[] konumlar = {
            "32 08’59.96″ N, 110 50’09.03″W","27°22’50.10″N, 33°37’54.62″E",
            "32°40’34.19″N 117° 9’27.58″W","4°17’21.49″ S 31°23’46.46″ E",
            "33.747252, -112.633853","-33.836379, 151.080506",
            "50° 0’38.20″N 110° 6’48.32″W","33.927911, -118.38069",
            "-33.867886, -63.987","41.303921, -81.901693",
            "40.452107, 93.742118","37.563936, -116.85123",
            "-33.350534, -71.653268","43.645074, -115.993081",
            "51.848637, -0.55462","35.282902, 33.376891",
            "38°29’0.16″N 109°40’52.80″W","37.629562, -116.849556",
            "-18.529211, -70.249941","37.401573, -116.867808",
            "65.476721, -173.511416","19°56’56.96″S 69°38’1.83″W",
            "30.541634, 47.825445","32.663367, -111.487618",
            "37°39’16.06″S 68°10’16.42″W","33.921277, -118.391674",
            "-25.344375, 131.034401","38.265652, 105.9517",
            "16.864841, 11.953808","20°56’15.47″S, 164°39’30.56″E",
            "35.027185, -111.022388","35.141533, -90.052695",
            "6°53’53.00″ S 31°11’15.40″ E","7300 Airport Blvd, Houston, TX 77061, USA",
            "12°22’13.32″N, 23°19’20.18″E","44.525049, -110.83819"};
                System.Diagnostics.Process.Start($"https://earth.google.com/web/search/{konumlar[random_sayi.Next(0, konumlar.Length)]}");
                return "Kemerlerinizi bağlayın, gidiyoruz!";
            }

            else if (media == "renk")
            {
                Color randomColor = Color.FromArgb(random_sayi.Next(256), random_sayi.Next(256), random_sayi.Next(256));
                return Convert.ToString(randomColor);  
            }
            return "a";
        }
    }
}
