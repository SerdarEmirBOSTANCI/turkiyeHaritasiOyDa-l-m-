document
  .getElementById("predict-btnknndem")
  .addEventListener("click", function () {
    const loadingElement = document.getElementById("loadingknndem");
    const resultElement = document.getElementById("resultknndem");

    // Loading animasyonu göster
    loadingElement.classList.remove("hiddenknndem");
    resultElement.classList.add("hiddenknndem");

    // Tahmin sonucu hesaplanıyor simülasyonu (gerçek tahmin yerine)
    setTimeout(() => {
      // Loading animasyonu gizle
      loadingElement.classList.add("hiddenknndem");

      // Gerçek tahmin sonucu (örnek)
      const tahminOy = 3378349; // Bu değeri Python modelinden alabilirsiniz

      // Sonucu göster
      resultElement.innerText = `2024 yılında DEM'in tahmini oy sayısı(KNN): ${tahminOy}`;
      resultElement.classList.remove("hiddenknndem");
    }, 2000); // 2 saniyelik gecikme (simülasyon için)
  });
