import numpy as np
from sklearn.ensemble import GradientBoostingRegressor

# Veriler
yil = np.array([2014, 2013, 2015, 2018, 2017, 2019, 2023]).reshape(-1, 1)
oy = np.array([3958048, 2928945, 6058489, 4205794, 4867302, 2703595, 4803922])

# Modeli eğit
model = GradientBoostingRegressor()
model.fit(yil, oy)

# Tahmin
sonraki_yil = 2024  # Tahmin edilecek yıl
tahmin_oy = model.predict([[sonraki_yil]])
print(f"{sonraki_yil} yılında DEM'in tahmini oy sayısı: {int(tahmin_oy[0])}")



