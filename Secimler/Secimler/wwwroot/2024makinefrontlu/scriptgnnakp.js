document
  .getElementById("predict-btngnnakp")
  .addEventListener("click", function () {
    const loadingElement = document.getElementById("loadinggnnakp");
    const resultElement = document.getElementById("resultgnnakp");

    // Loading animasyonu göster
    loadingElement.classList.remove("hiddengnnakp");
    resultElement.classList.add("hiddengnnakp");

    // Tahmin sonucu hesaplanıyor simülasyonu (gerçek tahmin yerine)
    setTimeout(() => {
      // Loading animasyonu gizle
      loadingElement.classList.add("hiddengnnakp");

      // Gerçek tahmin sonucu (örnek)
      const tahminOy = 15662620; // Bu değeri Python modelinden alabilirsiniz

      // Sonucu göster
      resultElement.innerText = `2024 yılında AKP'nin tahmini oy sayısı(GNN): ${tahminOy}`;
      resultElement.classList.remove("hiddengnnakp");
    }, 2000); // 2 saniyelik gecikme (simülasyon için)
  });
