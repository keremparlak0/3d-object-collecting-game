## Oynanış:

- Karakterimiz bir küre. Küre bir platforma iniyor ve indiği yüzeye -rastgele konumlarda- kutucuklar iniyor. İki tür kutucuk iniyor; birisi puan toplamamıza yarayan sarı kutucuklar,
 diğeri ise toplamamızın yasak olduğu kırmızı kutucuklar. Sarı kutucuk bize +1 puan sağlarken, kırmızı kutucuklar 1 puan düşürüyor. Eğer puanımız 0'ın altına düşecek olursa oyun tekrardan
başlatılıyor.
- Platformumuz sonlu bir yüzeye sahip. Bu yüzden kürenin hareket alanı sınırlı ve eğer platformdan düşecek olursa oyun tekrar başlatılıyor.
- Oyunu durdurmak veya yeniden başlatmak istersek, 'esc' tuşuna basmamız yeterli. Bu bize içinde 'Devam Et' ve 'Yeniden Başlat' butonları bulunan bir duraklat menüsü açacak ve işlemlerimizi buradan gerçekleştirebiliriz.
Tekrar 'esc' tuşuna basarak devam edebiliriz.

## Tuşlar:

 > w: Küreyi ileri hareket ettirir.
 > s: Küreyi geri hareket ettirir.
 > a: Küreyi sola hareket ettirir.
 > d: Küreyi sağa hareket ettirir.

Oyun Linki: https://keremparlak0.itch.io/3d-object-collecting-game

## Kazandırdığım mekanikler:

- Oyuncuya odaklı kamera takibi,
- Oyuncunun nesnelere çarptınktan sonra nesnelerin kaybolması ve bu bilginin tutulması,
- Rastgele inen kutucukları bir sayaca atayarak sonucu ekranda gösterme,
- Pause Menu yapımı,
- Yasaklı kutuların eklenmesi ve sayacın, 0'ın altına düşmesi durumunda oyunun yeniden başlatılmasıdır.

## Script'ler içerisinde yazdığım kısımlar:

- MenuControl.cs ve cameraFollow.cs scriptleri kendim oluşturdum.
- oyuncu_script.cs içerisinde bulunan tüm çarpmaları kontrol eden, kaydeden ve ekrana yazdırılmasını sağlayan OnCollisionEnter ve diğer gerekli kısımları yazdım.
- kutucuk_script.cs içerisine de kontrol yapan OnCollisionEnter fonksiyonunu ve yasaklı kutuyu oluşturmak için gerekli kısımları ekledim.
