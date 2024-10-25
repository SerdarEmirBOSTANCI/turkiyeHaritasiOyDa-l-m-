document
  .getElementById("predict-btnsonrakignnchp")
  .addEventListener("click", function () {
    const loadingElement = document.getElementById("loadingsonrakignnchp");
    const resultElement = document.getElementById("resultsonrakignnchp");

    loadingElement.classList.remove("hiddensonrakignnchp");
    resultElement.classList.add("hiddensonrakignnchp");

    setTimeout(() => {
      loadingElement.classList.add("hiddensonrakignnchp");

        const tahminOy = 13897735;

      // Sonucu göster
      resultElement.innerText = `Bir sonraki seçim CHP'nin tahmini oy sayısı(GNN): ${tahminOy}`;
      resultElement.classList.remove("hiddensonrakignnchp");
    }, 2000); 
  });
