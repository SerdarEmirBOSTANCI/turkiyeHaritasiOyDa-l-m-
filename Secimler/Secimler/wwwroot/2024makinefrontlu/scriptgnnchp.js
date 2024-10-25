document
  .getElementById("predict-btngnnchp")
  .addEventListener("click", function () {
    const loadingElement = document.getElementById("loadinggnnchp");
    const resultElement = document.getElementById("resultgnnchp");

    // Loading animasyonu göster
    loadingElement.classList.remove("hiddengnnchp");
    resultElement.classList.add("hiddengnnchp");

    // Tahmin sonucu hesaplanıyor simülasyonu (gerçek tahmin yerine)
    setTimeout(() => {
      // Loading animasyonu gizle
      loadingElement.classList.add("hiddengnnchp");

      // Gerçek tahmin sonucu (örnek)
      const tahminOy = 10426722; // Değer Python modelinden alınıyor.

      // Sonucu göster
      resultElement.innerText = `2024 yılında CHP'nin tahmini oy sayısı(GNN): ${tahminOy}`;
      resultElement.classList.remove("hiddengnnchp");
    }, 2000); // 2 saniyelik gecikme (simülasyon için)
  });
