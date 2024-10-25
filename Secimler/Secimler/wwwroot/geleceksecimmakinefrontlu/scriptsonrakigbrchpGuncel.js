document
  .getElementById("predict-btnsonrakigbrchp")
  .addEventListener("click", function () {
    const loadingElement = document.getElementById("loadingsonrakigbrchp");
    const resultElement = document.getElementById("resultsonrakigbrchp");

    loadingElement.classList.remove("hiddensonrakigbrchp");
    resultElement.classList.add("hiddensonrakigbrchp");

    setTimeout(() => {
      loadingElement.classList.add("hiddensonrakigbrchp");

      const tahminOy = 17408849; 

      // Sonucu göster
      resultElement.innerText = `2027 yılında CHP'nin tahmini oy sayısı(GBR): ${tahminOy}`;
      resultElement.classList.remove("hiddensonrakigbrchp");
    }, 2000); 
  });
