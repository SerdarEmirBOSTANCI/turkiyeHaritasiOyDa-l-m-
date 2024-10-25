document
  .getElementById("predict-btnsonrakiknnakp")
  .addEventListener("click", function () {
    const loadingElement = document.getElementById("loadingsonrakiknnakp");
    const resultElement = document.getElementById("resultsonrakiknnakp");

    loadingElement.classList.remove("hiddensonrakiknnakp");
    resultElement.classList.add("hiddensonrakiknnakp");

    setTimeout(() => {
      loadingElement.classList.add("hiddensonrakiknnakp");

      const tahminOy = 16280092; 

      // Sonucu göster
      resultElement.innerText = `Bir Sonraki Seçim AKP'nin tahmini oy sayısı(KNN): ${tahminOy}`;
      resultElement.classList.remove("hiddensonrakiknnakp");
    }, 2000); 
  });
