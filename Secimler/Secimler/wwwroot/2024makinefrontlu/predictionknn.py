import numpy as np
from sklearn.neighbors import KNeighborsRegressor

# Verileri ve hedef değişkeni tanımlayın
yil = np.array([2002, 2004, 2007, 2009, 2011, 2014, 2015, 2018, 2019, 2023, 2024]).reshape(-1, 1)
oy = np.array([10808229, 13447287, 16340534, 15353553, 21399082, 19469840, 18867411, 21338693, 19766640, 19392462,16341212])

# KNN modelini oluşturun ve eğitin
knn_model = KNeighborsRegressor(n_neighbors=3) # 3 komşu kullanacağız
knn_model.fit(yil, oy)

# Tahmin yapın
sonraki_secim_yili = np.array([[2028]]) # Tahmin etmek istediğiniz yılı buraya girin
tahmin_oy = knn_model.predict(sonraki_secim_yili)

# Yeniden refah değişkenini oluşturun
yeniden_refah = tahmin_oy * 0.12

# Sonucu döndürürken yeniden refah değişkenini çıkarın
sonuc = tahmin_oy - yeniden_refah
print("Sonuç:", sonuc[0])
