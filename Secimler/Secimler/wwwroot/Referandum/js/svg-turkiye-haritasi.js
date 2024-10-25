let mainWindow; // İlk açılan sayfanın referansı
let activeCity = null; // Aktif şehirin referansı

function svgturkiyeharitasi() {
  const element = document.querySelector("#svg-turkiye-haritasi");
  const info = document.querySelector(".il-isimleri");

  element.addEventListener("mouseover", function (event) {
    if (
      event.target.tagName === "path" &&
      event.target.parentNode.id !== "guney-kibris"
    ) {
      
      var ilAdi = event.target.parentNode.getAttribute("data-iladi");
      var tabloIcerik = "<table>" +
                        "<tr><td>AKP</td><td>%60</td></tr>" +
                        "<tr><td>CHP</td><td>%30</td></tr>" +
                        "<tr><td>HDP</td><td>%10</td></tr>" +
                      "</table>";

      info.innerHTML = [
        "<div>",
        event.target.parentNode.getAttribute("data-iladi"),
        "<br>",
        tabloIcerik,
        "</div>",
      ].join("");
    }
  });

  element.addEventListener("mousemove", function (event) {
    info.style.top = event.pageY + 25 + "px";
    info.style.left = event.pageX + "px";
  });

  element.addEventListener("mouseout", function (event) {
    info.innerHTML = "";
  });

  element.addEventListener("click", function (event) {
    if (event.target.tagName === "path") {
      const parent = event.target.parentNode;
      const cityName = parent.getAttribute("data-iladi");
      const id = parent.getAttribute("id");

      // İlk açılan sayfa varsa ve açılmamışsa yeni pencere aç
      if (!mainWindow || mainWindow.closed) {
        openMainPage(cityName, id);
      } else {
        updateMainPage(cityName);
      }

      if (activeCity) {
        activeCity.style.opacity = 1; // Önceki şehrin şeffaflığını geri al
      }
      parent.style.opacity = 0.7; // Tıklanan şehri şeffaflaştır
      activeCity = parent;
    }
  });
}

// İlk açılan sayfayı oluştur veya güncelle
let existingWindow = null;

function updateMainPage(cityName) {
  const content = "<h2>" + cityName + "</h2>";
  
  // Eğer daha önce pencere açıldıysa ve hala açıksa, içeriği güncelle
  if (existingWindow && !existingWindow.closed) {
    existingWindow.document.body.innerHTML = content;
    existingWindow.focus();
  } else {
    // Aksi halde yeni bir pencere aç
    existingWindow = window.open('info.html', '_blank', 'width=600,height=400');
    existingWindow.onload = function() {
      existingWindow.document.body.innerHTML = content;
      existingWindow.focus();
    };
  }
}




// Yeni bir pencere aç ve ilk açılan sayfayı kaydet
function openMainPage(cityName, id) {
  const width = window.innerWidth * 0.5; // Ekran genişliğinin %20'si
  const height = window.innerHeight; // Ekran yüksekliğinin tamamı
  const left = 0; // Yeni pencere sol kenarda açılacak

  // Yeni bir pencere aç

  // Yeni pencerenin içeriğini oluştur
  const newWindow = window.open('info.html', '_blank', 'width=600,height=400');

}
svgturkiyeharitasi();
