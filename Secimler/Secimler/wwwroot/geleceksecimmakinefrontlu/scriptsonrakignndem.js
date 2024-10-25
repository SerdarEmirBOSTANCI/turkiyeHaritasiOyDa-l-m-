document
  .getElementById("predict-btnsonrakignndem")
  .addEventListener("click", function () {
    const loadingElement = document.getElementById("loadingsonrakignndem");
    const resultElement = document.getElementById("resultsonrakignndem");

    loadingElement.classList.remove("hiddensonrakignndem");
    resultElement.classList.add("hiddensonrakignndem");

    setTimeout(() => {
      loadingElement.classList.add("hiddensonrakignndem");

      const tahminOy = 3742413; 

      // Sonucu göster
      resultElement.innerText = `Bir sonraki seçimde DEM'in tahmini oy sayısı(GNN): ${tahminOy}`;
      resultElement.classList.remove("hiddensonrakignndem");
    }, 2000); 
  });
