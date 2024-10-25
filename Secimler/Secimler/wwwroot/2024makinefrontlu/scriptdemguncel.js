document
  .getElementById("predict-btndem")
  .addEventListener("click", function () {
    const loadingElement = document.getElementById("loadingdem");
    const resultElement = document.getElementById("resultdem");

    // Loading animasyonu göster
    loadingElement.classList.remove("hiddendem");
    resultElement.classList.add("hiddendem");

    // Tahmin sonucu hesaplanıyor simülasyonu (gerçek tahmin yerine)
    setTimeout(() => {
      // Loading animasyonu gizle
      loadingElement.classList.add("hiddendem");

      // Gerçek tahmin sonucu (örnek)
      const tahminOy = 4803900; // Bu değeri Python modelinden alabilirsiniz

      // Sonucu göster
      resultElement.innerText = `2024 yılında DEM'in tahmini oy sayısı(GBR): ${tahminOy}`;
      resultElement.classList.remove("hiddendem");
    }, 2000); // 2 saniyelik gecikme (simülasyon için)
  });
