document
  .getElementById("predict-btnakp")
  .addEventListener("click", function () {
    const loadingElement = document.getElementById("loadingakp");
    const resultElement = document.getElementById("resultakp");

    // Loading animasyonu göster
    loadingElement.classList.remove("hiddenakp");
    resultElement.classList.add("hiddenakp");

    // Tahmin sonucu hesaplanıyor simülasyonu (gerçek tahmin yerine)
    setTimeout(() => {
      // Loading animasyonu gizle
      loadingElement.classList.add("hiddenakp");

      // Gerçek tahmin sonucu (örnek)
      const tahminOy = 17067976; // Bu değeri Python modelinden alabilirsiniz

      // Sonucu göster
      resultElement.innerText = `2024 yılında AKP'nin tahmini oy sayısı(GBR): ${tahminOy}`;
      resultElement.classList.remove("hiddenakp");
    }, 2000); // 2 saniyelik gecikme (simülasyon için)
  });
