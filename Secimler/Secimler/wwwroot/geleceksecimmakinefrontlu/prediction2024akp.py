import numpy as np
from sklearn.ensemble import GradientBoostingRegressor

# Veriler
yil = np.array([2002, 2004, 2007, 2009, 2011, 2014, 2015, 2018, 2019, 2023]).reshape(-1, 1) # iki boyutlu bir dizi haline getirdim. sütun ve satır olacak şekilde.
oy = np.array([10808229, 13447287, 16340534, 15353553, 21399693, 19469840, 18867411, 21338693, 19766640, 19392462])

# Modeli eğit
model = GradientBoostingRegressor() #regresyon modelini oluşturmak için kullandım .
model.fit(yil, oy)

# Tahmin
sonraki_yil = 2024  # Tahmin edilecek yıl
tahmin_oy = model.predict([[sonraki_yil]])

# Yeniden refah değişkeni oluştur ve AKP'nin aldığı oy sayısından çıkar
akp_oy = tahmin_oy[0] - (tahmin_oy[0] * 0.12)

print(f"{sonraki_yil} yılında AKP'nin tahmini oy sayısı: {int(akp_oy)}")
