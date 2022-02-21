1- Form1 -> AnaSayfa olarak yeniden adlandirdik.
2- AnaSayfanin icine TabControl eklendi en uste konuslandirildi.
3- TabControlun TabPage1 -> Genel yazildi TabPage2->Yonetim yazildi
4- Splitter ekledik property den ayarlarini yaptik
5- Panel ekledik sola yasladik.
6- Splitter ekledik onuda panele yasladik.
7- Ortaya bir panel ekledik icine textbox,label,2 tane buton ekledik. Ayarlarini propertyden yaptiktan sonra sola yaslanan panele tasidik.
8- Soldaki panelin icine splitcontainer ekledik propertylerini yaptik panel1 içine treeView ekledik. Propertyden ayarini yaptik. Panel2 ye 2 tane button ekledik.
9- AnaSayfa property'sinde isMdiContainer ozelligini true yaptik.
10-Kod tarafina gecmek icin ana sayfa formuna cift tikladik.
11-Bilgi giris icin olusturulan butona cift tiklayarak kod tarafinda click event metodunu olusturduk.
12-lblMenu.txt nin icine butonun adini yazdirdik.
13-MenuOlustur() metodunu yazdik hata veren bu kodun uzerinde sag click yaptik ve bu metodun generate edilmesini sagladik.
14-MenuOlustur() metodunun icinde tvMenu icinde olusmasi gereken nodes lari yazdik.

-- 14.02.2022
1- Server Explorer'dan , data connections a sag tık atarak create a new database ile yeni veritabanı olusturduk.
2- Aynı sekmeden tables'a new table diyerek yeni tablo olusturudk ve asağıda create table kısmına [dbo].[tblHastaneler] yazarak özelleştirdik. Id değerini identity olarak atadık.
3- Gerekli değerleri ekleyip veri tiplerini belirledik.
4- HastaneTipleri adinda bir tablo olusturduk ve konfigürasyonunu yaptık.
5- foreign keys kısmına sağ tık yaparak yeni bir foreign key ekledik ve aşağıda konfigürasyonunu yaptık
6- Entity diye klasör oluşturup içine new database file oluşturup sqlden veritabanını seçerek oluşturduk.
7- Hastane giris sekmesine 5 tane buton ekleyip görsel olarak güzelleştirdik ve aşağı kısma split container attık ve gerekli ayarları yaptık.
8- Split container'ın içine data grid view tool'unu attık ve sağ tık edit columns diyerek ilgili ayarları yaptık.
9- server explorerdan tables a sağ tık atarak new query oluşturduk ve şehirler tablosu ile ilgili veriyi (internetten aldığım) yapıştırdım ve sehirler adında yeni bir tablo oluşturdum.
10-hastaneler tablosundaki sehir değişkenini şehirId olarak değiştirdim.
11 entity klasöründeki erpProModel kısmına gelerek sağ tık atarak Update modal from database i seçerek , add ve refresh işlemlerini gerçekleştirdik.


15.02.2022
1- datagrid view u liste olarak değiştirdim ve listeye diye fonksiyon tanımladım. datagridview ın doğru çalışması için en üste clear ekledim.
2- datagrid fonksiyonun içini doldurduk ve default methodlari yazdik.
3- datagrid view a yeni sutünlar ekleyip display cells olarak ayarladım.
4- global bir hstlist listesi oluşturup gelen datayı bu listenin içine attık.
