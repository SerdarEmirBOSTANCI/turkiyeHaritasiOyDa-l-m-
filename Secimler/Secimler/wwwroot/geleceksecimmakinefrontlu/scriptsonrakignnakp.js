document
  .getElementById("predict-btnsonrakignnakp")
  .addEventListener("click", function () {
    const loadingElement = document.getElementById("loadingsonrakignnakp");
    const resultElement = document.getElementById("resultsonrakignnakp");

    loadingElement.classList.remove("hiddensonrakignnakp");
    resultElement.classList.add("hiddensonrakignnakp");

    setTimeout(() => {
      loadingElement.classList.add("hiddensonrakignnakp");

      const tahminOy = 15917528; 

      // Sonucu göster
      resultElement.innerText = `Sonraki Seçimde AKP'nin tahmini oy sayısı(GNN): ${tahminOy}`;
      resultElement.classList.remove("hiddensonrakignnakp");
    }, 2000); 
  });
