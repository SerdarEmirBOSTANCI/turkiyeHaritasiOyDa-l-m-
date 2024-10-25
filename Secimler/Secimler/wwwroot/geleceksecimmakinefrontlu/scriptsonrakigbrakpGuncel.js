document
  .getElementById("predict-btnsonrakigbrakp")
  .addEventListener("click", function () {
    const loadingElement = document.getElementById("loadingsonrakigbrakp");
    const resultElement = document.getElementById("resultsonrakigbrakp");

    loadingElement.classList.remove("hiddensonrakigbrakp");
    resultElement.classList.add("hiddensonrakigbrakp");

    setTimeout(() => {
  
      loadingElement.classList.add("hiddensonrakigbrakp");

      
      const tahminOy = 14383344; 

      // Sonucu göster
      resultElement.innerText = `Gelecek Seçim AKP'nin tahmini oy sayısı(GBR): ${tahminOy}`;
      resultElement.classList.remove("hiddensonrakigbrakp");
    }, 2000);
  });
