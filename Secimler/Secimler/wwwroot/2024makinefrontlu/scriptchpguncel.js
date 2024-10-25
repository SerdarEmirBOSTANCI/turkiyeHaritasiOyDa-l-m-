document
  .getElementById("predict-btnchp")
  .addEventListener("click", function () {
    const loadingElement = document.getElementById("loadingchp");
    const resultElement = document.getElementById("resultchp");

    // Loading animasyonu göster
    loadingElement.classList.remove("hiddenchp");
    resultElement.classList.add("hiddenchp");

    // Tahmin sonucu hesaplanıyor simülasyonu (gerçek tahmin yerine)
    setTimeout(() => {
      // Loading animasyonu gizle
      loadingElement.classList.add("hiddenchp");

      // Gerçek tahmin sonucu (örnek)
      const tahminOy = 17408656; // Bu değeri Python modelinden alabilirsiniz

      // Sonucu göster
      resultElement.innerText = `2024 yılında CHP'nin tahmini oy sayısı(GBR): ${tahminOy}`;
      resultElement.classList.remove("hiddenchp");
    }, 2000); // 2 saniyelik gecikme (simülasyon için)
  });
