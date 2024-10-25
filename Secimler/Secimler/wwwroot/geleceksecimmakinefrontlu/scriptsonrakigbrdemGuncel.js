document
  .getElementById("predict-btnsonrakigbrdem")
  .addEventListener("click", function () {
    const loadingElement = document.getElementById("loadingsonrakigbrdem");
    const resultElement = document.getElementById("resultsonrakigbrdem");

    loadingElement.classList.remove("hiddensonrakigbrdem");
    resultElement.classList.add("hiddensonrakigbrdem");

    setTimeout(() => {
      loadingElement.classList.add("hiddensonrakigbrdem");

      const tahminOy = 2627566;

      // Sonucu göster
      resultElement.innerText = `Bir Sonraki Seçim DEM'in tahmini oy sayısı(GBR): ${tahminOy}`;
      resultElement.classList.remove("hiddensonrakigbrdem");
    }, 2000); 
  });
