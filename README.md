# Asp.Net_Core_Portfolio
 A portfolio project prepared with asp.net core is made to learn asp.netcore and the project will be published! Management is provided from the admin panel, designs are on ready-made themes!


 Herkese merhaba, bugün sizlerle ASP.NET Core kullanarak geliştirdiğim bir projeyi paylaşmak istiyorum. Bu proje, hazır frontend sayfalarının backend tarafında işlenmesiyle ASP.NET Core’u öğrenmek amacıyla yapıldı.

Öncelikle proje, kişisel bir portfolyo sitesi olarak tasarlandı. Daha sonra bir admin paneli eklenerek dinamik hale getirildi, böylece içerikler panel üzerinden kolayca güncellenebiliyor. Kullanıcıların şifre değişim sürecini ASP.NET Core Identity üzerinden deneyimlemek için özel bir sayfa oluşturuldu. Şifreler hash yöntemiyle saklanarak güvenli bir şekilde güncellenebiliyor. Ayrıca kullanıcılar, profil resmi yükleme gibi çeşitli güncellemeleri de gerçekleştirebiliyor.
 
|Proje Detayları|

⚪ ASP.NET Core Identity ile kimlik doğrulama ve yetkilendirme yapıldı. ‘Admin’, ‘Moderatör’ ve ‘Kullanıcı’ olmak üzere farklı roller tanımlandı.
⚪ API entegrasyonu ile hava durumu verisi çekildi.
⚪ Fluent Validation kullanılarak belirli alanlarda veri doğrulama işlemleri yapıldı.
⚪ Özel hata sayfaları (Error Pages) oluşturuldu.
⚪ Katmanlı mimari (N-Tier Architecture) kullanılarak proje modüler hale getirildi.~Business Layer | Data Access Layer (DAL) | Entities Layer | Web UI Layer | API Layer~.
⚪ Bazı sayfalarda CRUD işlemleri sırasında Ajax kullanıldı.

 
⚫ Projeyi canlı olarak görmek için: http://emustafaulusoy.com 
(Yarın açılacak :),)

Murat Yücedağ hocamın ASP.NET Core projesinden yararlanarak yaptım kendisine teşekkür ediyorum. 

Aşağıda siteye ait görselleri bulabilirsiniz. 
Sırasıyla: |Kullanıcı--Moderatör--Admin--Login--Register |



![1](https://github.com/user-attachments/assets/74896eeb-8646-4f9b-89f2-0d3ad298f9a8)
![3](https://github.com/user-attachments/assets/d8441401-ddaf-4ca2-85e4-c51c048fcd3a)
![2](https://github.com/user-attachments/assets/f97bdcf9-6d51-4389-862a-abff16491eee)
