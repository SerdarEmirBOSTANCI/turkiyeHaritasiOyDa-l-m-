document
  .getElementById("predict-btnsonrakiknnchp")
  .addEventListener("click", function () {
    const loadingElement = document.getElementById("loadingsonrakiknnchp");
    const resultElement = document.getElementById("resultsonrakiknnchp");

    loadingElement.classList.remove("hiddensonrakiknnchp");
    resultElement.classList.add("hiddensonrakiknnchp");

    setTimeout(() => {
      loadingElement.classList.add("hiddensonrakiknnchp");

      const tahminOy = 18710871; 

      // Sonucu göster
      resultElement.innerText = `Bir Sonraki Seçim CHP'nin tahmini oy sayısı(KNN): ${tahminOy}`;
      resultElement.classList.remove("hiddensonrakiknnchp");
    }, 2000); 
  });
