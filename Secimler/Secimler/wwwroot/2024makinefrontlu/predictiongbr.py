import numpy as np
from sklearn.ensemble import GradientBoostingRegressor

# Veriler
yil = np.array([2002, 2004, 2007, 2009, 2011, 2014, 2015, 2018, 2019, 2023,2024]).reshape(-1, 1)
oy = np.array([6113352, 5882810, 7300234, 9229936, 11155972, 15587720, 11518139, 11354190, 13218754, 17409137, 17409137])

# Modeli eğit
model = GradientBoostingRegressor()
model.fit(yil, oy)

# Tahmin
sonraki_yil = 2027  # Tahmin edilecek yıl
tahmin_oy = model.predict([[sonraki_yil]])
print(f"{sonraki_yil} yılında CHP'nin tahmini oy sayısı: {int(tahmin_oy[0])}")
