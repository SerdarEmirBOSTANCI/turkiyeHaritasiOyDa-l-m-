document
  .getElementById("predict-btnknnakp")
  .addEventListener("click", function () {
    const loadingElement = document.getElementById("loadingknnakp");
    const resultElement = document.getElementById("resultknnakp");

    // Loading animasyonu göster
    loadingElement.classList.remove("hiddenknnakp");
    resultElement.classList.add("hiddenknnakp");

    // Tahmin sonucu hesaplanıyor simülasyonu (gerçek tahmin yerine)
    setTimeout(() => {
      // Loading animasyonu gizle
      loadingElement.classList.add("hiddenknnakp");

      // Gerçek tahmin sonucu (örnek)
      const tahminOy = 17746019; // Bu değeri Python modelinden alabilirsiniz

      // Sonucu göster
      resultElement.innerText = `2024 yılında AKP'nin tahmini oy sayısı(KNN): ${tahminOy}`;
      resultElement.classList.remove("hiddenknnakp");
    }, 2000); // 2 saniyelik gecikme (simülasyon için)
  });
