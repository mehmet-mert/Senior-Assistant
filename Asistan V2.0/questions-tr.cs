using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Asistan_V2._0
{
    
    class questions_tr
    {
        public string user_link;
        
        public string Find_answer(string user_message)
        {
            //değişken.Substring(0, authors.IndexOf(","));
            //değişken.Substring(authors.IndexOf(",") + 1);
            var culture = new System.Globalization.CultureInfo("tr-TR");
            if (user_message == null) 
            {
                return "Yardım almak için `yardım` yazabilirsiniz!"; 
            }

            else if (user_message.Contains("!"))
            {
                user_link = user_message.Substring(user_message.IndexOf("!") + 1);
                user_message =  user_message.Substring(0, user_message.IndexOf("!"));

                if (user_message.Contains("viki") || user_message.Contains("wiki"))
                {
                    System.Diagnostics.Process.Start($"https://tr.wikipedia.org/w/index.php?search={user_link}&title=%C3%96zel%3AAra&go=Git");
                    return $"`{user_link}` konusu Vikipedi'da aranıyor...";
                }
                else if (user_message.Contains("you tube") || user_message.Contains("youtube"))
                {
                    Process.Start($"https://www.youtube.com/results?search_query={user_link}");
                    
                    return $"`{user_link}` konusu YouTube'da aranıyor...";
                }
                else if (user_message.Contains("google") || user_message.Contains("gogle"))
                {
                    System.Diagnostics.Process.Start($"https://www.google.com/search?q={user_link}");
                    return $"`{user_link}` konusu Google'da aranıyor...";
                }
                else if (user_message.Contains("spotify") || user_message.Contains("müzik") || user_message.Contains("şarkı"))
                {
                    System.Diagnostics.Process.Start($"https://open.spotify.com/search/{user_link}");
                    return $"`{user_link}` çalmak için Spotify'da aranıyor...";
                }
                else if (user_message.Contains("harita") || user_message.Contains("konum") || user_message.Contains("lokasyon"))
                {
                    Process.Start($"https://earth.google.com/web/search/{user_link}");
                    return $"{user_link} bulundu. Kemerlerinizi bağlayın!";
                }
                else if (user_message.Contains("kısaltma"))
                {
                    return "Bu komutta `!` kullanılamaz.";
                }
                else if (user_message.Contains("çevir") || user_message.Contains("tercüme"))
                {
                    try
                    {
                        string from = user_link.Substring(user_link.IndexOf(",") + 1).Substring(0, user_link.Substring(user_link.IndexOf(",") + 1).IndexOf("-"));
                        string to = user_link.Substring(user_link.IndexOf(",") + 1).Substring(user_link.Substring(user_link.IndexOf(",") + 1).IndexOf("-") + 1);
                        string text_to_translate = user_link.Substring(0, user_link.IndexOf(","));
                        System.Diagnostics.Process.Start($"https://translate.google.com/?sl={from}&tl={to}&text={text_to_translate}&op=translate");
                        return $"{text_to_translate} {from} dilinden {to} diline çeviriliyor...";
                    }
                    catch
                    {
                        return "Çeviriyi bu formatta kullanmalısınız:`çevir !çevirilecek yazı , birinci dil-ikinci dil`." +
                            " Dil kısaltmalarına bakmak için `kısaltmalar` komutunu kullanabilirsiniz.";
                    }
                }
                else if (user_message.Contains("nedir"))
                {
                    System.Diagnostics.Process.Start($"http://letmegooglethat.com/?q={user_link}");
                    return $"`{user_link}` konusu öğretiliyor...";
                }
                else if (user_message.Contains("rastgele") || user_message.Contains("rasgele"))
                {
                    
                    if (user_message.Contains("sayı"))
                    {
                        try
                        {
                            if (Convert.ToInt32(user_link.Substring(0, user_link.IndexOf(","))) > Convert.ToInt32(user_link.Substring(user_link.IndexOf(",") + 1)))
                            {
                                return "İlk sayı ikinciden büyük olamaz!";
                            }
                            else
                            {
                                Random random_sayi = new Random();
                                return Convert.ToString(random_sayi.Next(Convert.ToInt32(user_link.Substring(0, user_link.IndexOf(","))), Convert.ToInt32(user_link.Substring(user_link.IndexOf(",") + 1))));
                            }
                        }
                        catch
                        {
                            return "`rastgele sayı` komutunu böyle kullanmalısınız: `rastgele sayı !ilk sayı, ikinci sayı`";                        }
                    }
                    
                    return "Sorununuzu anlayamadım. Komutunuzda ünlem kullanmamayı deneyin.";
                }
                else
                {
                    return "Muhtemelen komutunuzu yanlış girdiniz." +
                        " Bunun sebepleri olmayan bir komut yazmanız veya" +
                        " gereksiz yere ünlem kullanmanızla alakalı olabilir." +
                        " Yardım almak için `yardım` yazabilirsiniz.";
                }
            }
            else if (user_message.Contains("yardım") || user_message.Contains("bilgi"))
            {
                if (user_message.Contains("internet"))
                {
                    return "İşte İnternet kategorisindeki bütün komutlarımız:" + Environment.NewLine + Environment.NewLine +
                        "•google : Google'da arar." + Environment.NewLine +
                        "•youtube : Youtube'da arar." + Environment.NewLine +
                        "•vikipedi : Vikipedi'de arar." + Environment.NewLine +
                        "•spotify : Spotify'da çalar." + Environment.NewLine +
                        "•harita : Google Earth'te yollar." + Environment.NewLine +
                        "•çevir : Google Translate'de çevirir." + Environment.NewLine +
                        "•nedir : ?????.";
                }
                else if (user_message.Contains("sohbet"))
                {
                    return "İşte sohbet kategorisindeki komutlar:" + Environment.NewLine +
                        "•selam : Sizi selamlar." + Environment.NewLine +
                        "•nasılsın : Senior'un halini hatrını sormanızı sağlar.";
                }
                else if (user_message.Contains("sistem"))
                {
                    return "İşte sistem kategorisindeki komutlar:" + Environment.NewLine +
                        "•saat : Saati söyler." + Environment.NewLine +
                        "•gün : Günü söyler." + Environment.NewLine +
                        "•tarih : Tarihi söyler ve biraz felsefe yapar." + Environment.NewLine +
                        "•hesap makinesi : Hesap makinesini açar.";
                }
                else if (user_message.Contains("rastgele"))
                {
                    return "İşte rastgele kategorisindeki komutlar:" + Environment.NewLine +
                        "•video : Sizin için bir rastgele video açar." + Environment.NewLine +
                        "•müzik : Sizin için rastgele bir şarkı açar." + Environment.NewLine +
                        "•konum : Sizi dünyanın herhangi bir noktasına ışınlar." + Environment.NewLine +
                        "•renk : Rastgele bir renk seçer.";
                }
                else
                {
                    return "Merhaba ben Senior Assistant. Size yardım etmek için burdayım. " +
                    Environment.NewLine +
                    "\tBir komut yazarak başlayın, örneğin `selam`. " +
                    "Komutları kolay kullanabilmeniz için komutları kategorilere ayırdık. " +
                    "Bunları yardım komutu ile beraber kullanabilirsiniz. Örneğin `yardım internet`. " +
                    "İşte komut kategorilerimiz:" + Environment.NewLine +
                    Environment.NewLine +
                    "Sohbet : selam • nasılsın ..." + Environment.NewLine +
                    "Sistem : saat • tarih • zaman • hesap makinesi ..." + Environment.NewLine +
                    "İnternet : nedir • google • youtube • vikipedi • spotify • harita • çevir ..." + Environment.NewLine +
                    "Rastgele : video • müzik • konum • renk...";
                }
            }
            else if (user_message.Contains("viki") || user_message.Contains("wiki"))
            {
                    return "Vikipedi'de arama yapmak için `vikipedi !aranacak sözcük` komutunu kullanabilirsiniz.";
            }
            else if (user_message.Contains("you tube") || user_message.Contains("youtube"))
            {
                return "YouTube'da arama yapmak için `youtube !aranacak sözcük` komutunu kullanabilirsiniz.";
            }
            else if (user_message.Contains("google") || user_message.Contains("gogle"))
            {
                    return "Google'da arama yapmak için `google !aranacak sözcük` komutunu kullanabilirsiniz.";
            }
            else if (user_message.Contains("rastgele"))
            {
                rastgele_komutu nesne2 = new rastgele_komutu();
                string media;
                if (user_message.Contains("video"))
                {
                    media = "video";
                    return nesne2.Rastgele_sec(media);
                }
                else if (user_message.Contains("müzik") || user_message.Contains("şarkı"))
                {
                    media = "müzik";
                    return nesne2.Rastgele_sec(media);
                }
                else if (user_message.Contains("konum") || user_message.Contains("yer"))
                {
                    media = "konum";
                    return nesne2.Rastgele_sec(media);
                }
                else if (user_message.Contains("renk"))
                {
                    media = "renk";
                    return nesne2.Rastgele_sec(media);
                }
                else
                {
                    return "s";
                }
            }
            else if (user_message.Contains("spotify") || user_message.Contains("müzik") || user_message.Contains("şarkı"))
            {
                return "Bir müzik açmak için `müzik !aranacak müzik` komutunu kullanın.";
            }
            
            
            
            else if (user_message.Contains("merhaba"))
            { return "Sanada merhaba!"; }
            else if (user_message.Contains("selam")) 
            { return "Sanada selam!"; }
            else if (user_message.Contains("nasılsın"))
            { return "İyidir."; }
            else if (user_message.Contains("çevir"))
            {
                return "Çeviriyi bu formatta kullanmalısınız:`çevir !çevirilecek yazı , birinci dil-ikinci dil`." +
                            " Dil kısaltmalarına bakmak için `kısaltmalar komutunu kullanabilirsiniz.`";
            }
            else if (user_message.Contains("kısaltma"))
            {
                return "İşte bazı dil kısaltmaları:" +
                    Environment.NewLine
                    + "Almanca - de" + Environment.NewLine
                    + "Arapça - ar" + Environment.NewLine
                    + "Fransızca -fr" + Environment.NewLine
                    + "İngilizce - en" + Environment.NewLine
                    + "Korece - ko" + Environment.NewLine
                    + "Rusça - ru" + Environment.NewLine
                    + "Türkçe - tr" + Environment.NewLine;
            }
            
            else if (user_message.Contains("hesap makin"))
            {
                Process.Start(@"calc.exe");
                return "Hesap makinesi başlatılıyor...";
            }           
            else if (user_message.Contains("gün"))
            {
                if (user_message.Contains("ay"))
                {
                    if (user_message.Contains("kaç")) { return "Bugün " + DateTime.Now.ToString("M"); }
                    else { return DateTime.Now.ToString("MMMM") + " ayındayız"; }
                }
                else { return "Bugün günlerden " + DateTime.Now.ToString("dddd"); }
            }
            else if (user_message.Contains("saat")) 
            { return "Saat şuan " + DateTime.Now.ToString("HH:mm"); }
            else if (user_message.Contains("tarih") || user_message.Contains("zaman") || user_message.Contains("vakit"))
            {
                return "Zaman veya vakit, ölçülmüş veya ölçülebilen bir dönem, uzaysal boyutu olmayan bir süreklilik... " +
                          "Aslında 'Zaman'ın varlığı bile bir tartışma konusu, " +
                          "Aristo'ya göre zaman hareket eseri ortaya çıkmıştır o halde zaman hareketin ürünüdür. Şu anda tarih " + DateTime.Now.ToString("D");
            }

            else if (user_message.Contains("hakkında"))
            {
                return "Bu program Mehmet Mert Altuntaş tarafından C# ile yazılmıştır. Ayrıntılı bilgi için `Hakkında` sekmesine göz atabilirsiniz.";
            }
            else if ((user_message.Contains("dil") || user_message.Contains("nasıl") || user_message.Contains("neyle")) && ((user_message.Contains("yaz") || user_message.Contains("yap"))))
            {
                return "Bu program Mehmet Mert Altuntaş tarafından C# ile yazılmıştır. Ayrıntılı bilgi için `Hakkında` sekmesine göz atabilirsiniz.";
            }
            else if (user_message.Contains("nedir"))
            {
                return "`nedir` komutunu kullanmak için `nedir !aranacak sözcük` komutunu kullanabilirsiniz.";
            }
            
            else { return "Probleminizi tam olarak anlayamadım. Muhtemelen komutunuzu yanlış girdiniz." +
                    " Ünlem işareti ile kullanmayı deneyin. Yardım almak için `yardım` yazabilirsiniz!"; }
        }
    }
}
