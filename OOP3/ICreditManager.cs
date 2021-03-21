using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface ICreditManager
    {
        void Calculate();
        void DoIt();
        
    }
}
//Bizim için referans tutsun diye aynı zamanda +
//tüm kredi tiplerinin uygulaması zorunlu halde olması istenen operasyonları tutsun diye oluşturulur. 
//içindeki operasyonlar alternatif sistemler için şablon ve referans tutucu görevi görür.
//Birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar içişn kullanılır.
//Kredi türlerinin hepsinde hesaplama vardır (ortak geri ödeme planı vardır) ama kodları farklıdır.