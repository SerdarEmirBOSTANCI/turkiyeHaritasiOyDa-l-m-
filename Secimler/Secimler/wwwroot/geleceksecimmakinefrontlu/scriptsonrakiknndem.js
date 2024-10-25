document
  .getElementById("predict-btnsonrakiknndem")
  .addEventListener("click", function () {
    const loadingElement = document.getElementById("loadingsonrakiknndem");
    const resultElement = document.getElementById("resultsonrakiknndem");

    loadingElement.classList.remove("hiddensonrakiknndem");
    resultElement.classList.add("hiddensonrakiknndem");

    setTimeout(() => {
      loadingElement.classList.add("hiddensonrakiknndem");

      const tahminOy = 3378349; 

      // Sonucu göster
      resultElement.innerText = `Bir Sonraki Seçimde DEM'in tahmini oy sayısı(KNN): ${tahminOy}`;
      resultElement.classList.remove("hiddensonrakiknndem");
    }, 2000); 
  });
