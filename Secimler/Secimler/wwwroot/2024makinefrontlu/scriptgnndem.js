document
  .getElementById("predict-btngnndem")
  .addEventListener("click", function () {
    const loadingElement = document.getElementById("loadinggnndem");
    const resultElement = document.getElementById("resultgnndem");

    // Loading animasyonu göster
    loadingElement.classList.remove("hiddengnndem");
    resultElement.classList.add("hiddengnndem");

    // Tahmin sonucu hesaplanıyor simülasyonu (gerçek tahmin yerine)
    setTimeout(() => {
      // Loading animasyonu gizle
      loadingElement.classList.add("hiddengnndem");

      // Gerçek tahmin sonucu (örnek)
      const tahminOy = 3558888; // Bu değeri Python modelinden alabilirsiniz

      // Sonucu göster
      resultElement.innerText = `2024 yılında DEM'in tahmini oy sayısı(GNN): ${tahminOy}`;
      resultElement.classList.remove("hiddengnndem");
    }, 2000); // 2 saniyelik gecikme (simülasyon için)
  });
