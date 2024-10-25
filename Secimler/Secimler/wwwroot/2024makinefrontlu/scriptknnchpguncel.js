document
  .getElementById("predict-btnknnchp")
  .addEventListener("click", function () {
    const loadingElement = document.getElementById("loadingknnchp");
    const resultElement = document.getElementById("resultknnchp");

    // Loading animasyonu göster
    loadingElement.classList.remove("hiddenknnchp");
    resultElement.classList.add("hiddenknnchp");

    // Tahmin sonucu hesaplanıyor simülasyonu (gerçek tahmin yerine)
    setTimeout(() => {
      // Loading animasyonu gizle
      loadingElement.classList.add("hiddenknnchp");

      // Gerçek tahmin sonucu (örnek)
      const tahminOy = 16692556; // Bu değeri Python modelinden alabilirsiniz

      // Sonucu göster
      resultElement.innerText = `2024 yılında CHP'nin tahmini oy sayısı(KNN): ${tahminOy}`;
      resultElement.classList.remove("hiddenknnchp");
    }, 2000); // 2 saniyelik gecikme (simülasyon için)
  });
