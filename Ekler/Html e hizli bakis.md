# HTML'e Hızlı Bakış

### Giriş Yazısı

Web dünyasının temel taşı olan HTML (HyperText Markup Language), internet üzerindeki hemen her içeriğin iskeletini oluşturur. 1991 yılında Tim Berners-Lee tarafından ortaya konulan HTML, günümüzde modern web geliştirme dünyasında hâlâ vazgeçilmezdir. Bu makalede, HTML'in ne olduğunu, neden bu kadar önemli olduğunu ve HTML ile ilgili temel kavramları ele alacağız. Hedefimiz, HTML'e yeni başlayanlar için bir rehber sunmak ve bu güçlü dilin temel yapı taşlarını açıklamak.

### Makale Konu Başlıkları

1. **HTML Nedir?**

   - HTML'in tanımı ve tarihçesi
   - HTML'in temel amacı ve işlevi

2. **HTML’in Temel Yapısı**

   - `<!DOCTYPE>` bildirimi
   - `<html>`, `<head>` ve `<body>` etiketlerinin anlamı

3. **HTML Etiketleri ve Kullanım Alanları**

   - Blok ve satır içi (block ve inline) etiketler
   - Semantik etiketler (örneğin `<article>`, `<section>`, `<header>`)

4. **HTML ile İçerik Oluşturma**

   - Metin düzenleme: `<p>`, `<h1>-<h6>`, `<strong>`, `<em>`
   - Listeler: `<ul>`, `<ol>`, `<li>`
   - Bağlantılar ve görseller: `<a>`, `<img>`

5. **HTML’de Formlar ve Giriş Elemanları**

   - `<form>` etiketi ve yaygın kullanılan form elemanları
   - Form doğrulama ve kullanıcı etkileşimi

6. **CSS ve JavaScript ile HTML'in Etkileşimi (Kısa Tanıtım)**

   - **CSS (Cascading Style Sheets):** HTML'e tasarım ve görsel düzenleme katmanı ekler. Örneğin, renkler, yazı tipleri, hizalamalar gibi görsellik odaklı düzenlemeler CSS ile yapılır. CSS'in detayları için "CSS'e Hızlı Bakış" makalemize göz atabilirsiniz.
   - **JavaScript:** HTML sayfalarına etkileşim ve dinamiklik kazandıran bir programlama dilidir. Örneğin, butona tıklandığında bir mesaj göstermek veya bir form verisini doğrulamak gibi işlemler JavaScript ile gerçekleştirilir. Daha fazlası için "JavaScript’e Hızlı Bakış" makalemizi inceleyebilirsiniz.

7. **Modern HTML ve Gelişim Süreci**

   - HTML5 ile gelen yenilikler
   - Gelecek trendler ve HTML’in evrimi

8. **HTML Öğrenirken Yapılan Yaygın Hatalar**
   - Kaçınılması gereken yanlışlar ve ipuçları

## 1. HTML Nedir?

**HTML (HyperText Markup Language)**, web sayfalarının yapısını oluşturan, metin tabanlı bir işaretleme dilidir. 1991 yılında Tim Berners-Lee tarafından geliştirilen HTML, web'in temel taşlarından biridir ve günümüzde hala tüm modern web sitelerinin temelini oluşturur. HTML sayesinde metin, görseller, videolar ve diğer içerikler bir web tarayıcısı tarafından doğru şekilde yorumlanarak kullanıcıya sunulur.

### HTML'in Temel Tanımı ve İşlevi

HTML, "HyperText" ve "Markup Language" terimlerinin birleşiminden oluşur:

- **HyperText:** Metinler arasında bağlantılar (linkler) oluşturmayı ifade eder. Örneğin, bir web sayfasındaki bir metne tıkladığınızda başka bir sayfaya gitmenizi sağlayan bağlantılar bu kavramın bir parçasıdır.
- **Markup Language:** İçeriği tarayıcıların anlayabileceği bir yapıya dönüştürmek için kullanılan etiketleme sistemini ifade eder. Bu etiketleme sistemi sayesinde metin, başlık, görsel gibi farklı türde içerikler organize edilir.

### HTML'in Amaçları

HTML'in geliştirilmesinin ardındaki temel amaçlar şunlardır:

1. **İçerik Organizasyonu:** Metin, resim, video gibi içeriklerin düzenli bir yapıya oturtulması ve kullanıcılara anlamlı bir şekilde sunulması.
2. **Evrensel Bir Standart Sunmak:** HTML, tüm web tarayıcıları tarafından desteklenen bir standarttır ve internet üzerinde iletişimi kolaylaştırır.
3. **Kolay Kullanılabilirlik:** HTML'in öğrenilmesi ve uygulanması görece kolaydır, bu da yeni başlayanlar için mükemmel bir başlangıç noktası sunar.

### HTML'in Gelişim Süreci

HTML, yıllar içinde birçok sürümden geçmiştir. Başlangıçta yalnızca basit bağlantılar ve metin düzenlemeleri için kullanılan HTML, günümüzde çok daha karmaşık ve işlevsel bir yapıya kavuşmuştur:

- **HTML 1.0 (1991):** En temel sürüm, yalnızca basit bir yapı sunuyordu.
- **HTML 4.01 (1999):** Daha gelişmiş özellikler ve semantik etiketler eklendi.
- **HTML5 (2014):** Multimedya desteği, semantik yapılar ve mobil uyumluluk gibi modern özelliklerle günümüzde en yaygın kullanılan sürümdür.

### HTML Nerelerde Kullanılır?

HTML, yalnızca basit web siteleri değil, aynı zamanda aşağıdaki gibi pek çok alanda kullanılır:

- **Bloglar ve Kişisel Web Siteleri:** İçerik oluşturmak ve düzenlemek.
- **Kurumsal Web Siteleri:** Şirket bilgilerini ve ürünlerini tanıtmak.
- **Web Uygulamaları:** Dinamik içerikler için temel yapı sağlamak (JavaScript ve CSS ile birlikte).

### HTML Kullanmanın Avantajları

- **Platform Bağımsızdır:** Tüm cihazlarda ve tarayıcılarda çalışır.
- **Kolay Öğrenilir:** Basit bir sözdizimi vardır.
- **Standarttır:** W3C tarafından düzenli olarak güncellenir ve desteklenir.

## 2. HTML’in Temel Yapısı

Bir HTML belgesi, web tarayıcılarının okuyabileceği ve yorumlayabileceği belirli bir yapı formatına sahiptir. Bu yapı, HTML kodlarının düzenli bir şekilde organize edilmesini sağlar ve tarayıcılara içeriğin nasıl görüntülenmesi gerektiğini bildirir. Bu bölümde, bir HTML belgesinin temel bileşenlerini ve bunların işlevlerini detaylıca inceleyeceğiz.

### 2.1. `<!DOCTYPE>` Bildirimi

HTML belgesinin en üst kısmında yer alır ve kullanılan HTML sürümünü tarayıcıya bildirir.

- Modern HTML belgelerinde şu şekilde kullanılır: `<!DOCTYPE html>`.
- Bu bildirim, tarayıcıların belgede uyumluluk (standards mode) modunda çalışmasını sağlar. HTML5’te basitleştirilmiş ve kolay anlaşılır bir hale getirilmiştir.

### 2.2. `<html>` Etiketi

`<html>` etiketi, bir HTML belgesinin kök etiketidir ve tüm diğer içerikleri kapsar.

- Açılış etiketi: `<html>`.
- Kapanış etiketi: `</html>`.
- Bu etiketin içinde iki ana bölüm bulunur: `<head>` ve `<body>`.

### 2.3. `<head>` Etiketi

`<head>` bölümü, belge hakkında meta bilgiler (metadata) içerir. Kullanıcı tarafından doğrudan görülmez ama tarayıcı için önemlidir. İçeriği şunları kapsar:

1. **Başlık (Title):** Sayfa başlığını belirler ve tarayıcı sekmesinde görünür. Örnek:
   ```html
   <title>Web Sitem</title>
   ```
2. **Meta Bilgileri:** Sayfa hakkında ek bilgiler içerir, örneğin karakter kodlaması:
   ```html
   <meta charset="UTF-8" />
   ```
3. **CSS ve JavaScript Bağlantıları:**
   - Harici CSS dosyalarını bağlamak için `<link>` etiketi:
     ```html
     <link rel="stylesheet" href="styles.css" />
     ```
   - Harici JavaScript dosyalarını bağlamak için `<script>` etiketi:
     ```html
     <script src="script.js"></script>
     ```

### 2.4. `<body>` Etiketi

`<body>` bölümü, kullanıcı tarafından doğrudan görülebilecek tüm içerikleri barındırır. Örnekler:

- **Metinler:** Paragraflar ve başlıklar.
- **Görseller:** Resimler ve multimedya içerikleri.
- **Bağlantılar:** Diğer sayfalara yönlendiren linkler.
- **Formlar:** Kullanıcı giriş alanları.

Temel bir `<body>` içeriği şu şekilde olabilir:

```html
<body>
  <h1>Merhaba Dünya!</h1>
  <p>Bu, bir paragraftır.</p>
  <img src="resim.jpg" alt="Bir resim" />
</body>
```

### 2.5. Temel HTML Yapısının Örnek Kodu

Örnek HTML belgesi:

```html
<!DOCTYPE html>
<html lang="tr">
  <head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>HTML Temel Yapısı</title>
    <link rel="stylesheet" href="styles.css" />
  </head>
  <body>
    <h1>Hoş Geldiniz</h1>
    <p>Bu, HTML’in temel yapısını gösteren bir örnektir.</p>
    <a href="https://www.google.com" target="_blank">Google’a Git</a>
    <img src="example.jpg" alt="Örnek Resim" />
  </body>
</html>
```

#### Satır Satır Açıklama

1. **`<!DOCTYPE html>`**

   - Bu satır, HTML belgesinin bir HTML5 belgesi olduğunu tarayıcıya bildirir.
   - Eski tarayıcılarda bile uyumluluğu artırır.

2. **`<html lang="tr">`**

   - Tüm HTML belgesinin kök etiketi.
   - `lang="tr"` özelliği, belgenin Türkçe içerik sunduğunu belirtir. Bu, tarayıcıların ve arama motorlarının dili doğru anlamasına yardımcı olur.

3. **`<head>`**

   - HTML belgesine ait meta bilgileri içerir. Bu bilgiler tarayıcıda görünmez ama işlevsellik açısından önemlidir.

4. **`<meta charset="UTF-8">`**

   - Sayfada kullanılan karakter setini belirtir. `UTF-8`, Unicode karakterleri desteklediği için en yaygın kullanılan kodlamadır.
   - Türkçe karakterlerin (ç, ş, ü, ğ, ı gibi) doğru görüntülenmesini sağlar.

5. **`<meta name="viewport" content="width=device-width, initial-scale=1.0">`**

   - Sayfanın mobil cihazlarda nasıl görüntüleneceğini düzenler.
   - `width=device-width`, sayfa genişliğini cihazın ekran genişliğine göre ayarlar.
   - `initial-scale=1.0`, başlangıçtaki yakınlaştırma seviyesini belirler.

6. **`<title>HTML Temel Yapısı</title>`**

   - Sayfanın başlığını tanımlar. Bu başlık tarayıcı sekmesinde görüntülenir.

7. **`<link rel="stylesheet" href="styles.css">`**

   - Harici bir CSS dosyasını sayfaya bağlar.
   - `rel="stylesheet"`, dosyanın bir stil dosyası olduğunu belirtir.
   - `href="styles.css"`, kullanılacak CSS dosyasının adını ve yolunu gösterir.

8. **`<body>`**

   - Kullanıcı tarafından görüntülenebilen tüm içerikler bu etiketin içine yazılır.

9. **`<h1>Hoş Geldiniz</h1>`**

   - Birinci düzey başlık etiketi. En önemli başlıklar için kullanılır.
   - Büyük ve belirgin bir yazı tipi ile gösterilir.

10. **`<p>Bu, HTML’in temel yapısını gösteren bir örnektir.</p>`**

    - Paragraf etiketi. Uzun metinleri düzenlemek için kullanılır.

11. **`<a href="https://www.google.com" target="_blank">Google’a Git</a>`**

    - **`<a>` (Anchor) etiketi:** Bağlantı oluşturur.
    - `href="https://www.google.com"` bağlantının hedefini belirtir. Bu durumda, Google web sitesine yönlendirme yapar.
    - `target="_blank"`, bağlantının yeni bir sekmede açılmasını sağlar.
    - "Google’a Git" kısmı, bağlantının görünen metnidir.

12. **`<img src="example.jpg" alt="Örnek Resim">`**

    - **`<img>` etiketi:** Bir resim ekler.
    - `src="example.jpg"`, kullanılacak resmin adını ve yolunu belirtir.
    - `alt="Örnek Resim"`, resim yüklenemediğinde gösterilecek alternatif metni tanımlar. Bu, erişilebilirlik açısından önemlidir.

13. **`</body>` ve `</html>`**
    - `<body>` ve `<html>` etiketlerini kapatarak belgeyi tamamlar.

### 2.6. Temel Yapının Önemi

HTML, internetin gelişiminde çığır açan bir teknoloji olarak kabul edilir. Sadece bir işaretleme dili olmaktan öte, dijital çağın temellerini atan, bilgiye erişimi demokratikleştiren ve teknolojinin evrimini hızlandıran bir araçtır. İşte HTML’in temel yapısının önemi ve tarihsel etkisi:

#### 2.6.1. Bilgiye Erişimi Kolaylaştırması

HTML, metin, görsel, video ve diğer içerik türlerini standart bir yapıda sunarak bilgiye erişimi kolaylaştırmıştır.

- **Hiperlink kavramı**, HTML ile birlikte yaygınlaşmış ve farklı kaynaklar arasında hızlı geçişi mümkün kılmıştır.
- Tarayıcılar tarafından okunabilir basit yapısı sayesinde, herkesin içerik üretmesine olanak tanımıştır.

#### 2.6.2. Web'in Evrimini Başlatması

1990'ların başında HTML'in ortaya çıkışı, World Wide Web’in (WWW) doğuşuyla eş zamanlıdır.

- HTML, web sayfalarının yapılandırılmasını ve internet üzerinden paylaşılmasını mümkün kılmıştır.
- İlk web tarayıcılarının HTML’i temel alması, bu teknolojinin küresel çapta benimsenmesini sağlamıştır.

#### 2.6.3. XML ve Diğer ML Dillerine İlham Vermesi

HTML’in başarısı, başka işaretleme dillerinin geliştirilmesine zemin hazırlamıştır:

- **XML (eXtensible Markup Language):** Veriyi standart bir formatta depolamak ve taşımak için geliştirilmiştir. HTML'in semantik yapısından ilham almıştır.
- **SVG (Scalable Vector Graphics):** Grafik ve görsel verilerin işaretlenmesi için kullanılan bir XML tabanlı dil.
- **MathML ve diğer özel diller:** Matematiksel ifadelerin, bilimsel verilerin ve diğer karmaşık yapıların tanımlanmasında HTML’in işaretleme yaklaşımını kullanır.

#### 2.6.4. Standartların ve Uyumluluğun Öncüsü

HTML, farklı cihaz ve platformlarda aynı şekilde çalışması amacıyla geliştirilmiş ilk standartlardan biridir:

- W3C (World Wide Web Consortium) tarafından sürekli güncellenen HTML standartları, tarayıcıların uyumlu bir şekilde çalışmasını sağlar.
- Bu standartlar, günümüzün mobil uyumlu ve erişilebilir web tasarımlarının temelini oluşturur.

#### 2.6.5. Teknolojik Gelişimlere Yön Vermesi

HTML, sadece bir başlangıç noktası değil, aynı zamanda teknolojik gelişimlerin odak noktası olmuştur:

- **HTML5**, modern web teknolojilerinin çoğunu kapsayan multimedya desteği, semantik etiketler ve mobil uyumluluk gibi yenilikler sunmuştur.
- HTML ile başlayan bu süreç, CSS ve JavaScript’in gelişimiyle birlikte daha dinamik, estetik ve etkileşimli bir internet ortamı yaratmıştır.

#### 2.6.6. Toplumsal Etkisi

HTML'in kolay öğrenilebilir yapısı, kodlama ve web geliştirme dünyasına giriş yapmak isteyen milyonlarca kişiye kapı açmıştır:

- **Demokratikleşme:** Herkesin kendi web sayfasını oluşturabileceği bir platform sunmuştur.
- **Eğitim:** HTML, birçok programlama dili için bir başlangıç noktası olmuş ve eğitim süreçlerinde temel araçlardan biri haline gelmiştir.

#### 2.6.7. Gelecekteki Rolü

HTML, modern teknolojilere ilham vermeye devam ediyor:

- **Semantik Web:** HTML’in semantik yapısı, daha akıllı ve daha bağlantılı bir internet için bir temel sunuyor.
- **Yapay Zeka ve Veri Analitiği:** HTML tabanlı içerik, büyük veri ve yapay zeka için veri kaynağı olarak kullanılabiliyor.

HTML’in temel yapısının önemini anlamak, sadece bu dilin geçmişteki başarısını görmek değil, aynı zamanda onun gelecekteki potansiyelini de kavramaktır. Bu yapıyla başlayan yolculuk, web teknolojilerinin sürekli evrimini şekillendiren bir hikayedir.

## 3. HTML Etiketleri ve Kullanım Alanları

HTML etiketleri, bir web sayfasındaki içeriği yapılandırmak ve anlamlandırmak için kullanılan temel yapı taşlarıdır. Her bir etiket, belirli bir işlevi yerine getirmek için tasarlanmıştır ve bir web sayfasındaki metin, görsel, video gibi içeriklerin doğru şekilde organize edilmesini sağlar. Bu bölümde, HTML etiketlerini ve kullanım alanlarını detaylı olarak ele alacağız.

### 3.1. Etiketlerin Genel Yapısı

HTML etiketleri, açılış ve kapanış şeklinde iki temel parçadan oluşur:

- **Açılış etiketi:** `<etiketAdı>`
- **Kapanış etiketi:** `</etiketAdı>`
- Örnek: `<p>Bu bir paragraf etiketi.</p>`

Bazı etiketler ise kendiliğinden kapanır. Örneğin:

```html
<img src="resim.jpg" alt="Resim açıklaması" />
```

### 3.2. Etiket Türleri

HTML etiketleri, işlevlerine göre birkaç farklı kategoriye ayrılabilir:

1. **Yapılandırma Etiketleri**

   - Bu etiketler, bir HTML belgesinin genel yapısını oluşturur.
   - Örnekler:
     - `<html>`: Tüm HTML belgesini kapsar.
     - `<head>`: Meta bilgiler içerir.
     - `<body>`: Görülebilir içeriği barındırır.

2. **Metin Formatlama Etiketleri**

   - Metinleri düzenlemek ve vurgulamak için kullanılır.
   - Örnekler:
     - `<p>`: Paragraf oluşturur.
     - `<h1>`–`<h6>`: Başlık etiketleri.
     - `<strong>`: Kalın metin (vurgulu anlamda).
     - `<em>`: İtalik metin (vurgulu anlamda).

3. **Görsel ve Medya Etiketleri**

   - Web sayfasına görsel ve medya içeriği eklemek için kullanılır.
   - Örnekler:
     - `<img>`: Resim ekler.
     - `<video>`: Video oynatıcı oluşturur.
     - `<audio>`: Ses oynatıcı ekler.

4. **Bağlantı ve Navigasyon Etiketleri**

   - Sayfalar arası veya sayfa içi bağlantılar oluşturur.
   - Örnekler:
     - `<a>`: Hiperlink oluşturur.
     - `<nav>`: Navigasyon menüleri için kullanılır.

5. **Listeleme Etiketleri**

   - Liste yapıları oluşturur.
   - Örnekler:
     - `<ul>`: Sırasız liste.
     - `<ol>`: Sıralı liste.
     - `<li>`: Liste öğesi.

6. **Form ve Giriş Etiketleri**

   - Kullanıcıdan veri almak için formlar oluşturur.
   - Örnekler:
     - `<form>`: Form başlatır.
     - `<input>`: Giriş alanı oluşturur.
     - `<button>`: Buton ekler.

7. **Semantik Etiketler**
   - İçeriğin amacını tanımlayarak daha anlamlı bir yapı sağlar.
   - Örnekler:
     - `<article>`: Makale veya yazı için kullanılır.
     - `<section>`: Sayfanın bölümlerini tanımlar.
     - `<header>`: Başlık bölgesi.
     - `<footer>`: Alt bilgi bölgesi.

### 3.3. Blok ve Satır İçi (Inline) Etiketler

1. **Blok Etiketler**

   - Sayfada kendi satırını kaplar ve genişliğini varsayılan olarak %100 alır.
   - Örnekler: `<div>`, `<p>`, `<h1>`, `<section>`.

2. **Satır İçi (Inline) Etiketler**
   - Bulundukları satırın içinde yer alır ve sadece kendi içerikleri kadar yer kaplar.
   - Örnekler: `<span>`, `<a>`, `<strong>`, `<em>`.

### 3.4. Örnek Kullanım

Aşağıda, farklı HTML etiketlerini içeren bir örnek verilmiştir:

```html
<!DOCTYPE html>
<html lang="tr">
  <head>
    <meta charset="UTF-8" />
    <title>HTML Etiketleri</title>
  </head>
  <body>
    <header>
      <h1>Web Siteme Hoş Geldiniz</h1>
      <nav>
        <a href="#about">Hakkımda</a> |
        <a href="#contact">İletişim</a>
      </nav>
    </header>
    <section id="about">
      <h2>Hakkımda</h2>
      <p>
        Ben bir yazılım geliştiricisiyim ve web teknolojileri üzerine
        çalışıyorum.
      </p>
      <img src="profile.jpg" alt="Profil Resmi" />
    </section>
    <footer>
      <p>&copy; 2024 Tüm Hakları Saklıdır.</p>
    </footer>
  </body>
</html>
```

### 3.5. HTML Etiketlerinin Önemi

- **Kullanıcı Deneyimi:** Etiketler, içeriklerin düzenli ve anlamlı bir şekilde sunulmasını sağlar.
- **Erişilebilirlik:** Etiketlerin doğru kullanımı, ekran okuyucular gibi yardımcı teknolojilerin içeriği daha iyi yorumlamasına olanak tanır.
- **SEO:** Arama motorları, semantik etiketleri doğru şekilde kullanarak içerikleri daha iyi analiz eder.

## 4. HTML ile İçerik Oluşturma

HTML, bir web sayfasında görünen her türlü içeriğin oluşturulmasını ve düzenlenmesini sağlayan temel bir dil olarak, kullanıcıya içerik sunumunda kritik bir rol oynar. Metin, görseller, bağlantılar ve listeler gibi farklı içerik türleri, HTML’in sunduğu etiketlerle yapılandırılır. Bu bölümde, HTML ile içerik oluşturmanın en yaygın yöntemlerini detaylı bir şekilde ele alacağız.

### 4.1. Metin İçerikleri

HTML, metinlerin düzenlenmesi ve yapılandırılması için bir dizi etiket sunar:

1. **Başlık Etiketleri (`<h1>`–`<h6>`):**

   - Başlıklar oluşturmak için kullanılır.
   - `<h1>` en büyük ve en önemli başlık; `<h6>` ise en küçük ve en az önemli başlıktır.
   - Örnek:
     ```html
     <h1>Bu bir Başlık</h1>
     <h2>Bu bir Alt Başlık</h2>
     ```

2. **Paragraf Etiketi (`<p>`):**

   - Paragraflar oluşturur.
   - Örnek:
     ```html
     <p>Bu bir paragraf örneğidir.</p>
     ```

3. **Vurgulama ve Stil Etiketleri:**
   - `<strong>`: Metni kalın yapar ve vurgular.
     ```html
     <strong>Bu önemli bir metindir.</strong>
     ```
   - `<em>`: Metni italik yapar ve vurgular.
     ```html
     <em>Bu vurgulanmış bir metindir.</em>
     ```
   - `<span>`: Satır içindeki metinlere özel stil eklemek için kullanılır.
     ```html
     <span style="color: red;">Bu kırmızı bir metindir.</span>
     ```

### 4.2. Görseller Ekleme

Web sayfalarına görseller eklemek için `<img>` etiketi kullanılır:

- **`src` (source):** Görselin dosya yolunu belirtir.
- **`alt` (alternative text):** Görsel yüklenemediğinde gösterilen alternatif metni tanımlar.

Örnek:

```html
<img src="ornek.jpg" alt="Örnek bir resim" />
```

### 4.3. Bağlantılar Oluşturma

Bağlantılar (linkler), farklı web sayfalarına veya aynı sayfa içindeki bölümlere yönlendirme yapmak için kullanılır:

- **Temel Link:**
  ```html
  <a href="https://www.example.com">Ziyaret Et</a>
  ```
- **Yeni Sekmede Açılan Link:**
  ```html
  <a href="https://www.example.com" target="_blank">Yeni Sekmede Aç</a>
  ```
- **Sayfa İçi Link:**
  ```html
  <a href="#section1">Bu bölüme git</a>
  ```

### 4.4. Listeleme Yapıları

HTML, sıralı ve sırasız listeler için etiketler sunar:

1. **Sırasız Liste (`<ul>`):**

   - Madde işaretleriyle (bullet points) gösterilir.
   - Örnek:
     ```html
     <ul>
       <li>Madde 1</li>
       <li>Madde 2</li>
     </ul>
     ```

2. **Sıralı Liste (`<ol>`):**

   - Sayılarla sıralanır.
   - Örnek:
     ```html
     <ol>
       <li>Birinci Madde</li>
       <li>İkinci Madde</li>
     </ol>
     ```

3. **Tanım Listesi (`<dl>`, `<dt>`, `<dd>`):**
   - Tanımlar ve açıklamalar için kullanılır.
   - Örnek:
     ```html
     <dl>
       <dt>HTML</dt>
       <dd>Web sayfalarının yapısını oluşturmak için kullanılan dil.</dd>
       <dt>CSS</dt>
       <dd>Web sayfalarını görsel olarak düzenlemek için kullanılan dil.</dd>
     </dl>
     ```

### 4.5. Tablo Yapıları

HTML, verileri tablo formatında sunmak için esnek bir yapı sağlar:

- **`<table>`:** Tabloyu başlatır.
- **`<tr>` (Table Row):** Satırları belirtir.
- **`<td>` (Table Data):** Verileri belirtir.
- **`<th>` (Table Header):** Başlık hücrelerini belirtir.

Örnek:

```html
<table border="1">
  <tr>
    <th>Ad</th>
    <th>Yaş</th>
  </tr>
  <tr>
    <td>Ahmet</td>
    <td>25</td>
  </tr>
  <tr>
    <td>Ayşe</td>
    <td>30</td>
  </tr>
</table>
```

### 4.6. Multimedya İçerikler

1. **Video Ekleme:**

   - `<video>` etiketiyle video eklenir:
     ```html
     <video controls>
       <source src="video.mp4" type="video/mp4" />
       Tarayıcınız bu videoyu desteklemiyor.
     </video>
     ```

2. **Ses Ekleme:**
   - `<audio>` etiketiyle ses dosyası eklenir:
     ```html
     <audio controls>
       <source src="ses.mp3" type="audio/mpeg" />
       Tarayıcınız bu ses dosyasını desteklemiyor.
     </audio>
     ```

### 4.7. Örnek İçerik

Aşağıda, HTML ile oluşturulmuş farklı içerik türlerini bir arada gösteren bir örnek verilmiştir:

```html
<!DOCTYPE html>
<html lang="tr">
  <head>
    <meta charset="UTF-8" />
    <title>HTML ile İçerik Oluşturma</title>
  </head>
  <body>
    <h1>İçerik Örnekleri</h1>
    <p>
      <strong>HTML</strong> ile metin, görsel ve bağlantılar oluşturabilirsiniz.
    </p>
    <img src="ornek.jpg" alt="Bir örnek resim" />
    <ul>
      <li>HTML</li>
      <li>CSS</li>
      <li>JavaScript</li>
    </ul>
    <a href="https://www.example.com" target="_blank">Daha fazla bilgi</a>
  </body>
</html>
```

### 4.8. İçerik Oluşturmanın Önemi

- **Kullanıcı Deneyimi:** Anlamlı ve düzenli içerikler, kullanıcıların web sitesinde gezinmesini kolaylaştırır.
- **SEO:** Doğru yapılandırılmış içerikler, arama motorlarının web sitenizi daha iyi analiz etmesine olanak tanır.
- **Erişilebilirlik:** Alternatif metinler (alt) gibi içerikler, engelli kullanıcıların deneyimini geliştirir.

## 5. HTML’de Formlar ve Giriş Elemanları

HTML formları, kullanıcıdan veri toplamak ve bu verileri bir sunucuya iletmek için kullanılan güçlü araçlardır. Formlar, kullanıcıyla etkileşim kurmanın en temel yollarından biridir ve HTML’de çok çeşitli giriş elemanlarıyla desteklenir. Bu bölümde, HTML formlarını ve giriş elemanlarını detaylı bir şekilde ele alacağız.

### 5.1. Formun Temel Yapısı

HTML formları `<form>` etiketiyle başlar ve genellikle aşağıdaki özniteliklerle yapılandırılır:

1. **`action`:** Formun gönderileceği URL’yi belirtir.
2. **`method`:** Verinin nasıl gönderileceğini belirler (GET veya POST).
3. **`enctype`:** Verinin hangi formatta gönderileceğini belirtir (genelde dosya yükleme işlemleri için kullanılır).

Örnek:

```html
<form action="/gonder" method="POST">
  <!-- Form içeriği -->
</form>
```

### 5.2. Giriş Elemanları

HTML, kullanıcıdan bilgi toplamak için farklı türde giriş elemanları sağlar:

1. **Metin Girişi (`<input type="text">`):**

   - Kullanıcıdan kısa metinler almak için kullanılır.
   - Örnek:
     ```html
     <label for="isim">Adınız:</label>
     <input type="text" id="isim" name="isim" placeholder="Adınızı girin" />
     ```

2. **Parola Girişi (`<input type="password">`):**

   - Girilen karakterleri gizler.
   - Örnek:
     ```html
     <label for="sifre">Şifre:</label>
     <input type="password" id="sifre" name="sifre" />
     ```

3. **E-posta Girişi (`<input type="email">`):**

   - E-posta adresi için özel doğrulama sunar.
   - Örnek:
     ```html
     <label for="email">E-posta:</label>
     <input type="email" id="email" name="email" />
     ```

4. **Numara Girişi (`<input type="number">`):**

   - Sayısal veri almak için kullanılır.
   - Örnek:
     ```html
     <label for="yas">Yaş:</label>
     <input type="number" id="yas" name="yas" min="1" max="100" />
     ```

5. **Tarih Girişi (`<input type="date">`):**

   - Tarih seçmek için özel bir giriş sağlar.
   - Örnek:
     ```html
     <label for="tarih">Tarih:</label>
     <input type="date" id="tarih" name="tarih" />
     ```

6. **Radyo Butonları (`<input type="radio">`):**

   - Bir grup seçenekten yalnızca birinin seçilmesini sağlar.
   - Örnek:
     ```html
     <p>Cinsiyet:</p>
     <input type="radio" id="erkek" name="cinsiyet" value="erkek" />
     <label for="erkek">Erkek</label>
     <input type="radio" id="kadin" name="cinsiyet" value="kadin" />
     <label for="kadin">Kadın</label>
     ```

7. **Onay Kutuları (`<input type="checkbox">`):**

   - Birden fazla seçeneği işaretlemek için kullanılır.
   - Örnek:
     ```html
     <p>Hobiler:</p>
     <input type="checkbox" id="yuzme" name="hobi" value="yuzme" />
     <label for="yuzme">Yüzme</label>
     <input type="checkbox" id="muzik" name="hobi" value="muzik" />
     <label for="muzik">Müzik</label>
     ```

8. **Açılır Menü (`<select>`):**

   - Kullanıcıya birden fazla seçenek arasından seçim yapma imkanı tanır.
   - Örnek:
     ```html
     <label for="sehir">Şehir:</label>
     <select id="sehir" name="sehir">
       <option value="istanbul">İstanbul</option>
       <option value="ankara">Ankara</option>
       <option value="izmir">İzmir</option>
     </select>
     ```

9. **Dosya Yükleme (`<input type="file">`):**

   - Kullanıcının dosya yüklemesine olanak tanır.
   - Örnek:
     ```html
     <label for="dosya">Dosya Yükleyin:</label>
     <input type="file" id="dosya" name="dosya" />
     ```

10. **Butonlar:**
    - Formu göndermek veya kullanıcı etkileşimi sağlamak için kullanılır.
    - Örnek:
      ```html
      <button type="submit">Gönder</button>
      <button type="reset">Temizle</button>
      ```

### 5.3. Örnek Form

Aşağıda, yukarıda bahsedilen giriş elemanlarını bir araya getiren örnek bir form verilmiştir:

```html
<form action="/gonder" method="POST">
  <h2>Kayıt Formu</h2>
  <label for="isim">Adınız:</label>
  <input
    type="text"
    id="isim"
    name="isim"
    placeholder="Adınızı girin"
  /><br /><br />

  <label for="email">E-posta:</label>
  <input
    type="email"
    id="email"
    name="email"
    placeholder="E-posta adresinizi girin"
  /><br /><br />

  <label for="sifre">Şifre:</label>
  <input type="password" id="sifre" name="sifre" /><br /><br />

  <label for="sehir">Şehir:</label>
  <select id="sehir" name="sehir">
    <option value="istanbul">İstanbul</option>
    <option value="ankara">Ankara</option>
    <option value="izmir">İzmir</option></select
  ><br /><br />

  <label for="tarih">Doğum Tarihi:</label>
  <input type="date" id="tarih" name="tarih" /><br /><br />

  <button type="submit">Gönder</button>
</form>
```

### 5.4. HTML Formlarının Önemi

- **Veri Toplama:** Kullanıcılardan veri almak için etkili bir yöntemdir.
- **Erişilebilirlik:** Formlar, doğru yapılandırıldığında ekran okuyucular ve diğer erişilebilirlik araçlarıyla uyumlu çalışır.
- **Web Uygulamaları:** Formlar, birçok modern web uygulamasının temelini oluşturur ve sunucu ile etkileşimi mümkün kılar.

## 6. CSS ve JavaScript ile HTML'in Etkileşimi (Kısa Tanıtım)

HTML, web sayfalarının içeriğini yapılandırmak için kullanılırken, CSS ve JavaScript, bu içeriğin nasıl görüneceğini ve nasıl davranacağını kontrol eden tamamlayıcı teknolojilerdir. HTML, CSS ve JavaScript'in bir arada kullanımı, kullanıcıya hem görsel hem de işlevsel açıdan zengin bir deneyim sunar. Bu bölümde, CSS ve JavaScript'in HTML ile nasıl etkileşime geçtiğini kısaca ele alacağız.

### 6.1. CSS (Cascading Style Sheets) ile HTML’in Görselleştirilmesi

CSS, HTML içeriğinin stilini ve düzenini kontrol eden bir dildir. Renkler, yazı tipleri, boyutlar ve konumlandırma gibi görsel özellikler CSS ile düzenlenir.

1. **HTML ile CSS’in Entegrasyonu**

   - CSS, üç farklı şekilde HTML’e entegre edilebilir:
     1. **Inline CSS:** HTML etiketi içinde `style` özniteliği kullanılarak uygulanır.
        ```html
        <p style="color: red;">Bu kırmızı bir metindir.</p>
        ```
     2. **Internal CSS:** `<style>` etiketi ile `<head>` bölümünde tanımlanır.
        ```html
        <head>
          <style>
            p {
              color: blue;
            }
          </style>
        </head>
        ```
     3. **External CSS:** Harici bir dosya bağlanır.
        ```html
        <link rel="stylesheet" href="styles.css" />
        ```

2. **CSS’in Sağladığı Faydalar**

   - **Görsel Tutarlılık:** Tüm web sayfasının görünümünü merkezi bir şekilde kontrol eder.
   - **Bakım Kolaylığı:** Harici CSS dosyaları kullanılarak tasarım değişiklikleri hızlıca yapılabilir.
   - **Modern Tasarım:** Responsive ve mobil uyumlu tasarımlar için CSS önemli bir rol oynar.

3. **Örnek CSS Kodu**
   ```css
   body {
     font-family: Arial, sans-serif;
     margin: 20px;
   }
   h1 {
     color: #4caf50;
   }
   p {
     line-height: 1.6;
   }
   ```

### 6.2. JavaScript ile HTML’in Dinamikleştirilmesi

JavaScript, HTML içeriğine etkileşim ve dinamiklik katan bir programlama dilidir. Kullanıcı hareketlerine yanıt veren, veri işleyen veya sayfayı dinamik olarak değiştiren işlevsellikler sağlar.

1. **HTML ile JavaScript’in Entegrasyonu**

   - JavaScript, üç farklı şekilde HTML’e entegre edilebilir:
     1. **Inline JavaScript:** HTML etiketi içinde `onclick`, `onmouseover` gibi olaylarla kullanılır.
        ```html
        <button onclick="alert('Merhaba Dünya!')">Tıklayın</button>
        ```
     2. **Internal JavaScript:** `<script>` etiketi ile `<head>` veya `<body>` bölümünde tanımlanır.
        ```html
        <script>
          console.log("JavaScript Çalışıyor");
        </script>
        ```
     3. **External JavaScript:** Harici bir dosya bağlanır.
        ```html
        <script src="script.js"></script>
        ```

2. **JavaScript’in Sağladığı Faydalar**

   - **Etkileşim:** Form doğrulama, buton tıklamaları gibi kullanıcı etkileşimlerini yönetir.
   - **Dinamik İçerik:** HTML içeriğini kullanıcı davranışlarına göre güncelleyebilir.
   - **Gelişmiş İşlevsellik:** Oyunlar, animasyonlar ve veri işleme gibi kompleks uygulamalar oluşturulabilir.

3. **Örnek JavaScript Kodu**
   ```javascript
   document.getElementById("button").addEventListener("click", function () {
     alert("Butona tıkladınız!");
   });
   ```

HTML içeriği:

```html
<button id="button">Tıklayın</button>
```

### 6.3. HTML, CSS ve JavaScript’in Birlikte Kullanımı

Bir web sayfasında HTML, CSS ve JavaScript’in birlikte kullanıldığı bir örnek:

```html
<!DOCTYPE html>
<html lang="tr">
  <head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>HTML, CSS ve JavaScript</title>
    <link rel="stylesheet" href="styles.css" />
  </head>
  <body>
    <h1>Hoş Geldiniz</h1>
    <p id="demo">Bu bir örnek metindir.</p>
    <button onclick="changeText()">Metni Değiştir</button>

    <script>
      function changeText() {
        document.getElementById("demo").textContent = "Metin değiştirildi!";
      }
    </script>
  </body>
</html>
```

`styles.css` dosyası:

```css
body {
  font-family: Arial, sans-serif;
  background-color: #f4f4f4;
  text-align: center;
  margin-top: 50px;
}
button {
  padding: 10px 20px;
  font-size: 16px;
  background-color: #4caf50;
  color: white;
  border: none;
  cursor: pointer;
}
button:hover {
  background-color: #45a049;
}
```

### 6.4. CSS ve JavaScript’in HTML’e Katkıları

1. **CSS:**

   - Kullanıcıya görsel olarak etkileyici bir deneyim sunar.
   - Tasarımı merkezi bir şekilde kontrol eder ve mobil uyumluluğu kolaylaştırır.

2. **JavaScript:**
   - Web sayfalarını daha etkileşimli ve kullanıcı dostu hale getirir.
   - Dinamik içerikler ve kullanıcı odaklı uygulamalar için temel sağlar.

## 7. Modern HTML ve Gelişim Süreci

HTML, ilk günlerinden bugüne kadar web teknolojilerinin temelini oluşturarak büyük bir gelişim göstermiştir. Modern HTML, sadece web sayfalarının yapısını tanımlamakla kalmaz; aynı zamanda daha anlamlı, erişilebilir ve zengin içeriklerin oluşturulmasını mümkün kılan birçok yeniliği de beraberinde getirmiştir. Bu bölümde, HTML’in gelişim sürecini ve modern özelliklerini ele alacağız.

### 7.1. HTML’in Evrimi

HTML’in gelişim süreci, web teknolojilerinin ihtiyaçlarına cevap verecek şekilde sürekli yenilenmiştir:

1. **HTML 1.0 (1991):**

   - Tim Berners-Lee tarafından tanıtılan en temel sürümdü.
   - Sadece bağlantılar ve basit metin düzenlemeleri için kullanılıyordu.

2. **HTML 2.0 (1995):**

   - İnternetin yaygınlaşmasıyla daha fazla özellik eklendi.
   - Formlar, tablolalar ve bazı basit özellikler tanıtıldı.

3. **HTML 3.2 (1997):**

   - Daha karmaşık yapıların oluşturulmasını sağladı.
   - JavaScript ve stil tanımları için temel destek sağladı.

4. **HTML 4.01 (1999):**

   - Çerçeveler, meta bilgiler ve daha gelişmiş yapılandırma desteklendi.
   - Web standartları daha fazla ön plana çıktı.

5. **HTML5 (2014):**
   - Günümüzde en yaygın kullanılan sürüm.
   - Mobil uyumluluk, multimedya desteği, semantik etiketler ve daha fazlasını içerir.

### 7.2. HTML5 ile Gelen Yenilikler

HTML5, web geliştiricilerinin modern ihtiyaçlarını karşılamak için birçok yenilik sunmuştur:

1. **Semantik Etiketler:**

   - Web içeriğini daha anlamlı hale getiren etiketler tanıtıldı.
   - Örnekler:
     - `<article>`, `<section>`, `<header>`, `<footer>` gibi yapılar.
   - Semantik yapı, arama motorlarının ve yardımcı teknolojilerin içeriği daha iyi anlamasına yardımcı olur.

2. **Multimedya Desteği:**

   - Gömülü video ve ses oynatıcılar için `<video>` ve `<audio>` etiketleri tanıtıldı.
     ```html
     <video controls>
       <source src="video.mp4" type="video/mp4" />
     </video>
     ```

3. **Form Doğrulama ve Yeni Giriş Türleri:**

   - HTML5, giriş elemanları için yeni türler ve özellikler ekledi.
   - Örnekler:
     - `<input type="email">`, `<input type="date">`, `<input type="range">`.
   - Yerleşik form doğrulama mekanizmaları geliştirildi.

4. **Canvas ve SVG:**

   - Grafik oluşturma ve manipülasyon için destek sağlandı.
     ```html
     <canvas id="cizim" width="500" height="500"></canvas>
     ```

5. **Yerel Depolama (LocalStorage ve SessionStorage):**

   - Verilerin kullanıcı cihazında depolanmasına olanak tanır.
   - Daha önceki çerez tabanlı çözümlere kıyasla daha güvenlidir.

6. **Mobil ve Responsive Tasarım Desteği:**
   - HTML5, mobil cihazlar için optimize edilmiş yapı sağlar.
   - `<meta name="viewport">` etiketiyle ekran boyutlarına uygun tasarım yapılabilir.

### 7.3. HTML’in Günümüzdeki Önemi

1. **Web Uygulamalarının Temeli:**

   - HTML, modern web uygulamalarının temel yapı taşını oluşturur.
   - JavaScript ve CSS ile birleştiğinde dinamik, etkileşimli ve kullanıcı dostu deneyimler sunar.

2. **Erişilebilirlik:**

   - HTML’in semantik yapısı, ekran okuyucular gibi yardımcı teknolojilerle tam uyum sağlar.
   - Engelli bireylerin de web içeriğine erişmesini kolaylaştırır.

3. **SEO (Arama Motoru Optimizasyonu):**
   - Semantik etiketler, arama motorlarının içeriği anlamasını ve sıralama algoritmalarında daha iyi değerlendirilmesini sağlar.

### 7.4. Geleceğin HTML’i

HTML’in gelişimi, teknolojik ihtiyaçlara paralel olarak devam etmektedir:

1. **Web 3.0 ve Semantik Web:**

   - Web’in daha akıllı ve anlamlı hale gelmesi için HTML’in semantik yapısı temel alınacaktır.
   - Örneğin, yapısal veri ve mikro veri formatları bu yönde adımlar atılmasını sağlar.

2. **Performans ve Güvenlik:**

   - Tarayıcıların HTML içeriğini daha hızlı işlemesi için yeni standartlar oluşturulmaktadır.
   - HTTPS gibi güvenlik protokolleriyle entegrasyon artırılmaktadır.

3. **Yapay Zeka ile Entegrasyon:**
   - HTML içeriği, yapay zeka modelleri tarafından analiz edilip optimize edilebilecektir.
   - Dinamik olarak içeriği özelleştiren sistemler daha yaygın hale gelecektir.

### 7.5. Modern HTML ile Örnek Bir Sayfa

```html
<!DOCTYPE html>
<html lang="tr">
  <head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Modern HTML Örneği</title>
  </head>
  <body>
    <header>
      <h1>Hoş Geldiniz</h1>
    </header>
    <section>
      <article>
        <h2>HTML5’in Özellikleri</h2>
        <p>HTML5, modern web ihtiyaçlarını karşılayan birçok yenilik sunar.</p>
      </article>
    </section>
    <footer>
      <p>&copy; 2024 Tüm Hakları Saklıdır.</p>
    </footer>
  </body>
</html>
```

### 7.6. Sonuç

HTML, basit bir işaretleme dili olmaktan çıkıp modern web dünyasının temel taşı haline gelmiştir. Sürekli evrimleşen bu teknoloji, hem geçmişte hem de gelecekte web deneyimini şekillendirmeye devam edecektir.

## 8. HTML Öğrenirken Yapılan Yaygın Hatalar

HTML öğrenmek genellikle kolay görünse de, başlangıçta yapılan bazı yaygın hatalar, yanlış alışkanlıkların oluşmasına neden olabilir ve bu hatalar ileri düzeyde web geliştirme süreçlerini zorlaştırabilir. Bu bölümde, HTML öğrenirken sıkça yapılan hataları ve bunlardan nasıl kaçınılacağını ele alacağız.

### 8.1. Doctype Deklarasyonunun Unutulması

**Hata:** HTML belgesine `<!DOCTYPE html>` bildirimi eklememek.

- Tarayıcılar, bu bildirime dayanarak belgenin hangi sürümde yazıldığını anlar.
- Bu bildirimi eklememek, tarayıcının belgenizi standart bir şekilde yorumlamasını engelleyebilir.

**Çözüm:** Her HTML belgesinin en üstüne `<!DOCTYPE html>` ekleyin:

```html
<!DOCTYPE html>
<html lang="tr">
  <!-- İçerik -->
</html>
```

### 8.2. Etiketleri Kapatmamak

**Hata:** Açılan HTML etiketlerini kapatmamak veya yanlış kapatmak.

- Özellikle `<p>`, `<div>`, `<ul>` gibi etiketlerin açık bırakılması, tarayıcıların içeriği yanlış yorumlamasına neden olabilir.

**Çözüm:** Her açılış etiketinin bir kapanış etiketi olduğundan emin olun:

```html
<p>Bu doğru bir paragraf etiketidir.</p>
```

### 8.3. Anlamsız ve Semantik Olmayan Etiket Kullanımı

**Hata:** İçeriği yapılandırırken anlamsız etiketler kullanmak (örneğin, `<div>` veya `<span>` etiketlerini gereksiz yere kullanmak).

- Bu, hem erişilebilirliği hem de SEO performansını olumsuz etkiler.

**Çözüm:** İçeriğin amacına uygun semantik etiketler kullanın:

```html
<section>
  <header>
    <h1>Başlık</h1>
  </header>
  <p>Bu bir makale içeriğidir.</p>
</section>
```

### 8.4. Meta Bilgileri Eklememek

**Hata:** `meta` etiketleri ve karakter kodlamalarını (örneğin, `UTF-8`) belirtmemek.

- Bu, özellikle farklı dillerde veya özel karakterlerde sorunlara yol açabilir.

**Çözüm:** Aşağıdaki gibi bir meta bilgisi ekleyin:

```html
<meta charset="UTF-8" />
```

### 8.5. Boş veya Eksik `alt` Özelliği Kullanmak

**Hata:** Görsellerde `alt` özelliğini boş bırakmak veya gereksiz yere doldurmak.

- Bu, erişilebilirlik açısından önemli bir eksikliktir.

**Çözüm:** Görsellerde uygun bir `alt` açıklaması kullanın:

```html
<img src="example.jpg" alt="Doğa manzarası" />
```

### 8.6. Inline CSS ve JavaScript Kullanımını Abartmak

**Hata:** Tüm stilleri ve script’leri HTML’nin içine yazmak.

- Bu, kodun okunabilirliğini ve bakımını zorlaştırır.

**Çözüm:** Harici CSS ve JavaScript dosyaları kullanın:

```html
<link rel="stylesheet" href="styles.css" />
<script src="scripts.js"></script>
```

### 8.7. Fazla Karmaşık ve Düzenlenmemiş Yapılar

**Hata:** İçeriği gereksiz yere karmaşık yapılarla oluşturmak.

- Bu, hem geliştiriciler hem de tarayıcılar için sayfanın anlaşılmasını zorlaştırır.

**Çözüm:** Kodunuzu düzenli ve sade bir yapıda tutun. Gereksiz `<div>` ve `<span>` kullanımından kaçının.

### 8.8. Form Doğrulama ve Giriş Türlerini İhmal Etmek

**Hata:** Form alanlarını doğrulamamak veya uygun giriş türlerini kullanmamak.

- Örneğin, e-posta için sadece `<input type="text">` kullanmak.

**Çözüm:** Uygun giriş türlerini kullanarak yerleşik doğrulamadan faydalanın:

```html
<input type="email" placeholder="E-posta adresinizi girin" />
```

### 8.9. Erişilebilirlik Özelliklerini Göz Ardı Etmek

**Hata:** Erişilebilirlik kurallarını (örneğin, `aria-label`, `alt`, `tabindex`) dikkate almamak.

- Bu, engelli kullanıcılar için web içeriğinin erişilebilirliğini düşürür.

**Çözüm:** Erişilebilirlik kurallarını uygulayın:

```html
<button aria-label="Menüyü aç">Menü</button>
```

### 8.10. HTML Belgesinin Doğruluğunu Kontrol Etmemek

**Hata:** Yazım hataları veya standart dışı etiketler kullanmak.

- Bu, tarayıcılarda beklenmedik davranışlara neden olabilir.

**Çözüm:** Kodunuzu düzenli olarak doğrulama araçlarıyla kontrol edin:

- [W3C Validator](https://validator.w3.org/) gibi araçları kullanarak kodunuzun standartlara uygunluğunu test edin.

### 8.11. SEO Kurallarını İhmal Etmek

**Hata:** Başlık etiketlerini (`<title>` ve `<h1>` gibi) uygun şekilde kullanmamak.

- Arama motorları, sayfa içeriğini anlamak için bu etiketlere öncelik verir.

**Çözüm:** SEO kurallarına uygun başlık yapıları kullanın:

```html
<title>Web Geliştirme Rehberi</title>
<h1>HTML Nedir?</h1>
```

### 8.12. Sonuç

HTML öğrenirken yapılan bu yaygın hatalardan kaçınmak, yalnızca doğru kod yazma becerisini geliştirmekle kalmaz, aynı zamanda web projelerinin daha erişilebilir, uyumlu ve etkili olmasını sağlar. İlk aşamalardan itibaren doğru alışkanlıklar edinmek, gelecekte karşılaşılabilecek sorunların önüne geçer.

## Son Sözler

HTML, tam 33 yıldır hayatımızda ve modern web teknolojilerinin temeli olarak her geçen gün daha da önem kazanıyor. İlk olarak 1991 yılında Tim Berners-Lee tarafından oluşturulduğunda, yalnızca birkaç basit etiketten ibaretti. Ancak bugün, milyarlarca web sayfasının yapı taşı ve birçok teknolojinin ilham kaynağı olarak hayatımızda kalmaya devam ediyor.

HTML, gelişen teknolojiye uyum sağlayarak sürekli evrimleşti. Günümüzde HTML5, mobil uyumlu tasarımlar, multimedya entegrasyonu ve semantik yapılar gibi modern ihtiyaçlara cevap verirken; gelecekte de yapay zeka, semantik web ve daha akıllı sistemler için temel oluşturmaya devam edecek. 33 yıldır olduğu gibi, önümüzdeki yıllarda da HTML’in web teknolojilerinin kalbinde yer alacağına şüphe yok.

Bu makale, HTML dünyasına bir giriş ve temel bir rehber niteliği taşıyor. HTML’in sadeliği ve esnekliği, onu sadece öğrenmesi kolay değil, aynı zamanda keşfetmesi keyifli bir araç haline getiriyor. Web dünyasına adım atmak isteyenler için HTML, uzun bir yolculuğun ilk adımıdır.

**HTML, 33 yıldır bizimle ve daha uzun yıllar bizimle olmaya devam edecek. O halde, kodlarınızda yaratıcılığınızı konuşturun ve bu evrensel dilin bir parçası olmaktan keyif alın. İyi kodlamalar!**
